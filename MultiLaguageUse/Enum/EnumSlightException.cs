using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLanguageWebTest.Enum
{ 
    public enum EnumSlightException
    {
        Username = 1,       //轻微异常 1    - 1000
        Login = 1001,       //一般异常 1001 - 2000 
        Language = 2001     //严重异常 2001 - 3000
    }
}
