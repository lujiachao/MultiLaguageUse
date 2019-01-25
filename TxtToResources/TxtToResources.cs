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
        ResourceManager rm = null;
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
            if (fileTxt != null)
            {
                MessageBox.Show("未选择文件请重试");
                return;
            }
            IResourceWriter writer = new ResourceWriter(fileTxt);
            writer.AddResource("string 1", "First String");
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
    }
}
