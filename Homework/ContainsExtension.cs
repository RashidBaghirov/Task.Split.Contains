using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal static class Extension
    {
        public static bool CustomContains(this string sentence, string search)
        { 
            
            var length = sentence.Length - search.Length;
            if (length < 0)
            {
                return false;
            }         
                for (int i = 0; i <= length; i++) //bir alma almaya alma dedi
                {
                    int j;
                    for (j = 0; j < search.Length; j++) //alma
                        if (sentence[i + j] != search[j])
                        {
                            break;
                        }
                    if (j == search.Length)
                    {
                        return true;
                    }      
                }
            return false;
        }
   
        
        
        public static string[] CustomSplit(this string sentence , char symbol)
        {
            string symbl = " ";
            string[] arr = new string[0];
            for (int i = 0; i <sentence.Length; i++)
            {
                if (sentence[i] == symbol)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = symbl;
                    symbl = string.Empty;
                }
                else
                {
                    symbl += sentence[i];
                }
            }
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = symbl;
                return arr;
        }
    }
            

   
}
