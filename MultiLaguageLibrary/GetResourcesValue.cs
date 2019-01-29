using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace MultiLaguageLibrary
{
    public class GetResourcesValue
    {
        private GetResourcesFactory getResourcesFactory = new GetResourcesFactory();
        /// <summary>
        /// 获取Resources
        /// </summary>
        public ResourceManager _ResourceManager
        {
            get
            {
                var resourceManager = getResourcesFactory.FindLanguageResource();
                return resourceManager;
            }
        }


        public string GetStringValue(string str)
        {
            try
            {
                ResourceManager rm = _ResourceManager;
                return rm.GetString(str);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
