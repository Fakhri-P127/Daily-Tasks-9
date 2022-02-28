using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    static class Extension
    {
        public static string ToCapitalized(this string[] arr)
        {            
            StringBuilder[] stringBuilder = new StringBuilder[arr.Length];            
            
            for (int k = 0; k < arr.Length; k++)
            {
                arr[k] = arr[k].ToLower();
                stringBuilder[k] = new StringBuilder();
                stringBuilder[k].Append(char.ToUpper(arr[k][0]).ToString());
                for (int i = 1; i < arr[k].Length; i++)
                {
                    stringBuilder[k].Append(arr[k][i]);
                }                
            }
            StringBuilder stringBuilder1 = new StringBuilder();

            for (int i = 0; i < stringBuilder.Length; i++)
            {                               
                stringBuilder1.Append($"{stringBuilder[i]} ");
            }

            return stringBuilder1.ToString();           
        }
    }
}
