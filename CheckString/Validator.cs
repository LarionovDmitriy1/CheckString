using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckString;

public class Validator
{
    public static bool WorkVolidator(string str)
    {
        bool result = false;
        if (str.Length == 0 || string.IsNullOrEmpty(str)) { return false; }
        int count = 0;
        char[] chars = new char[] { '_', ' ', '-', ';', ':', ',', '/', '*', '+' };
        for (int i = 0; i < str.Length; i++)
        {
            if (chars.Contains(str[i]))
            {
                return false;
            }
            for (int j = 0; j < str.Length - 1; j++)
            {
                if (char.IsDigit(str[j]) && char.IsDigit(str[j + 1]))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
