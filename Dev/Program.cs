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
            //string txt2 = Console.ReadLine();

            Sum_Of_Numbers_With_Remainder(txt1);
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
                catch (FormatException e) {
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
            catch {
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

            } catch {
                return "Not a number";
            }
        }

        /// <summary>
        /// 2.3) Sums all numbers which are entered consistently from console
        /// </summary>
        static void sum_Numbers()
        {
            int sum = 0;
            int number;

            while (true)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    number = Int32.Parse(Console.ReadLine());
                    sum += number;

                    if (number == 0)
                    {
                        Console.WriteLine("Summ is: " + sum);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Not a number");
                }
            }
        }

        /// <summary>
        /// 2.4) Shows a day of the week by a number which is enter from console 
        /// </summary>
        /// <param name="init_number"> Number from console </param>
        /// <returns> Rigth day of the week </returns>
        static string Day_Of_The_Week(string init_number)
        {
            int number;
            try
            {
                number = Int32.Parse(init_number);
                if (number <= 7 && number > 0)
                {
                    switch (number)
                    {
                        case 1:
                            return "Monday";
                        case 2:
                            return "Tuesday";
                        case 3:
                            return "Wednesday";
                        case 4:
                            return "Thursday";
                        case 5:
                            return "Friday";
                        case 6:
                            return "Saturday";
                        case 7:
                            return "Sunday";
                        default:
                            return "";
                    }
                }
                else
                {
                    return "Incorrect number";
                }
            }
            catch
            {
                return "Not a number";
            }
        }

        /// <summary>
        /// 2.5) Shows a number of a day in the week
        /// </summary>
        /// <param name="day"> Day of the week </param>
        /// <returns> A number of the day </returns>
        static string Number_Of_A_Day(string day)
        {
            switch (day)
            {
                case "Monday":
                    return "1";
                case "Thuesday":
                    return "2";
                case "Wednesday":
                    return "3";
                case "Thursday":
                    return "4";
                case "Friday":
                    return "5";
                case "Saturday":
                    return "6";
                case "Sunday":
                    return "7";
                default:
                    return "Does not exist";
            }
        }


        /// <summary>
        /// 2.6) Shows a sum of even numbers. Quantity of numbers are entered from console.
        /// </summary>
        /// <param name="init_number"> Quantity of numbers </param>
        static void Sum_Of_Even(int init_number)
        {
            Console.WriteLine("2 + 4 + 6 + ... + " + 2 * init_number + " = {0}", init_number * (init_number + 1));
        }

        /// <summary>
        /// 2.7) Shows a sum of squares of numbers. 
        /// </summary>
        /// <param name="init_number"> Quantity of numbers </param>
        static void Sum_Of_Squares(int init_number)
        {
            Console.WriteLine("1^2 + 2^2 + 3^2 + ... + " + Math.Pow(init_number, 2) + " = {0}", (init_number * (init_number + 1) * (2 * init_number + 1)) / 6);
        }

        /// <summary>
        /// 2.8) Shows a sequence of Fibonachi
        /// </summary>
        /// <param name="init_number"> Quantity of numbers in a sequence </param>
        static void Fibo(int init_number)
        {
            int number1 = 0;
            int number2 = 1;
            int temp = 0;

            for (int i = 0; i < init_number; i++)
            {
                Console.Write(number2 + " ");
                temp = number2;
                number2 = number1 + number2;
                number1 = temp;
            }
        }

        /// <summary>
        /// 2.9) Shows all numbers between two entered numbers from console.
        /// </summary>
        /// <param name="init_number1"> Number 1 from console </param>
        /// <param name="init_number2"> Number 2 from console </param>
        static void Numbers_Between_Numbers(string init_number1, string init_number2)
        {
            int number1;
            int number2;
            int difference;

            try
            {
                number1 = Int32.Parse(init_number1);
                number2 = Int32.Parse(init_number2);

                if (number1 > number2)
                {
                    difference = number1 - number2;
                    for (int i = 0; i <= difference; i++)
                    {
                        Console.Write(number2 + i + " ");
                    }
                }
                else
                {
                    difference = number2 - number1;
                    for (int i = 0; i <= difference; i++)
                    {
                        Console.Write(number1 + i + " ");
                    }
                }
            }catch{
                Console.WriteLine("Not a number");
            }
        }

        /// <summary>
        /// 2.9) Shows a sum of numbers which have a remainder 2 after deviding by 5 or have a reminder 1 after deviding by 3.
        /// Quantity of the numbers are entered from console.
        /// </summary>
        /// <param name="init_quantity"> quantity of numbers from console </param>
        static void Sum_Of_Numbers_With_Remainder(string init_quantity)
        {
            int quantity_start = 0;
            int quantity_end;
            int number = 0;
            int sum = 0;

            try
            {
                quantity_end = Int32.Parse(init_quantity);

                while (quantity_start != quantity_end)
                {
                    if (number%5==2||number%3==1)
                    {
                        if (quantity_end - quantity_start == 1)
                        {
                            Console.Write(number + ": ");
                        }
                        else
                        {
                            Console.Write(number + " + ");
                        }
                        sum += number;
                        quantity_start++;
                    }
                    number++;
                }
                Console.WriteLine(sum);
            }
            catch
            {
                Console.WriteLine("Not a number");
            }
        }
    }
}
