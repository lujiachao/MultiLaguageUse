using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLaguageLibrary
{
    public class MultiLaguagePower
    {
        //resgen zh_CN.txt zh_CN.resources 生成resources文件
        public static string baseDirectory = AppContext.BaseDirectory + "languageresources";     //执行10万次 8毫秒
        public static IServiceProvider languageBind(IServiceProvider serviceProvider, string filePath = null, string charset = "en_US")
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = baseDirectory;
            }

            MultiLanguageOption.baseName = charset;
            MultiLanguageOption.resourceDir = filePath;
            MultiLanguageOption.usingResourceSet = null;
            return serviceProvider;
        }

        public static IServiceProvider languageBind(string filePath = null, string charset = "en_US")
        {
            var serviceCollection = new ServiceCollection();
            return languageBind(serviceCollection.BuildServiceProvider(), filePath, charset);
        }
    }
}
