using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Analizator9000
{
    class Utils
    {
        static public String getFilename(String extension)
        {
            return "an9k-" + DateTime.Now.ToString("yyyyMMddHHmmssFFF") + "." + extension;
        }
    }
}
