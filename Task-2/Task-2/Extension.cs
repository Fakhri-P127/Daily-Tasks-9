using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    static class Extension
    {      
        public static string IsContains(this string str)
        {
            Console.WriteLine("What are you looking for?");
            string axtarilan = Console.ReadLine();                      
            
            for (int i = 0; i < str.Length; i++)
            {
                bool isSame = true;
                for (int m = 0; m < axtarilan.Length; m++)
                {
                    if (str[i + m] != axtarilan[m])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    return axtarilan + " exists!";
                }
            }
            return "Does Not Contain " + axtarilan;
        }                
        
    }
}
