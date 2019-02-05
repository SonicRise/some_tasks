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
            string txt1 = Console.ReadLine();
            string txt2 = Console.ReadLine();

            Console.WriteLine(numbers_Comparision(txt1, txt2));
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

        /// <summary>
        /// 8) Replaces a third bit in binary code of a decimal number to '1'
        /// </summary>
        /// <param name="number"> Number from console </param>
        /// <returns> A new decimal number with replaced third bit </returns>
        static int thirdRightEq1(string number)
        {
            //converted decimal to binary code
            string a = (Convert.ToString(Int32.Parse(number), 2)).PadLeft(8, '0');

            //3d right bit is changed to '1'
            char[] arr = a.ToCharArray();
            arr[a.Length - 3] = '1';

            return Convert.ToInt32(string.Join("", arr), 2); 
        }

        /// <summary>
        /// 9) Replaces a fourth bit in binary code of a decimal number to '0'
        /// </summary>
        /// <param name="number"> Number from console </param>
        /// <returns> A new decimal number with replaced fourth bit </returns>
        static int fourthEq0(string number)
        {
            //converted decimal to binary code
            string a = (Convert.ToString(Int32.Parse(number), 2)).PadLeft(8, '0');

            //4th bit changed to '0'
            char[] arr = a.ToCharArray();
            arr[3] = '0';

            return Convert.ToInt32(string.Join("", arr), 2);
        }

        /// <summary>
        /// Reverces 2nd bit in a binary code of a decimal number
        /// </summary>
        /// <param name="number"> Numver from console </param>
        /// <returns> New decimal number with reverced 2nd bit </returns>
        static int secondBitReverse(string number)
        {
            //converted decimal to binary code
            string a = (Convert.ToString(Int32.Parse(number), 2)).PadLeft(8, '0');

            //2nd bit reversed
            char[] arr = a.ToCharArray();
            if (arr[1] == '1')
            {
                arr[1] = '0';
            }
            else
            {
                arr[1] = '1';
            }

            return Convert.ToInt32(string.Join("", arr), 2);
        }

        /// <summary>
        /// 2.1) Checks the number is devided by 3 and 7
        /// </summary>
        /// <param name="number"> Number from console </param>
        /// <returns> The answer yes or no </returns>
        static string is_Devided_By_7_Or_3(string number)
        {
            try
            {
                int a = Int32.Parse(number);

                if (a % 3 == 0 && a % 7 == 0)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            catch{
                return "Not a number";
            } 
        }

        /// <summary>
        /// 2.2) Compares two numbers and shows which is bigger or they are equal
        /// </summary>
        /// <param name="init_number1"> Number from console </param>
        /// <param name="init_number2"> Number from console </param>
        /// <returns> the bigger number </returns>
        static string numbers_Comparision(string init_number1, string init_number2)
        {
            try
            {
                int number1 = Int32.Parse(init_number1);
                int number2 = Int32.Parse(init_number2);

                if (number1 > number2)
                {
                    return number1 + " is bigger";
                }
                else if (number2 > number1)
                {
                    return number2 + " is bigger";
                }
                else
                {
                    return number1 + " = " + number2;
                }

            }catch{
                return "Not a number";
            }
        }
    }
}
