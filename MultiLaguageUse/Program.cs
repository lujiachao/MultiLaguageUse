using MultiLanguageWebTest.Enum;
using MultiLanguageWebTest.JsonHelper;
using System;
using System.Diagnostics;
using System.IO;
using System.Resources;

namespace MultiLanguageWebTest
{
    public class Program
    {

        //resgen zh_CN.txt zh_CN.resources 生成resources文件
        public static string baseDirectory = AppContext.BaseDirectory + "languageresources";     //执行10万次 8毫秒
        public static string basePath = Directory.GetCurrentDirectory() + "languageresources"; //执行10万次 16毫秒
        public static ResourceManager rm = null;
        public static void Main(string[] args)
        {
            FindFindLanguageResource(JsonConfigurationHelper.GetAppSettingSingle("language"));
            string Value = GetStringValue(EnumSlightException.Login.ToString());
            if (Value == null)
            {
                Console.WriteLine("该键值对不存在,请核对您输入的键值");
            }
            Console.WriteLine(Value);
            Console.ReadKey();
        }

        public static void FindFindLanguageResource(string Charset = "en_US")
        {
            DirectoryInfo di = new DirectoryInfo(baseDirectory );
            string filePath = baseDirectory + $"\\{Charset}.resources";
            if (di == null)
            {
                return;
            }
            if (!Directory.Exists(baseDirectory))
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
            //string tmp = $"\\{Charset}.resources";
            //string languagefile = tmp.Substring(0, tmp.ToUpper().IndexOf(".RESOURCES"));
            rm = ResourceManager.CreateFileBasedResourceManager(Charset, baseDirectory,null);            
        }

        public static string GetStringValue(string str)
        {
            try
            {
                return rm.GetString(str);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
