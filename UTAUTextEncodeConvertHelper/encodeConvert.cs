using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTAUTextEncodeConvertHelper
{
    class encodeConvert
    {
        public static String Converter(string str,Encoding encode)
        {
            if (encode == Encoding.GetEncoding("Shift_JIS"))
            {
                String strAfterConvert = Encoding.GetEncoding("gb2312").GetString(Encoding.GetEncoding("Shift_JIS").GetBytes(str));
                return strAfterConvert;
            }
            else if (encode == Encoding.GetEncoding("gb2312"))
            {
                String strAfterConvert = Encoding.GetEncoding("Shift_JIS").GetString(Encoding.GetEncoding("gb2312").GetBytes(str));
                return strAfterConvert;
            }
            else if (encode == Encoding.UTF8)
            {
                String strAfterConvert = Encoding.UTF8.GetString(Encoding.GetEncoding("gb2312").GetBytes(str));
                return strAfterConvert;
            }
            else
            {
                return "Error Unsupported Encode";
            }
        }
    }
}
