using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            Task8_6 obj = new Task8_6();
            Task8_6 obj2 = new Task8_6();

            obj.number = 5;
            obj2.number = 10;

            Console.WriteLine((obj && obj2).number);

            Console.WriteLine((obj2 && obj).number);





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
                catch (FormatException e)
                {
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
        /// 2.1) Checks the number is divided by 3 and 7
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
            catch
            {
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

            }
            catch
            {
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
            }
            catch
            {
                Console.WriteLine("Not a number");
            }
        }

        /// <summary>
        /// 2.9) Shows a sum of numbers which have a remainder 2 after dividing by 5 or have a reminder 1 after dividing by 3.
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
                    if (number % 5 == 2 || number % 3 == 1)
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

        /// <summary>
        /// 3.1) Creates a one-dimensional array with numbers which have a remainder 2 after dividing by 5
        /// </summary>
        /// <param name="init_size"> A size of the array </param>
        static void Arr_With_Remainder(string init_size)
        {
            int counter = 0;
            int index = 0;
            try
            {
                int[] numbers = new int[Int32.Parse(init_size)];

                while (index != numbers.Length)
                {
                    if (counter % 5 == 2)
                    {
                        numbers[index] = counter;
                        index++;
                    }
                    counter++;
                }

                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
            catch
            {
                Console.WriteLine("Not a number");
            }
        }

        /// <summary>
        /// 3.2) Creates a one-dimensional array with degrees of two.
        /// </summary>
        /// <param name="init_size"> A size of the array </param>
        static void Arr_With_Two_Degree(string init_size)
        {
            try
            {
                int[] numbers = new int[Int32.Parse(init_size)];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = (int)Math.Pow(2, i);
                }

                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
            catch
            {
                Console.WriteLine("Not a number");
            }
        }

        /// <summary>
        /// 3.3) Creates a one-dimensional char array with letters start from 97 ane then increase each letter on 2;
        /// </summary>
        /// <param name="init_size"> A size of the array </param>
        static void Arr_With_Chars(string init_size)
        {
            int letter_a = 97;
            try
            {
                char[] letters = new char[Int32.Parse(init_size)];

                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = (char)(letter_a + i * 2);
                }

                foreach (char letter in letters)
                {
                    Console.Write(letter + " ");
                }

                Console.WriteLine();

                for (int i = letters.Length - 1; i >= 0; i--)
                {
                    Console.Write(letters[i] + " ");
                }
            }
            catch
            {
                Console.WriteLine("Not a number");
            }
        }

        /// <summary>
        /// 3.4) Creates a one-dimensional char array with big consonant letter
        /// </summary>
        /// <param name="init_size"> A size of the array </param>
        static void Arr_With_Consonant(string init_size)
        {
            int letter_ascii = 66;
            try
            {
                char[] letters = new char[Int32.Parse(init_size)];

                for (int i = 0; i < letters.Length; i++)
                {
                    if (letter_ascii == 69 || letter_ascii == 73 ||
                        letter_ascii == 79 || letter_ascii == 85 ||
                        letter_ascii == 89)
                    {
                        letter_ascii++;
                    }

                    letters[i] = (char)(letter_ascii);
                    letter_ascii++;
                }

                foreach (char letter in letters)
                {
                    Console.Write(letter + " ");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 3.5) Creates a one-dimensional char array with random numbers.
        /// Then shows a minimum number and its index, or indexes if there are several minimums.
        /// </summary>
        /// <param name="init_size"> A size of the array </param>
        static void Arr_With_Rand(string init_size)
        {
            string index = "";
            int little;

            try
            {
                int[] numbers = new int[Int32.Parse(init_size)];

                Random rand = new Random();

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rand.Next(100);
                }

                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();

                little = numbers[0];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < little)
                    {
                        little = numbers[i];
                    }
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == little)
                    {
                        index += i.ToString() + " ";
                    }
                }

                Console.WriteLine("The little number is: {0}, index is: {1}", little, index);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 3.6) Creates a one-dimensional array with random number and then sorts desc.
        /// </summary>
        /// <param name="init_size"> A size of the array from console</param>
        static void Arr_Rand_Sort(string init_size)
        {
            try
            {
                int temp;
                int[] numbers = new int[Int32.Parse(init_size)];

                Random rand = new Random();

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = rand.Next(100);
                }

                for (int i = 1; i < numbers.Length; i++)
                {
                    for (int j = numbers.Length - 1; j != 0; j--)
                    {
                        if (numbers[j] > numbers[j - 1])
                        {
                            temp = numbers[j - 1];
                            numbers[j - 1] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }

                foreach (int number in numbers)
                {
                    Console.Write(number + " ");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 3.7) Creates a one-dimensional array with random chars and then reverses all array
        /// </summary>
        /// <param name="init_size"> A size of the array from console </param>
        static void Arr_Char_Reversed(string init_size)
        {
            try
            {
                char temp;
                char[] symbols = new char[Int32.Parse(init_size)];
                Random rand = new Random();

                for (int i = 0; i < symbols.Length; i++)
                {
                    symbols[i] = (char)(65 + rand.Next(25));
                }

                foreach (char symbol in symbols)
                {
                    Console.Write(symbol + " ");
                }

                for (int i = 0; i < symbols.Length / 2; i++)
                {
                    temp = symbols[i];
                    symbols[i] = symbols[symbols.Length - 1 - i];
                    symbols[symbols.Length - 1 - i] = temp;
                }
                Console.WriteLine();
                foreach (char symbol in symbols)
                {
                    Console.Write(symbol + " ");
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 3.8) Creates a two-dimensional array with random numbers and then changes all columns to rows. 
        /// </summary>
        /// <param name="init_rows"> Number of a rows </param>
        /// <param name="init_columns"> Number of a columns </param>
        static void Arr_Change_Columns_To_Rows(string init_rows, string init_columns)
        {
            try
            {
                int[,] numbers = new int[Int32.Parse(init_rows), Int32.Parse(init_columns)];
                Random rand = new Random();

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        numbers[i, j] = rand.Next(100);
                    }
                }

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int[,] result = new int[numbers.GetLength(1), numbers.GetLength(0)];
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = numbers[j, i];
                    }
                }

                Console.WriteLine();

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write(result[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 3.9) Creates a two-dimesional array and then deletes one random row and one random column.
        /// </summary>
        /// <param name="init_rows"> Number of rows </param>
        /// <param name="init_columns"> Number of columns </param>
        static void Arr_With_Deleted_Rows_Columns(string init_rows, string init_columns)
        {
            try
            {
                int[,] numbers = new int[Int32.Parse(init_rows), Int32.Parse(init_columns)];
                int[,] result = new int[numbers.GetLength(0) - 1, numbers.GetLength(1) - 1];
                Random rand = new Random();
                int a, b;

                int row = rand.Next(numbers.GetLength(0) - 1); //0
                int column = rand.Next(numbers.GetLength(1) - 1);//0

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        numbers[i, j] = rand.Next(100);
                    }
                }

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    if (i >= row) a = i + 1;
                    else a = i;
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        if (j >= column) b = j + 1;
                        else b = j;

                        result[i, j] = numbers[a, b];
                    }
                }

                Console.WriteLine();

                for (int i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        Console.Write(result[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 3.10) Creates a two-dimensional array and fills it by consequent numbers by spiral
        /// </summary>
        /// <param name="init_rows"> Number of rows </param>
        /// <param name="init_columns"> Number of columns </param>
        static void Arr_Spiral(string init_rows, string init_columns)
        {
            try
            {
                int[,] numbers = new int[Int32.Parse(init_rows), Int32.Parse(init_columns)];
                int filler = 1;
                int a = 0;
                int b = 0;
                int blockerR = numbers.GetLength(1) - 1;
                int blockerD = numbers.GetLength(0) - 1;
                int blockerL = 0;
                int blockerT = 0;

                bool right = true;
                bool down = true;

                for (int i = 0; i < numbers.GetLength(0) * numbers.GetLength(1); i++)
                {
                    if (right && down)
                    {
                        numbers[a, b] = filler;
                        b++;
                        filler++;
                        if (b == blockerR)
                        {
                            right = false;
                            blockerR--;
                        }
                    }
                    else if (down && !right)
                    {
                        numbers[a, b] = filler;
                        a++;
                        filler++;
                        if (a == blockerD)
                        {
                            down = false;
                            blockerD--;
                        }
                    }
                    else if (!right && !down)
                    {
                        numbers[a, b] = filler;
                        b--;
                        filler++;
                        if (b == blockerL)
                        {
                            right = true;
                            blockerL++;
                            //break;
                        }
                    }
                    else if (!down && right)
                    {
                        numbers[a, b] = filler;
                        a--;
                        filler++;
                        if (a == blockerT + 1)
                        {
                            down = true;
                            blockerT++;
                        }
                    }
                }


                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        Console.Write(numbers[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// 4.1) Calculates a double factorial of a number. Recursion is used.
        /// </summary>
        /// <param name="init_number"> Number from console </param>
        static void Double_Factorial(string init_number)
        {
            try
            {
                int number = Int32.Parse(init_number);
                Console.WriteLine(Fact_double_Rec(number));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            int Fact_double_Rec(int number)
            {
                if (number <= 1) return 1;
                return number * Fact_double_Rec(number - 2);
            }
        }

        /// <summary>
        /// 4.2) Shows a sum of squares of all number until entered number.
        /// </summary>
        /// <param name="init_quantity"> Quantity of numbers </param>
        static void Sum_Of_Squares(string init_quantity)
        {
            try
            {
                int quantity = Int32.Parse(init_quantity);
                Console.WriteLine(rec(quantity));
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            int rec(int quantity)
            {
                if (quantity == 1) return 1;
                return quantity * quantity * rec(quantity - 1);
            }
        }

        /// <summary>
        /// 4.3) If a second argument more than initial array length, creates a copy of the initial array
        /// if the secons argument less than initial array length, creates a new array with length of secons 
        /// argument and copies first numbers from initial array.
        /// </summary>
        /// <param name="init_arr"> Initial array </param>
        /// <param name="init_number"> Size of a new array </param>
        /// <returns></returns>
        static int[] Arr_Cuted_By_Number(int[] init_arr, int init_number)
        {
            int[] new_Arr;

            if (init_number > init_arr.Length)
            {
                new_Arr = new int[init_arr.Length];

                for (int i = 0; i < new_Arr.Length; i++)
                {
                    new_Arr[i] = init_arr[i];
                }
                return new_Arr;
            }
            else
            {
                new_Arr = new int [init_number];

                for (int i = 0; i < new_Arr.Length; i++)
                {
                    new_Arr[i] = init_arr[i];
                }
                return new_Arr;
            }
        }

        /// <summary>
        /// 4.4) Creates an int array form char array, converting chars into ASCII. 
        /// </summary>
        /// <param name="init_arr"> Initial char array </param>
        /// <returns></returns>
        static int[] Symbols_Arr_To_ASCII_Arr(char[] init_arr)
        {
            int[] arr = new int[init_arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)init_arr[i];
            }
            return arr;
        }

        /// <summary>
        /// 4.5) Calculates avg from array.
        /// </summary>
        /// <param name="init_arr"> Initial numberic array </param>
        /// <returns></returns>
        static int Avg_From_Arr(int[] init_arr)
        {
            int result = 0;
            for (int i = 0; i < init_arr.Length; i++)
            {
                result += init_arr[i];
            }
            return result/init_arr.Length;
        }

        /// <summary>
        /// 4.6) Finds max in a two-dimensional array and its indexes.
        /// </summary>
        /// <param name="init_arr"> Two-dimensional array </param>
        /// <param name="index1"> 1st index of the array </param>
        /// <param name="index2"> 2nd index of the array </param>
        /// <returns></returns>
        static int Max_2DArr_With_Indexes(int[,] init_arr, out int index1, out int index2)
        {
            index1 = 0;
            index2 = 0;

            for (int i = 0; i < init_arr.GetLength(0); i++)
            {
                for (int j = 0; j < init_arr.GetLength(1); j++)
                {
                    if (init_arr[i,j] > init_arr[index1, index2])
                    {
                        index1 = i;
                        index2 = j;
                    }
                }
            }  
            return init_arr[index1,index2];
        }

        /// <summary>
        /// 4.7) Reverses a char array
        /// </summary>
        /// <param name="init_arr"> Initial array </param>
        /// <returns></returns>
        static char[] Arr_Char_Reverse(char[] init_arr)
        {
            char temp;
            for (int i = 0; i < init_arr.Length / 2; i++)
            {
                temp = init_arr[init_arr.Length - 1 - i];
                init_arr[init_arr.Length - 1 - i] = init_arr[i];
                init_arr[i] = temp;
            }
            return init_arr;
        }

        /// <summary>
        /// 4.8) Contains overridden method
        /// </summary>
        static class ArrFillingBetweenPoints{
            /// <summary>
            /// Creates array with numbers from first argument till second.
            /// </summary>
            /// <param name="number1"> First element of the array </param>
            /// <param name="number2"> Last element of the array </param>
            /// <returns></returns>
            public static int[] FillingArr(int number1, int number2)
            {
                int[] arr = new int[number2-number1+1];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = number1;
                    number1++;
                }
                return arr;
            }
            /// <summary>
            /// Creates array with symbols from first argument till second.
            /// </summary>
            /// <param name="symbol1"> First element of the array </param>
            /// <param name="symbol2"> Last element of the array </param>
            /// <returns></returns>
            public static char[] FillingArr(char symbol1, char symbol2)
            {
                char[] arr = new char[symbol2-symbol1+1];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = symbol1;
                    symbol1++;
                }
                return arr;
            }
        }

        /// <summary>
        /// 4.9) Finds min and max in all arguments in method
        /// </summary>
        /// <param name="init_numbers"> random quantity of numbers </param>
        /// <returns> one-dimensional array with 2 numbers, min and max of all arguments </returns>
        static int[] Min_Max_In_Arguments(params int[] init_numbers)
        {
            int max = init_numbers[0];
            int min = init_numbers[0];

            int[] result = new int[2];

            for (int i = 0; i < init_numbers.Length; i++)
            {
                if (max < init_numbers[i])
                {
                    max = init_numbers[i];
                }

                if (min > init_numbers[i])
                {
                    min = init_numbers[i];
                }
            }
            result[0] = max;
            result[1] = min;
            return result;
        }

        /// <summary>
        /// 4.10) Adds symbols to the end of the initial text.
        /// </summary>
        /// <param name="init_text"> Initial text where symbols would be added </param>
        /// <param name="symbols"> Symbols which need to be added </param>
        /// <returns> String with added symbols </returns>
        static string func(string init_text, params char[] symbols)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                init_text += symbols[i];
            }
            return init_text;
        }

        /// <summary>
        /// Taks 5.1) Class with private symbol and 3 public methods.
        /// </summary>
        class Symbol
        {
            private char text;

            public void setSymblol(char text)
            {
                this.text = text;
            }

            public int getSymbolCode()
            {
                return (int)this.text;
            }

            public void showSymbol()
            {
                Console.WriteLine(this.text + " " + (int)text);
            }
        }

        /// <summary>
        /// 5.2) Class with 2 private symbol and 1 public method which shows all symbols between class's symbols.
        /// </summary>
        class Symbol2
        {
            private char symbol1;
            private char symbol2;

            public void SetSymbol1(char symbol)
            {
                this.symbol1 = symbol;
            }

            public void SetSymbol2(char symbol)
            {
                this.symbol2 = symbol;
            }

            public void ShowAllBetweenSymbols()
            {
                for (int i = (int)symbol1; i <= (int)symbol2; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }

        /// <summary>
        /// 5.3) Class with 3 constructors and 2 private numbers.
        /// </summary>
        class Number
        {
            private int number1;
            private int number2;

            public Number()
            {
                this.number1 = 0;
                this.number2 = 0;
            }

            public Number(int a)
            {
                this.number1 = a;
                this.number2 = 0;
            }

            public Number(int a, int b)
            {
                this.number1 = a;
                this.number2 = b;
            }
        }

        /// <summary>
        /// 5.4) Class with 2 constructors, one devides double to 2 parts. 
        /// Numbers until dot converted to a char, numbers after dot written to private int.
        /// </summary>
        class SplitedDouble
        {
            public int number;
            public char symbol;
            
            public SplitedDouble(double a)
            {
                string text = a.ToString();
                string[] s = text.Split(',');
                this.symbol = (char)Int32.Parse(s[0]);
                this.number = Int32.Parse(s[1]);
            }

            public SplitedDouble(int number, char symbol)
            {
                this.number = number;
                this.symbol = symbol;
            }
        }

        /// <summary>
        /// Class with setter getter and constructor
        /// </summary>
        class Task5_5
        {
            private int number;

            public Task5_5(int number)
            {
                SetNumber(number);
            }

            public void SetNumber(int number)
            {
                if (number > 100)
                {
                    this.number = 100;
                }
                else
                {
                    this.number = number;
                }
            }

            public void SetNumber()
            {
                this.number = 0;
            }

            public int GetNumber()
            {
                return this.number;
            }
        }

        class Task5_6
        {
            private int max = 0;
            private int min = 0;

            public Task5_6(int a, int b)
            {
                SetMinMax(a, b);
            }
            public Task5_6(int a)
            {
                SetMinMax(a);
            }

            public void SetMinMax(int a, int b)
            {
                if (a > this.max)
                {
                    this.max = a;
                }
                if (b > this.max)
                {
                    this.max = b;
                }
                if (a < this.max)
                {
                    this.min = a;
                }
                if (b < this.min)
                {
                    this.min = b;
                }
            }

            public void SetMinMax(int a)
            {
                if (a > this.max)
                {
                    this.max = a;
                }
                if (a < this.min)
                {
                    this.min = a;
                }
            }

            public void GetMinMax()
            {
                Console.WriteLine("Max: " + this.max + " Min: " + this.min);
            }
        }

        class Task5_7
        {
            private char symb;
            private string text;

            public void SetParams(char symb)
            {
                this.symb = symb;
            }

            public void SetParams(string text)
            {
                this.text = text;
            }

            public void SetParams(char[] symbs)
            {
                if (symbs.Length == 1)
                {
                    this.symb = symbs[0];
                }
                else
                {
                    this.text = string.Join("", symbs);
                }
            }

            public void show()
            {
                Console.WriteLine(this.symb + " " + this.text);
            }
        }

        class Task5_8
        {
            private static int number = 0;

            public static void Show()
            {
                Console.WriteLine(number++);
            }
        }

        class Task5_9
        {
            static public void Numbers(params int[] arr)
            {
                int min = arr[0];
                int max = arr[0];
                int avg = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }

                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }

                    avg += arr[i];
                }

                avg = avg / arr.Length;

                Console.WriteLine("Min: " + min + " Max: " + max + " Avg: " + avg);
            }
        }

        //ToString()
        class Task7_1
        {
            static public void Spaces(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i] + " ");
                }
                Console.WriteLine();
            }
        }

        class Task7_2
        { 
            public static string Revers(string text)
            {
                string result = String.Empty;
                string[] words = text.Split(' ');

                for (int i = words.Length-1; i >= 0; i--)
                {
                    result = result + words[i] + " ";
                }
                return result;
            }
        }

        class Task7_3
        {
            public static bool Equal(string text1, string text2)
            {
                bool eq = false;

                if (text1.Length == text2.Length)
                {
                    for (int i = 0; i < text1.Length; i++)
                    {
                        if ((int)text1[i] - (int)text2[i] <= 1 && (int)text1[i] - (int)text2[i] >= -1)
                        {
                            if (i == text1.Length - 1)
                            {
                                eq = true;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
                return eq;
            }
        }

        class Task7_4
        {
            public static bool Equal(string text1, string text2)
            {                
                string forCount1 = string.Empty;
                string forCount2 = string.Empty;

                for (int i = 0; i < text1.Length; i++)
                {
                    if (!forCount1.Contains(text1[i]))
                    {
                        forCount1 += text1[i];
                    }

                    if (!forCount2.Contains(text2[i]))
                    {
                        forCount2 += text2[i];
                    }
                }

                if (forCount1.Length == forCount2.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        class Task7_5
        {
            public static int[] Places (string text, char symb)
            {
                int arrLength = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == symb)
                    {
                        arrLength++;
                    }
                }

                if (arrLength == 0)
                {
                    int[] arr0 = new int[1];
                    arr0[0] = -1;
                    return arr0;
                }

                int[] arr = new int[arrLength];
                int index = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == symb)
                    {
                        arr[index] = i;
                        index++;
                    }
                }
                return arr;
            }
        }

        class Task7_6
        {
            public static List<char> AlphaOnly(string text)
            {
                Regex regex = new Regex("[^a-zA-Zа-яА-я]");
                string str = regex.Replace(text, "");

                List<char> chars = new List<char>();

                foreach (char symb in str)
                {
                    if (!chars.Contains(symb))
                    {
                        chars.Add(symb);
                    }
                }

                return chars;
            }
        }

        class Task7_7
        {
            public static string Substring(string text, int start, int length)
            {
                string result = string.Empty;

                for (int i = 0; i < length; i++)
                {
                    result += text[start];
                    start++;
                }
                return result;
            }
        }

        class Task7_8
        {
            private string text;

            public Task7_8(string text)
            {
                this.text = text;
            }

            public string Insert(string str, int index)
            {
                this.text = text.Substring(0, index+1)+str+text.Substring(index+1);
                return this.text;
            }

            public override string ToString()
            {
                return text;
            }
        }

        class Task7_9
        {
            private string text;
            private char symb;

            public Task7_9(string text, char symb)
            {
                this.text = text;
                this.symb = symb;
            }

            public string[] Split()
            {
                string[] arr = text.Split(symb);
                return arr;
            }

            public override string ToString()
            {
                string result = string.Empty;

                result = "Text: " + text + " Symb: " + symb + '\n';

                foreach (string str in text.Split(symb))
                {
                    result = result + "Подстрока: " + str + " ";
                }
                return result;
            }
        }

        class Task7_10
        {
            private int[] arr;

            public Task7_10()
            {
                Random rand = new Random();
                arr = new int[rand.Next(10)];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(10);
                }
            }

            public override string ToString()
            {
                string result = string.Empty;
                int sum = 0;

                foreach (int number in arr)
                {
                    sum += number;
                    result += number;
                }

                result = result + "\n" + "Count: " + arr.Length + " Avg: " + sum / arr.Length;

                return result;
            }
        }

        //Overload operators
        class Task8_1
        {
            public char symb;

            public Task8_1(char symb)
            {
                this.symb = symb;
            }

            public Task8_1()
            {

            }

            public static Task8_1 operator ++(Task8_1 obj)
            {
                obj.symb++;
                return obj;
            }

            public static Task8_1 operator --(Task8_1 obj)
            {
                obj.symb--;
                return obj;
            }

            public static Task8_1 operator +(Task8_1 obj, int number)
            {
                Task8_1 result_obj = new Task8_1();

                result_obj.symb = (char)(obj.symb + number);
                return result_obj;
            }

            public static Task8_1 operator +(int number, Task8_1 obj)
            {
                Task8_1 result_obj = new Task8_1();

                result_obj.symb = (char)(obj.symb + number);
                return result_obj;
            }

            public static int operator -(Task8_1 obj1, Task8_1 obj2)
            {
                return obj1.symb-obj2.symb;
            }
        }

        class Task8_2
        {
            public int[] arr;

            public Task8_2(int size)
            {
                arr = new int[size];
            }

            public static string operator ~(Task8_2 obj)
            {
                string result = string.Empty;

                foreach (int number in obj.arr)
                {
                    result += number;
                }
                return result;
            }

            public static Task8_2 operator ++(Task8_2 obj)
            {
                int[] arr = new int[obj.arr.Length+1];
                obj.arr = arr;
                return obj;
            }

            public static Task8_2 operator --(Task8_2 obj)
            {
                int[] arr = new int[obj.arr.Length-1];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = obj.arr[i];
                }
                obj.arr = arr;
                return obj;
            }

            public static Task8_2 operator +(Task8_2 obj1, Task8_2 obj2)
            {
                Task8_2 obj = new Task8_2(obj1.arr.Length + obj2.arr.Length);
                int index = 0;

                for (int i = 0; i < obj.arr.Length; i++)
                {
                    if (i >= obj1.arr.Length)
                    {
                        obj.arr[i] = obj2.arr[index];
                        index++;
                    }
                    else
                    {
                        obj.arr[i] = obj1.arr[i];
                    }
                }
                return obj;
            }
            public static Task8_2 operator +(Task8_2 obj, int number)
            {
                int[] arr = new int[obj.arr.Length + 1];

                for (int i = 0; i < obj.arr.Length; i++)
                {
                    arr[i] = obj.arr[i];
                }
                arr[arr.Length - 1] = number;
                obj.arr = arr;
                return obj;
            }
            public static Task8_2 operator +(int number, Task8_2 obj)
            {
                int[] arr = new int[obj.arr.Length + 1];
                arr[0] = number;
                for (int i = 0; i < obj.arr.Length; i++)
                {
                    arr[i+1] = obj.arr[i];
                }
                obj.arr = arr;
          
                return obj;
            }
        }

        class Task8_3
        {
            public int number1;
            public int number2;

            public Task8_3(int number1, int number2)
            {
                this.number1 = number1;
                this.number2 = number2;
            }

            public static bool operator >(Task8_3 obj1, Task8_3 obj2)
            {
                if (Math.Pow(obj1.number1, 2) + Math.Pow(obj1.number2, 2) >
                    Math.Pow(obj2.number1, 2) + Math.Pow(obj2.number2, 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator <(Task8_3 obj1, Task8_3 obj2)
            {
                if (Math.Pow(obj1.number1, 2) + Math.Pow(obj1.number2, 2) <
                    Math.Pow(obj2.number1, 2) + Math.Pow(obj2.number2, 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        class Task8_4
        {
            public int number;
            public string text;

            public Task8_4(int number, string text)
            {
                this.number = number;
                this.text = text;
            }

            public static bool operator >(Task8_4 obj1, Task8_4 obj2)
            {
                return obj1.text.Length > obj2.text.Length;
            }

            public static bool operator <(Task8_4 obj1, Task8_4 obj2)
            {
                return obj1.text.Length < obj2.text.Length;
            }

            public static bool operator >=(Task8_4 obj1, Task8_4 obj2)
            {
                return obj1.number >= obj2.number;
            }

            public static bool operator <=(Task8_4 obj1, Task8_4 obj2)
            {
                return obj1.number <= obj2.number;
            }

            public static bool operator ==(Task8_4 obj1, Task8_4 obj2)
            {
                if (obj1.number == obj2.number && obj1.text == obj2.text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator !=(Task8_4 obj1, Task8_4 obj2)
            {
                if (obj1.number != obj2.number || obj1.text != obj2.text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public override bool Equals(object obj)
            {
                Task8_4 myObj = (Task8_4)obj;
                if (myObj.number == this.number) return true;
                else return false;
            }

            public override int GetHashCode()
            {
                return number*5;
            }
        }

        class Task8_5
        {
            public int number;
            public char symb;

            public Task8_5(int number, char symb)
            {
                this.number = number;
                this.symb = symb;
            }

            public static bool operator true(Task8_5 obj)
            {
                if (Math.Abs(obj.number - obj.symb) <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static bool operator false(Task8_5 obj)
            {
                if (Math.Abs(obj.number - obj.symb) > 10)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        class Task8_6
        {
            public int number;

            public static Task8_6 operator &(Task8_6 obj1, Task8_6 obj2)
            {
                if (obj1) return obj2;
                else return obj1;
            }
            public static Task8_6 operator |(Task8_6 obj1, Task8_6 obj2)
            {
                if (obj1) return obj1;
                else return obj2;
            }
            public static bool operator true(Task8_6 obj)
            {
                if (obj.number == 2 || obj.number == 3 ||
                    obj.number == 5 || obj.number == 7)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public static bool operator false(Task8_6 obj)
            {
                if (obj.number < 1 || obj.number > 10)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        class Task8_7
        {
            private string text;

            public Task8_7(string text)
            {
                this.text = text;
            }
            
            public static explicit operator Task8_7(int num)
            {
                string temp = string.Empty;
                for (int i = 0; i < num; i++)
                {
                    temp += 'A';
                }

                return new Task8_7(temp);
            }

            public static implicit operator int(Task8_7 obj)
            {
                return obj.text.Length;
            }

            public static explicit operator char(Task8_7 obj)
            {
                return obj.text[0];
            }

        }
    }
}
