using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{

    // Two strings are given. Modify 1st string such that 
    //all the common characters of the 2nd strings have to be removed and 
    //the uncommon characters of the 2nd string have to be concatenated with 
    //uncommon characters of the 1st string.

    // Note: If the modified string is empty then print '-1'.
    static public class CommonNConcat
    {
        static void Main(string[] args)
        {
            string str1 = "aacdb";
            string str2 = "gafd";

            string str3 = "abcs";
            string str4 = "cxzca";
            RmvCommonNConcat(str1, str2);
            RmvCommonNConcat(str3, str4);

        }

        static void RmvCommonNConcat(string str1, string str2)
        {
            StringBuilder resultStr = new StringBuilder();
            List<int> UniqStr2 = new List<int>();
            for (int i = 0; i < str1.Length; i++)
            {
                bool exist = false;
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        exist = true;
                        if (!UniqStr2.Contains(str2[j]))
                        {
                            UniqStr2.Add(str2[j]);
                        }
                        break;
                    }
                }
                if (!exist)
                {
                    resultStr.Append(str1[i]);
                }
            }
            int notUniqIdx = UniqStr2.Count;
            for (int i = 0; i < str2.Length; i++)
            {
                if (!(UniqStr2.Contains(str2[i])))
                {
                    resultStr.Append(str2[i]);
                }
            }

            if (resultStr.Length == 0)
            {
                System.Console.WriteLine(-1);
            }
            else
            {
                System.Console.WriteLine(resultStr.ToString());
            }
        }
    }
}
