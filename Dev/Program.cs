using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string txt = Console.ReadLine();

            //uniq_symbols(txt);
            
        }

        static void uniq_symbols(String s)
        {
            Console.Title = "Uniq_symbols";
            string result_txt = "";
            char[] arr = s.ToCharArray();
            char[] nalevo = new char[s.Length];
            char[] result = new char[s.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    if (nalevo.Contains(arr[i]))
                    {
                        result[i] = ')';
                    }
                    else
                    {
                        for (int j = i + 1; j < arr.Length; j++)
                        {
                            if (arr[i] == arr[j])
                            {
                                result[i] = ')';
                                nalevo[i] = arr[i];
                                break;
                            }
                            else
                            {
                                result[i] = '(';
                            }
                        }
                    }
                }
                else
                {
                    if (nalevo.Contains(arr[i]))
                    {
                        result[i] = ')';
                    }
                    else
                    {
                        result[i] = '(';
                    }
                }
            }

            result_txt = string.Join("", result);

            Console.WriteLine("Result: " + result_txt);
            Console.ReadLine();
        }

    }
}
