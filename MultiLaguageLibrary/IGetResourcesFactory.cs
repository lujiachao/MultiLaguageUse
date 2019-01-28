using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace MultiLaguageLibrary
{
    public interface IGetResourcesFactory
    {
        ResourceManager FindLanguageResource();
    }
}
