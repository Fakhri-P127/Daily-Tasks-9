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
                if (isSame) // umumi bir soz axtarirdiqsa(meselcun rabbit olub olmadigini) o vaxt elave bir deyer yaradib onu o deyere beraber edenden sonra axtarilanla onu muqasiye edirik, beraberdise true versin ve bu if serti odenilsin yox odemirse for loopuna(i=0 olana) geri donur. Yeni rabbit olmayana kimi(rabbi,rabb,ra)false verecek. Mutleq rabbit olmalidir
                {
                    return axtarilan + " exists!";
                }
            }
            return "Does Not Contain " + axtarilan;
        }                
        
    }
}
