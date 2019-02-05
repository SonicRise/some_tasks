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


            /*char[] arr = new char[Convert.ToString(Int32.Parse(txt), 2).Length];
            arr = Convert.ToString(Int32.Parse(txt), 2).ToCharArray();
            arr[arr.Length - 3] = '1';*/

            //string a = String.Join("", arr);

            
            Console.WriteLine(Convert.ToString(Int32.Parse(txt), 2));


            //Console.WriteLine(thirdRightEq1(Int32.Parse(txt)));
            Console.ReadLine();
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

        /*
         * 1. Input - sequence of numbers.
         * 2. If number is divisible by 3, replace it with fizz
         * 3. if number is divisible by 5, replace it with buzz
         * 4. If both, then fizzbuzz
         * 5. Output to the console
         * IMPORTANT: division operation and modulo operation is prohibited
         */
        static void fizzbuzz(String s)
        {
            string[] numbers = s.Split(' ');

            bool fizz = false;
            bool buzz = false;
            bool exception = false;


            //for clean array
            int temp_count = 0;
            string[] temp = new string[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!string.IsNullOrEmpty(numbers[i]))
                {
                    temp[temp_count] = numbers[i];
                    temp_count++;
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
                try
                {
                    for (int x = 0; x < symbol.Length; x++)
                    {
                        end = end + Convert.ToInt32(symbol[x].ToString());
                    }

                    if (fizzbuzzNumber(end, 3) == end)
                    {
                        fizz = true;
                    }

                    if (symbol[symbol.Length - 1] == '0' || symbol[symbol.Length - 1] == '5')
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
                catch(FormatException e){
                    Console.WriteLine(e.Message);
                    exception = true;
                }
            }
            if (!exception)
            {
                Console.WriteLine(string.Join(" ", result));               
            }
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

        /// <summary>
        /// 1) Checks the number is divisible by 3
        /// </summary>
        /// <param name="number"> number from console </param>
        static void isDivisibleByThree(int number)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine("Yes");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// 2) Checks the number is divisible by 5 with remainder is 2
        /// and is divisible by 7 with remainder is 1
        /// </summary>
        /// <param name="number"> number from console </param>
        static void isDivisibleByFiveOrSeven(int number)
        {
            if (number % 5 == 2 && number % 7 == 1)
            {
                Console.WriteLine("Yes");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// 3) Checks the number is divisible by 4 and more than 10
        /// </summary>
        /// <param name="number"> Number from console </param>
        static void isDivisibleByFourAndMoreTen(int number)
        {
            if (number % 4 == 0 && number >= 10)
            {
                Console.WriteLine("Yes");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// 4) Checks the number is between 5 and 10
        /// </summary>
        /// <param name="number"> Number from console</param>
        static void isMoreFiveLessTen(int number)
        {
            if (number >= 5 && number <= 10)
            {
                Console.WriteLine("Yes");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// 5) Determines how many thousands in a number 
        /// </summary>
        /// <param name="number"> Number from console </param>
        /// <returns> The number of thousands in the number </returns>
        static int thousands(int number)
        {
            return number / 1000 % 10;
        }

        /// <summary>
        /// 7) Determines 3d rigth bit in binary code.
        /// </summary>
        /// <param name="number"> Decimal number from console </param>
        /// <returns> 0 or 1 </returns>
        static int thirdRight(int number)
        {
            return Int32.Parse(Convert.ToString(number >> 2, 2).Substring(Convert.ToString(number >> 2, 2).Length - 1));
        }

        static int thirdRightEq1(int number)
        {
            //char[] arr = new char[Convert.ToString(number, 2).Length];
            //arr = Convert.ToString(number, 2).ToCharArray();
            //arr[arr.Length - 3] = '1';

            //string a = String.Join("", arr);


            return 0;
            //return Convert.ToInt32(a, 2);
        }

    }
}
