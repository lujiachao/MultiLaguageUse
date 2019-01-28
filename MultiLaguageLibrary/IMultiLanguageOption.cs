using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLaguageLibrary
{
    public interface IMultiLanguageOption
    {
        string baseName { get; set; }

        string resourceDir { get; set; }

        Type usingResourceSet { get; set; }
    }
}
