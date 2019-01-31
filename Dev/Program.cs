using System;
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
            fizzbuzz(txt);

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

        static void fizzbuzz(String s)
        {
            string[] numbers = s.Split(' ');

            bool fizz = false;
            bool buzz = false;


            //for clean array
            int temp_count = 0;
            string[] temp = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    if (!string.IsNullOrEmpty(numbers[i]))
                    {
                        temp[temp_count] = numbers[i];
                        temp_count++;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            string[] modified_arr = new string[temp_count];
            string[] result = new string[modified_arr.Length];

            //new clean array without spaces and empty strings
            for (int a = 0; a < modified_arr.Length; a++)
            {
                modified_arr[a] = temp[a];
            }

            char[] symbol;

            for (int b = 0; b < modified_arr.Length; b++)
            {
                symbol = modified_arr[b].ToCharArray();
                int end = 0;

                //processing of negative numbers
                if (symbol[0] == '-')
                {
                    symbol[0] = '0';
                }

                //sum of all digits in number 
                for (int x = 0; x < symbol.Length; x++)
                {
                    end = end + Convert.ToInt32(symbol[x].ToString()); 
                }

                if (fizzbuzzNumber(end, 3) == end)
                {
                    fizz = true;
                }

                if (symbol[symbol.Length-1] == '0' || symbol[symbol.Length - 1] == '5')
                {
                    buzz = true;
                }

                //check on 0
                if (end == 0)
                {
                    fizz = false;
                    buzz = false;
                }

                if (fizz && buzz)
                {
                    result[b] = "fizzbuzz";
                }
                else if (fizz)
                {
                    result[b] = "fizz";
                }
                else if (buzz)
                {
                    result[b] = "buzz";
                }
                else
                {
                    result[b] = modified_arr[b];
                }

                fizz = false;
                buzz = false;
            }
            Console.WriteLine(string.Join(" ",result));
            Console.ReadLine();
        }

        /**
         * Multiplies each number on 3, until gets the same or bigger number.
         */
        static int fizzbuzzNumber(int number, int multiplier)
        {
            int temp = 0;
            int counter = 0;
            while (temp < number)
            {
                temp = counter * multiplier;
                counter++;
            }
            return temp;
        }
    }
}
