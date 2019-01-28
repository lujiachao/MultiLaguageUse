using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace MultiLaguageLibrary
{
    public class GetResourcesFactory : IGetResourcesFactory
    {
        public static ResourceManager rm = null;

        ///<summary>
        /// 绑定资源文件
        /// </summary>
        public ResourceManager FindLanguageResource()
        {
            if (rm != null)
            {
                rm.ReleaseAllResources();
                rm = null;
            }
            rm = ResourceManager.CreateFileBasedResourceManager(MultiLanguageOption.baseName, MultiLanguageOption.resourceDir, MultiLanguageOption.usingResourceSet);
            return rm;
        }
    }
}
