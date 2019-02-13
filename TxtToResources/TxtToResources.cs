using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TxtToResources
{
    public partial class TxtToResources : Form
    {
        public static ResourceManager rm = null;
        public TxtToResources()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; //该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileTxt = dialog.FileName;
                txtOpenFileTxt.Text = fileTxt;
            }
        }

        private void btnCreateResources_Click(object sender, EventArgs e)
        {
            string fileTxt = txtOpenFileTxt.Text; 
            string rootDirectory = Path.GetDirectoryName(fileTxt) + @"\";        //获取文件所在目录
            string fileName = Path.GetFileNameWithoutExtension(fileTxt);  //获取文件名不包含后缀
            IResourceWriter writer = new ResourceWriter(rootDirectory + fileName + ".resources");
            if (string.IsNullOrWhiteSpace(fileTxt))
            {
                MessageBox.Show("未选择文件请重试");
                return;
            }
            string txtKeyValue = File.ReadAllText(fileTxt);
            string[] strKeyValueArrays = txtKeyValue.Split(',');
            foreach (var strKeyValueArray in strKeyValueArrays)
            {
                string[] strSingleArrays = strKeyValueArray.Split('=');
                writer.AddResource( strSingleArrays[0].Trim(), strSingleArrays[1].Trim());
            }
            writer.Close();
        }

        private void btnOpenFileResources_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; //该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.resources)|*.resources";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileTxt = dialog.FileName;
                txtBoxeResources.Text = fileTxt;
            }
        }

        private void btnWriteInResourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxeResources.Text))
            {
                MessageBox.Show("资源文件路径不可为空，请重新输入!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxKey.Text))
            {
                MessageBox.Show("输入的键不可为空,请重新输入!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxValue.Text))
            {
                MessageBox.Show("输入值不可为空，请重新输入!");
            }
            IResourceWriter writer = new ResourceWriter(txtBoxeResources.Text);
            writer.AddResource(textBoxKey.Text, textBoxValue.Text);
            writer.Close();
        }

        /// <summary>
        /// 选择资源文件，按钮单机事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; //该值确定是否可以选择多个文件
            dialog.Title = "请选择文件夹";
            dialog.Filter = "所有文件(*.resources)|*.resources";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileTxt = dialog.FileName;
                textBox1.Text = fileTxt;
            }
        }

        /// <summary>
        /// 根据键获取值，按钮单机事件。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("读取操作,资源文本路径不可为空！");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("查询的键值不可为空,请重试！");
                return;
            }
            string fileTxt = textBox1.Text;
            string rootDirectory = Path.GetDirectoryName(fileTxt);        //获取文件所在目录
            string fileName = Path.GetFileNameWithoutExtension(fileTxt);  //获取文件名不包含后缀
            if (rm != null)
            {
                rm.ReleaseAllResources();
                rm = null;
            }
            FindFindLanguageResource(rootDirectory, fileName);
            string Value = GetStringValue(textBox2.Text);
            if (Value == null)
            {
                MessageBox.Show("该键值对不存在,请核对您输入的键值");
                return;
            }
            textBox3.Text = Value;
        }


       /// <summary>
       /// 获取资源文件
       /// </summary>
       /// <param name="Charset"></param>
        public static void FindFindLanguageResource(string directoryResources,string Charset = "en_US")
        {
            if (string.IsNullOrWhiteSpace(directoryResources))
            {
                MessageBox.Show("资源文件路径不存在请重试");
                return;
            }
            DirectoryInfo di = new DirectoryInfo(directoryResources);
            string filePath = directoryResources + $"\\{Charset}.resources";
            if (di == null)
            {
                return;
            }
            if (!Directory.Exists(directoryResources))
            {
                Console.WriteLine("该路径下文件夹不存在");
                return;
            }
            if (rm != null)
            {
                rm.ReleaseAllResources();
                rm = null;
            }
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"{Charset}语言包文件不存在");
                return;
            }
            rm = ResourceManager.CreateFileBasedResourceManager(Charset, directoryResources, null);
        }

        /// <summary>
        /// 获取资源文件键对应的值
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetStringValue(string str)
        {
            try
            {
                return rm.GetString(str);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
