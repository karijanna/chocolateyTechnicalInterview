using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateyTechnicalInterview
{
    public class ReverseWordsInString
    {
        internal static string ReverseWordOrder(string str)
        {
            StringBuilder sb = new StringBuilder();
            string[] myStr = str.Split(' ');
            for (int i = myStr.Length - 1; i >= 0; i--)
            {
                sb.Append(myStr[i]);
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}

//reference: https://stackoverflow.com/questions/8928601/how-can-i-split-a-string-with-a-string-delimiter
