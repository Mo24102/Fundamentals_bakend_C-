
using Fundamentals_bakend.NewFolder;
using Fundamentals_bakend.MathExpressionEvaluator;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Collections;
using System.Runtime;
using Rectangle = Fundamentals_bakend.NewFolder.Rectangle;
using Fundamentals_bakend.Interfaces;
using Fundamentals_bakend;
using Fundamentals_bakend.PasswordManager;
using Fundamentals_bakend.OOP_HrSystem.Encapsulation;
using Fundamentals_bakend.OOP_HrSystem.Inheritance;
using Fundamentals_bakend.OOP_HrSystem.Polymorphism;
using Fundamentals_bakend.OOP_HrSystem._ِAbstraction;


namespace HelloWorld_bakend

{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Lesson 5 Variables
            /*
            String firstName = "mohamed";
            firstName = " Hello,world";

            Console.WriteLine(firstName);
            Console.WriteLine(firstName);
            Console.WriteLine(firstName);
            Console.WriteLine(firstName);
            Console.WriteLine(firstName);
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 6 Boolean Data Type
            /*
            bool isAliv = false;
            Console.WriteLine("IsAliv = " + isAliv);
            isAliv = true;
            Console.Write("IsAliv = " + isAliv);
            */
            /*
            bool boolen1 = true, boolen2 = false;
            bool result1 = boolen1 & boolen2;
            bool result2 = boolen1 || boolen2;
            bool result3 = !boolen1;
            bool result4 = boolen1 ^ boolen2;

            Console.WriteLine("Result " + result1);
            Console.WriteLine("Result " + result2);
            Console.WriteLine("Result " + result3);
            Console.WriteLine("Result " + result4);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 7 Char Data Type
            /*
             Console.WriteLine("Write any character then press ENTER: ");
             // 1 => 49    A => 65 a=>97
             // ASCII =>  American standard code information interchange

            int c1 =  Console.Read();
            int c2 =  Console.Read();
            int c3 =  Console.Read();
            int c4 =  Console.Read();
            int c5 =  Console.Read();
             Console.WriteLine(c1);
             Console.WriteLine(c2);
             Console.WriteLine(c3);
             Console.WriteLine(c4);
             Console.WriteLine(c5);
             */
            /*
            char c = 'A';
            Console.WriteLine(c);
            Console.WriteLine((int)c);
            */
            /*
            bool isDigit = Char.IsLetter('g');
            Console.WriteLine(isDigit);
            isDigit = char.IsLetter('1');
            Console.WriteLine(isDigit);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 8 String data type(part1)
            /*
            Console.WriteLine("I'm is\n mohamed");
            Console.WriteLine("I'm is\t mohamed");
            Console.WriteLine("I'm is\\t mohamed "+"and age 21");
            Console.Write(@"I'm is\\t 
             mohamed "+@"and\n
               age 21");

            String name = "mohamed";
            Console.Write($"I'm {name} \nWelcome ti our C# course");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 9 String data type(part2)
            /*
            String name = "";
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine(name.Replace("Ali","Asran",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.IndexOf("m"));
            Console.WriteLine(name.LastIndexOf("m"));
            Console.WriteLine(name.Contains("Ham", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.Contains("o"));
            Console.WriteLine(name.EndsWith("ED", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.EndsWith("d"));
            Console.WriteLine(name.StartsWith("MOH",StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(name.StartsWith("m")); 
            Console.WriteLine($"Welcome {name}");
            Console.WriteLine($"Lenghe name = {name.Length}");
            Console.WriteLine($"Upper  case = {name.ToUpper()}");
            Console.WriteLine($"lower case = {name.ToLower()}");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 10 numeric data type
            // int 4 bit , chart 2 bit , long 8 bit
            // Memory siz , min value , max value
            /*
            float f = 3.5244658904676f;
            double d = 10.235679835790345673;
            Console.WriteLine($"Float: {f}");
            Console.WriteLine($"Double: {d}");
            */
            /*
            Console.WriteLine($"Int memory Size: {sizeof(int)}");
            Console.WriteLine($"Uint memory Size: {sizeof(uint)}");
            Console.WriteLine("-----------------"); 
            Console.WriteLine($"Int min Size: {int.MinValue}");
            Console.WriteLine($"Uint min Size: {uint.MinValue}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Int max Size: {int.MaxValue}");
            Console.WriteLine($"Uint max Size: {uint.MaxValue}");
            */
            /*
            int int1 = 20;
            int int2 = 48;
            int int4 = -60;

            // u => unsigned
            uint uint1 = 30;
            uint uint2 = 90;
            uint uint3 = -20; // Not allowen
          */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 11 - Aricthmetic operations
            /*
            1- Addition (+)
            2- Subtraction (-)
            3- Multiplication (*)
            4- IDivision (/)
            5- Modules (%) 
            */
            /*
            float x = 25;
            int y = 10;

            //var z = x / y;

            Console.WriteLine($"{x}+{y} = {x + y}");
            Console.WriteLine($"{x}-{y} = {x - y}");
            Console.WriteLine($"{x}*{y} = {x * y}");
            Console.WriteLine($"{x}/{y} = {x / y}");
            Console.WriteLine($"{x}%{y} = {x % y}");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 12 operator precedence
            /*
            int x = 4;
            int y = 9;
            int z = 2;

            Console.WriteLine($"x + y * z = {x + y * z}");
            Console.WriteLine($"x * (y - z) = {x * (y - z)}");
            Console.WriteLine($"x + y % z = {x + y % z}");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 13 assignment operators
            /*
            int x = 5;
            int y = 14;
            int z = 16;

            x += 5; // => x = x + 5;
            y -= 6; // => y = y - 6;
            z %= 3; // => z = z % 6;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 14 inc/dec operators
            /*
            int x = 3;
            int y = 6;

            Console.WriteLine(x * ++x);
            Console.WriteLine(x * x--);
            Console.WriteLine("----------------------------");
            Console.WriteLine(++x);
            Console.WriteLine(x);
            Console.WriteLine("----------------------------");
            Console.WriteLine(y--);
            Console.WriteLine(y);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lessone 15 comparison operators ( == , != , >= , <= , > , < )
            /*
            int x = 3;

            Console.WriteLine($"x == 4 = {x == 4}");
            Console.WriteLine($"x != 4 = {x != 4}");
            Console.WriteLine($"x >= 4 = {x >= 4}");
            Console.WriteLine($"x <= 4 = {x <= 4}");
            Console.WriteLine($"x > 4 = {x > 4}");
            Console.WriteLine($"x < 4 = {x < 4}");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 16 prase String 
            /*
            Console.WriteLine("Enter Your birth year: ");
            String year = Console.ReadLine();
            int inYear = int.Parse(year);
            Console.WriteLine($"Your age until 2024 = {2024-inYear}");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 17 Control Flow / if Statment
            /*
            while (true)
            {
                Console.Write("Enter Your a Number: ");
                String number = Console.ReadLine();
                int num = int.Parse(number);
                int remainder = num % 2;

                if (remainder == 1)
                {
                    Console.WriteLine($"{remainder} is a odd");
                }
                else if (num == 0)
                {
                    Console.WriteLine(" Zero is neither odd nor even");
                }
                else
                {
                    Console.WriteLine($"{remainder} is a even");
                }
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Lesson 18 Debugger basice
            // Lesson 19 Arrays
            /*
            int[] videos1 = {1,2,3,4,5,6 };
            int[] videos2 = new int[9];
            Array.Copy(videos1, videos2, videos1.Length);
            Console.WriteLine(videos2[2]);
            // Console.WriteLine(videos1[2]);
            //Array.Sort(videos1);
            //Console.WriteLine(videos1[2]);
              */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-20 for loop
            /*
            int[] number = { 2, 3, 5, 7, 8, 2, 3, };

            for(int i=0; i < number.Length; i+=2)
            {
                Console.WriteLine(number[i]);
            }

            //int x = 100;
            //for (int i = 0; i < x; i += 6)
            //{
            //    Console.WriteLine(i);
            //}
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-21 Ternary operator
            /*
            //int x = 55;

            //for(int i = 0; i < x; i++)
            //{
            //    // String Statement= i % 2 == 1 ? $"Number is odd = {i}" : $"Number is even = {i}"; 
            //    // Console.WriteLine(Statement);

            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine($"Number is odd = {i}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Number is even = {i}");
            //    } 
            //}
            //while (true)
            //{
            //Console.Write("Please inter number: ");
            //int input = int.Parse(Console.ReadLine());
            //int num = input % 2;

            //var statement = num == 1 ? $"{input} Number is odd" : input == 0 ? $"{input} Zero is neither odd nor even": $"{input} Number is even";
            //    Console.WriteLine(statement);
            //    Console.WriteLine("----------------------------------------------------");
            //}
            //if (g % 2 == 1)
            //{
            //    Console.WriteLine("Number is odd");
            //} else
            //    Console.WriteLine("Number is even");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-22 Foreach loop
            /*
            char[] number = { '0', 'A', '2', '3', '4', '5', 'g', 'a', '8', };
            foreach(char digt in number)
                Console.WriteLine($"{digt} = {(int)digt}");
            /*
            
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"{number[i]} = {(int)number[i]}");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-23 For && Foreatch loop
            /*
            Console.Write("Enter array number of item: ");
            int arraySiz = int.Parse(Console.ReadLine());
            int[] number = new int[arraySiz];
            for (int i = 0; i < arraySiz; i++)
            {
                Console.Write($"Enter item number{i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());
            }

            int[] rvesarray = new int[arraySiz];
            for (int i = arraySiz - 1; i >= 0; i--)

                rvesarray[arraySiz - i - 1] = number[i];

            foreach (int digat in number)
                Console.WriteLine(digat);

            Console.WriteLine("-----------------------");
            foreach (int digat in rvesarray)
                Console.WriteLine(digat);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-24 Do , While loop
            /*
            int x = 5;

            do
            {
                Console.WriteLine(x++);

            } while (x <= 10);

            while (x <= 10) 
            {
                Console.WriteLine(x++);

            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-25  switch 
            /*
            while (true)
            {
                Console.Write("Please enter a string: ");
                string input= Console.ReadLine();

                Console.WriteLine("Please select an option: ");
                Console.WriteLine("1. convert to capital");
                Console.WriteLine("2. convert to lower");
                Console.WriteLine("3. print string lenghth");

                string selectedOption = Console.ReadLine();


                switch (selectedOption)
                {
                    case "1":
                        Console.WriteLine(input.ToUpper());
                        break;
                    case "2":
                        Console.WriteLine(input.ToLower());
                        break;
                    case "3":
                        Console.WriteLine(input.Length);
                        break;
                    default: 
                        Console.WriteLine("Invalid option !");
                        break;
                }
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Q-26  Methods-Part 1
             - what is methed
             - when to use it
             - Syntax value from method
             - return value from method
             - Option arguments
            */
            /*
            static void CaleulateAverge(int[] numbers)
            {
                int sum = 0;
                foreach (int number in numbers)

                    sum += number;
                double average = sum / numbers.Length;
                Console.WriteLine($"Averge  = {average}");
            }

            int[] numbers = { 1, 2, 3, 4, 5 };
            CaleulateAverge(numbers);

            numbers=new int[] { 10, 20, 30,40, 50 };
            CaleulateAverge(numbers);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q-27 Methods-Part 2
            /*
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CaleulateAverge(numbers,printSumToconsole:true);

            numbers = new int[] { 10, 20, 30, 40, 50, 60 };
            CaleulateAverge(numbers,true);

            static double CaleulateAverge(int [] numbers,bool printAvergToconsole = false ,bool printSumToconsole = false )
            {
                int sum = 0;
                foreach (int number in numbers)
                    sum+=number;
                double averge=sum/numbers.Length;
                if (printSumToconsole)
                    Console.WriteLine("Sum = "+sum);
                if (printAvergToconsole == true ) 
                Console.WriteLine($"Averge = {averge}");
                return averge;
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-28 Comments
            /*
             - what is Comments
             - Single Line comment
             - Multiline comment
             - Todo comment
             - XML docunentation comment
            */
            /*
            // todo: Convert array from int[] ti long[]
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            CaleulateAverge(numbers, printSumToconsole: true);

            // todo: Replace with a new array of doubles
            numbers = new int[] { 10, 20, 30, 40, 50, 60 };
            CaleulateAverge(numbers, true);
             
            static double CaleulateAverge(int[] numbers, bool printAvergToconsole = false, bool printSumToconsole = false)
            {
                int sum = 0;
                foreach (int number in numbers)
                    sum += number;
                double averge = sum / numbers.Length;
                if (printSumToconsole)
                    Console.WriteLine("Sum = " + sum);
                if (printAvergToconsole == true)
                    Console.WriteLine($"Averge = {averge}");
                return averge;
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-29 Training: Array Findings
            /*
            Console.Write("Please enter of the number of items: ");
            int input= int.Parse(Console.ReadLine());
            int[] numbers= new int[input];
            for (int i = 0; i < input; i++) 
            { 
                Console.Write($"Enter item number {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0, smallestNumber = int.MaxValue, greatestNumber = 0;
            foreach (int itme in numbers)
            {
                sum += itme;
                if (itme < smallestNumber) 
                    smallestNumber = itme;
                if (itme > greatestNumber)
                    greatestNumber = itme;
            }
            double avergNumber = sum / numbers.Length;

            Console.WriteLine($"Smalest Number is: {smallestNumber}");
            Console.WriteLine($"greatest Number is: {greatestNumber}");
            Console.WriteLine($"Avrege Number is: {avergNumber}");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-30 Training: Palindrome Words
            /*
            while (true)
            {
                Console.Write("Please enter a word to checck: ");
                String word= Console.ReadLine();

                bool palindrome = true;
                for(int i = 0; i < word.Length/ 2; i++)
                {
                    if (word[i] != word[word.Length -i - 1]) //this is corecct: if (word[i] != word[word.Length - 1])
                    {
                        palindrome = false;
                        break;
                    }
                }
                Console.WriteLine($"Is palindrom: {palindrome}");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-31 Value Types & Reference Types
            /*
             - what's value type
             - what's Reverence type
            */
            /*
             int x = 5;
             int y = x;
             x = 10;
             Console.WriteLine(x);
             Console.WriteLine(y);
             Console.WriteLine("--------------");
             int[] num1 = { 1, 2, 3, 4, 5 };
             int[] num2 = num1;
             num1[0] = 10;
             Console.WriteLine($"Number1[0] = {num1[0]}");
             Console.WriteLine($"Number2[0] = {num2[0]}");
             */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-32 Type Casting
            /*
              - Implicit casting
              - Explicit casting
            */
            /*
            // Implicit casting
            int x = 3;
            float y = x;
            double z = y;

            // Explicit casting
            double b = 5.6567;
            int d = (int)b;
            float f = (float)b;
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //Q-33 String Formatting
            /* 
             - Basic formating // String str = "Hello {0}, My Name is {1},Salary = {2}";
             - Control spacing // My Name is {1,16}
             - format Argmument {0.00,N2,c2} // String str = "Hello {0}, My Name is {1,8},Salary = {2:C2}";
            */
            /*
            String str = "Hello {0}, My Name is {1,6},Salary = {2:C2}";
            Console.WriteLine(str);
            str = String.Format(str, "mohamed", "Ali",10000);
            Console.WriteLine(str);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-34 String Split & Join
            /*
              // String Split
           Console.Write("Please enter list of number separted by comma: ");
           String input=Console.ReadLine();
           String[] numbers = input.Split(","); // or String[] numbers = input.Split("+") or String[] numbers = input.Split("-")
           int sum = 0;
           foreach (String i in numbers) 
               sum += int.Parse(i);
               Console.WriteLine("Averge = "+(float)sum/numbers.Length);
           */
            /*
             // String join
            
           //String[] words = { "mohamed", "Asran", "Ali", "Abd Arahman" };
           //String Statement = String.Join(" ", words);
           //Console.WriteLine(Statement);
           */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-35 StringBuilder
            /*
            String str = "Hello"; // use {String} small conctinetion
            str = "World";
            str += "Mohamed";
            */
            
              // use {StringBuilder} more conctinetion
            StringBuilder sb = new StringBuilder(); //or  StringBuilder sb = new(4234);
            sb.Append("Hello ");
            sb.Append("World ");
            sb.Append("mohamed");
            Console.WriteLine("Lenghth = " + sb.Length);
            Console.WriteLine($"Capacity = {sb.Capacity}");
            Console.WriteLine($"MaxCapacity = {sb.MaxCapacity}");
            Console.WriteLine(sb);
            
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-36 Compilation process
            /*
              Spurce code -> Intermediate language(Il)or(MSIL)or(CIL) -> Common Language Runtime(CLR) and (JIT) -> Machine code 
             */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-37 Classes & Objects
            /*
            Student[] students = new Student[3];
            Student Asran = new Student();
            Console.Write("Enter Student Name: ");
            Asran.Name = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            Asran.PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Adress: ");
            Asran.Adress = Console.ReadLine();

            Student Ali = new Student();
            Console.Write("Enter Student Name: ");
            Ali.Name = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            Ali.PhoneNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Adress: ");
            Ali.Adress = Console.ReadLine();
            students[0] = Asran;
            students[2] = Ali;

            Console.WriteLine($"Student Name: {Asran.Name}\n Phone Number: {Asran.PhoneNumber}\n Adress: {Asran.Adress} ");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Student Name: {Ali.Name}\n Phone Number: {Ali.PhoneNumber}\n Adress: {Ali.Adress} ");
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-38 Constructor
            /*
              - What's Constructor(cter)
              - This Keyword
             */
            /*
            Student Asran = new Student("Ali");
            Console.WriteLine(Asran.Name);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-39 Properties
            /*
            Student students = new Student("Mohamed");

           // students.Name="Alii";// Set
            Console.WriteLine(students.Name); // get 
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-40 Namespaces
            /*
            EMP student= new EMP();
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q- 41 Access Modifiers
            /*
             - public
             - internal
             - private
             */
            // var Employee = new Employee();
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-42 Constants & Read-only Variabls // الباقي تحت خاالص
            /*
            var str = Message;
            String str2 = _message;

            Message = "mohamed";
            _message = "Asran";
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-43 stitac // look to Name Cless MyStaticClass 
            /*
            MyStaticClass.DoSomething();
            MyStaticClass.DoSomething();
            MyStaticClass.DoSomething();
            MyStaticClass.DoSomething();
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-44  Variable Scopes // الباقي تحت خاالص
            /*
              - Cless-level Scope
              - Method-level Scope
              - Block-level Scope
            */
            /*
            string _name = "Mohamed";
            int x = 5;
             // Block-level Scope
             if (true)
            {
                int y = 3;
            }
            //Console.WriteLine(y);

            Console.WriteLine(Program._name);
            */
            // Q-45 Ref & out Keywords // الباقي تحت خاالص
            /*
            Console.Write("Please enter a number: ");
            var isSuccessful = int.TryParse(Console.ReadLine(),out int num);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"Num = {num}");
            //TestRef();
            //TestOut();
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-46 Exceptions// الباقي تحت خاالص

            /*
              - what're exceptions
              - How to handle exceptions
              - How to throw exceptions
            */
            /*
             // what're exceptions and How to handle exceptions
            try
            {
                // int.Parse("Test");
                // Console.WriteLine(Divide(10, 0));
                Console.WriteLine(Divide(10, 3));
                Console.WriteLine(Divide(10, 0));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Custom exception handler for DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
            }
            finally 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Finally I'm Done !");
            }
            
            
            // How to throw exceptions
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter a five  characters string: ");
                var input = Console.ReadLine();
                if (input.Length != 5)
                    throw new Exception("String must be 5 characters long");
                else
                    Console.WriteLine($"Charcters = {input}");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
                Console.ForegroundColor= ConsoleColor.Green;
                
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Q-47 Enums // الباقي تحت خاالص
            /*
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Gander gander = Gander.male;
            Gander gander1 = Gander.famel;
            Console.WriteLine($"{gander.ToString()} = {(int)gander}");
            Console.WriteLine($"{gander1.ToString()} = {(int)gander1}");
            Console.WriteLine("===========================");
            foreach (var Color in Enum.GetNames(typeof(Color)))
            { 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{Color} ={(int)Enum.Parse(typeof(Color),Color)} ");
            }
           */
            /*
            while (true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("{1}Change Background Color\t\t{2}Chang Foreground Color");
                String selectedoption = Console.ReadLine();
                
                foreach (var color in Enum.GetNames(typeof(ConsoleColor)))
                    Console.WriteLine(color);
                try
                {
                    Console.WriteLine("Please write color name: ");
                    String colorName = Console.ReadLine();
                    ConsoleColor selectedColor = ((ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true));
                    if (selectedoption == "1")
                        Console.BackgroundColor = selectedColor;
                    else if (selectedoption == "2")
                        Console.BackgroundColor = selectedColor;
                    else
                        Console.WriteLine("Please Select ColorName !");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Option !");

                }
             }
           */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-48 Flags Enums // الباقي تحت خاالص
            /* 
              - What's Flage Enum
              - How to Define Flags Enum
              - How it morks
              - Bitwise operations {& , | , ~ , ^}
            */
            /*
            WeekDays s1 = WeekDays.monday | WeekDays.Saturday | WeekDays.friday | WeekDays.tuesday;
            WeekDays s2 = WeekDays.monday | WeekDays.thursday | WeekDays.wensday | WeekDays.tuesday ;
            Console.WriteLine(s1 & s2);
            
            Console.WriteLine("-------------------------");           
            WeekDays s3 = s1 ^ WeekDays.Saturday;
            WeekDays s4 = s3 ^ WeekDays.Saturday;
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine("-------------------------");
            Console.WriteLine(s1);
            Console.WriteLine(s1 & ~ WeekDays.friday);

            Console.WriteLine("-------------------------");
            WeekDays fridayFlag = s2 & WeekDays.friday;
            bool isFriday = fridayFlag == WeekDays.friday;
            Console.WriteLine(isFriday);

            Console.WriteLine("-------------------------");
            WeekDays weekend = WeekDays.friday | WeekDays.Saturday  ;
            // 0b_0100_0000
            //0b_0000_0001
            // = 0b_0100_0001
            //Console.WriteLine(0b_0100_0001);
            Console.WriteLine(weekend);
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-49 Training App: Random Values // الباقي تحت خاالص
            /*
            while(true)
            {
                Console.WriteLine("Please select an option: ");
                Console.WriteLine("{1} Generate random number\t\t{2}Generate random string");
                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                    GenertedRandomNumber();
                else if (selectedOption == "2")
                    GenertedRandomString();
                Console.WriteLine("==============================================");
            }
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-50 Training App: File System Command Line
            /*
             - List files & directories: list [path]
             - Print file & directories infe: infe [path]
             - Create directories: mkdir [path]
             - Remove directories: delete [path]
             - Read file content: read [path]
            */
            /*
            while (true)
            {
                Console.Write(">>");
                var input = Console.ReadLine().Trim();
                var whiteSpaceIndex = input.IndexOf(' ');
                var commend = input.Substring(0, whiteSpaceIndex).ToLower();
                var path = input.Substring(whiteSpaceIndex + 1).Trim();
                // Console.WriteLine($"Comment: {comment}");
                // Console.WriteLine($"path: {path}");
                if (commend == "list")
                {
                    foreach (var entry in Directory.GetDirectories(path))
                        Console.WriteLine($"\t[Dir] {entry}");

                    foreach (var entry in Directory.GetFiles(path))
                        //foreach (var entry in Directory.GetFiles(path, "*analytics.settings"))
                        Console.WriteLine($"\t[File] {entry}");
                }
                else if (commend == "info")
                {
                    if (Directory.Exists(path))
                    {
                        var dirInfo = new DirectoryInfo(path);
                        Console.WriteLine("Type Directory");
                        Console.WriteLine($"Create At: {dirInfo.CreationTime}");
                        Console.WriteLine($"Last modified At: {dirInfo.LastWriteTime}");
                    }
                    else if (File.Exists(path))
                    {
                        var fileInfo = new FileInfo(path);
                        Console.WriteLine("Type Files");
                        Console.WriteLine($"Create At: {fileInfo.CreationTime}");
                        Console.WriteLine($"Last modified At: {fileInfo.LastWriteTime}");
                        Console.WriteLine($"Size in Bytes: {fileInfo.Length}");
                    }
                }
                else if (commend == "mkdir")
                {
                    Directory.CreateDirectory(path);
                }
                else if (commend == "print")
                {
                    if (File.Exists(path))
                    {
                        var content = File.ReadAllText(path);
                        Console.WriteLine(content);
                    }
                }
                else if (commend == "remove")
                {
                    if (Directory.Exists(path))
                        Directory.Delete(path);
                    // Directory.Delete(path, true);
                    else if (File.Exists(path))
                        File.Delete(path);
                }
                else if (commend == "exit")
                {
                    break;
                }
            }
            */  
            ////////////////////////////////////////////////////////////////////////////////////////////////////

            // Q-51  Math Expression Evalutor 
            // App.Run(args);
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-52 Abstract Classes &&
            // Q-53 Virtual & protected Members
            //Q - 54  Member Hiding/ Shadowing
            /*
             var rect2 = new Rectangle {leghth = 50 , width = 20 };
             rect2.PrintArea();

             var circle = new Circle { Radius = 30 };
             circle.PrintArea();
            */ 
            /*
            Shape s = new Rectangle { leghth = 50, width = 20 };
            s.PrintArea();
            Shape r = new Rectangle { leghth = 50, width = 20 };
            r.PrintArea();
            s = new Circle { Radius = 30 };
            s.PrintArea();
            */

            //Shape r1 = new Rectangle();
            //r1 = new Circle();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Q-55 Interfaces
            /*
             * Implicit & explicit implementation
             */
            /*
            IDevice device = new MobilePhon();
            device.TurnOn();
            device.TurnOff();

            device = new Computer();
            device.TurnOn();
            device.TurnOff();

            IRestartable restartable = new MobilePhon();
            restartable.Restart();
            restartable = new Computer();
            restartable.Restart();
            */
            //Implicit & explicit implementation
            /*
            IDevice device = new Computer();
            device.TurnOn();
            Computer computer = new Computer();
            computer.TurnOn();
            */
            ////////////////////////////////////////////////////////////////////////////////////////
            // Q-56 ArrayList
            /*
             * Definition
             * Boxing & Unboxing
             */
            /*
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Test");
            list.Add(true);

            list.AddRange(new int[] { 1, 2, 3 });

           // list.Remove(1);
           // list.RemoveRange(0,2);
           // list.RemoveAt(1);
           // list.Insert(2,"Asran");
          // Console.WriteLine("Index of Test = " + list.IndexOf("Asran"));
          // Console.WriteLine("Index of Test = " + list.IndexOf("Asran",3));

            foreach (object itme in list)
            {
                Console.WriteLine(itme);
            }
            */
            // Boxing & Unboxing
            //int x = 5;
            //object y = x;
            //int z = x + (int)y;
            ////////////////////////////////////////////////////////////////////////////////////////
            // Q-57 Generic List & Dictionary
            // Generic List
            /*
            var list = new List<int>(); // Strongle type
            list.Add(1);
            list.Add(2);
            //list.Contains(1);// Return bool
            //list.Clear();
            var x = list[0] + 3.4;
            Console.WriteLine(x);
            */
            //Dictionary
            /*
            var dic = new Dictionary<string, string>();
            dic.Add("Gmail","MOhamed@gmail.com");
            Console.WriteLine(dic["Gmail"]);
            if (!dic.ContainsKey("Gmail"))
            {
                dic.Add("Gmail", "Tast");
                Console.WriteLine(dic["Gmail"]);
            }

            dic.Add("Outlook", "msasdkld");
            if (dic.ContainsKey("Outlook"))
                Console.WriteLine(dic["Outlook"]);

            var isvalue=dic.TryGetValue("Pessowrd", out var value);
            Console.WriteLine(isvalue);
            */
            /////////////////////////////////////////////////////////////////////////////////////////////
            // Q-58 Stack & quaue
            /*
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Stack count = "+stack.Count);
            var itme = stack.Peek();
            Console.WriteLine(itme);
            Console.WriteLine("Stack count = " + stack.Count);
             itme = stack.Pop();
            Console.WriteLine(itme);
            Console.WriteLine("Stack count = " + stack.Count);
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Stack count = " + stack.Count);
            */
            /*
            var commandStack = new Stack<AppendTextCommand>();
            var orginalText = "";
            while (true)
            {
                Console.Write("Type text to append ('exit' to Exit, 'undo' to Undo): ");
                var input = Console.ReadLine();
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;
                else if(input.Equals("undo", StringComparison.OrdinalIgnoreCase))
                {
                    if(commandStack.Count > 0)
                    {
                        var command = commandStack.Pop();
                        orginalText = command.Undo();
                    }
                }
                else
                {
                    var command = new AppendTextCommand(orginalText,input);
                    orginalText = command.Execute();
                    commandStack.Push(command);
                }
            }
            */
            // ExecuteQueueExample(); // Queue
            ////////////////////////////////////////////////////////////////////////////////////////////
            // Q-59 Traing Password manager
            //App.Run(args);
            //////////////////////////////////////////////////////////////////////////////////////////
            // Q- OOP Encapsulation
            /*
            var emplyee= new Emplyee();
            emplyee.SetName ("MOhamed", "asran");
            emplyee.SetBirthDate (new DateOnly(2024,2,4));
            emplyee.SetBasicSalary(2000);
            emplyee.SetTaxPercentage (4440);

            Console.WriteLine($"Full name:\t{emplyee.FirstName} {emplyee.LastName}");
            Console.WriteLine($"Brith Date:\t{emplyee.BirthDate}");
            Console.WriteLine($"Basic Salary:\t{emplyee.BasicSalary}0.00$");
            Console.WriteLine($"Taxe Persentage:\t{emplyee.TaxPercentage}%");
            */
            // Q-OOP Inheritance
            /*
            var emplyee = new Emplyee2();
            emplyee.SetName("MOhamed", "asran");
            emplyee.SetBirthDate(new DateOnly(2024, 2, 4));
            emplyee.SetBasicSalary(2000);
            emplyee.SetTaxPercentage(4440);

            PrintPersonDetails(emplyee);
            Console.WriteLine("------------------------------------------------");
            var applicant = new Applicant();
            applicant.SetName("Ali", "Asran");
            applicant.SetBirthDate(new DateOnly(2025, 4, 5));
            PrintPersonDetails(applicant);

            void PrintPersonDetails(Person person)
            {
                Console.WriteLine($"Full name:\t{person.FirstName} {person.LastName}");
                Console.WriteLine($"Brith Date:\t{person.BirthDate}");
            }
            */
            // Q-OOP Polymorphism
            /*
            var salaryEmplyee = new SalaryEmplyee();
            salaryEmplyee.SetSalaryEmplyee(3000, 1000, 500);
            Console.WriteLine($"Salary of Salaried (withowt taxes) emplyee is {salaryEmplyee.GetSalary()}.00");
            Console.WriteLine($"Salary of Salaried (withowt 10% taxes) emplyee is {salaryEmplyee.GetSalary(10)}.00");
            Console.WriteLine($"Salary of Salaried (withowt 10% taxes and 1000) emplyee is {salaryEmplyee.GetSalary(10,1000)}.00");

            var hourly = new HourlyEmplyee();
            hourly.HourRate = 1000;
            hourly.TotalWorkingHour = 30;
            Console.WriteLine("Salary of Hourly emplyee is " + hourly.GetSalary()+".00");

            var internEmplyee = new InternEmplyee();
            Console.WriteLine($"Salary of Hourly emplyee is {internEmplyee.GetSalary()}.00");
            Console.ReadKey();
            */
            // Q-OOP Abstraction
            /*
            var salaryEmplyee2 = new SalaryEmplyee2();
            salaryEmplyee2.SetName("Ali", "Asran");
            salaryEmplyee2.SetSalaryEmplyee(3000, 1000, 500);
            Console.WriteLine($"Salary of Salaried (withowt taxes) emplyee is {salaryEmplyee2.GetSalary()}.00");
            Console.WriteLine($"Salary of Salaried (withowt 10% taxes) emplyee is {salaryEmplyee2.GetSalary(10)}.00");
            Console.WriteLine($"Salary of Salaried (withowt 10% taxes and 1000) emplyee is {salaryEmplyee2.GetSalary(10, 1000)}.00");

            var hourly = new HourlyEmplyee2();
            hourly.SetName("Mohamed", "Asran");
            hourly.HourRate = 1000;
            hourly.TotalWorkingHour = 30;
            Console.WriteLine("Salary of Hourly emplyee is " + hourly.GetSalary() + ".00");

            var internEmplyee2 = new InternEmplyee2();
            internEmplyee2.SetName("Fars", "Asran");

            Console.WriteLine($"Salary of Hourly emplyee is {internEmplyee2.GetSalary()}.00");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------");
            var notifier = new Notifier("mail@example.com", 25 ,"noreply@example.com", "Abc123");
            var payslipGeneratir = new PayslipGenerator(notifier);
            payslipGeneratir.Generate(salaryEmplyee2);
            //payslipGeneratir.Generate(hourlyEmplyee2);
            payslipGeneratir.Generate(internEmplyee2);
            Console.ReadKey();
            */
            ///////////////////////////////////////////////////////////////////////////////////

        }
        //////////////////////////////////////////////////////////////////////////
        // Q- 42 Constants & Read-only Variabls
        /*
       // Constants // compuler time Constants
       public const String Message ="Hello World"; 
       public const int Id = 24;
       public const double GPA = 3.10;

       // Read-only Variabls // Run time Constant
       private static readonly String _message; 
       static Program()
       {
          _message = "Test";
          _message = "Hello World !";
       }
       */
        //////////////////////////////////////////////////////////////////////////
        // Q-44 Variable Scopes
        /*
        private static String _name = "Ali";
        static void MyMathod()
        {
            _name = "Asran";
          
        }
        */
        //////////////////////////////////////////////////////////////////////////////
        // Q-45  Ref & out Keywords 
        /*
        private static void TestOut()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            bool isSuccessful;
            var result = DivideOut(10, 0, out isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"Result = {result}");
        }

        private static void TestRef()
        {
            Console.ForegroundColor= ConsoleColor.Red;
            bool isSuccessful=false ;
            var result = Divide(10, 5, ref isSuccessful);
            Console.WriteLine($"isSuccessful = {isSuccessful}");
            Console.WriteLine($"Result = {result}");
        }


        // Ref -> not must put value befor Sent in isSuccessful
        static double Divide(double number, double divisor, ref bool isSuccessful) 
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero 1");
                //isSuccessful = false;
                return 0;
            }
            isSuccessful=true;
            return number / divisor;
        }

        // Out -> must put value befor Sent in isSuccessful
        static double DivideOut(double number, double divisor, out bool isSuccessful)
        {
            if (divisor == 0)
            {
                Console.WriteLine("Can't divide on Zero !");
                isSuccessful = false;
                return 0;
            }
            isSuccessful=true;
            return number / divisor;
        }
        */
        //////////////////////////////////////////////////////////////////////
        // Q-46 Exceptions
        /*
        static int Divide(int number, int divisor)
        {
            //if (divisor == 0)
               // return 0;
            return number / divisor;
        }
        */
        ///////////////////////////////////////////////////////////////////////
        // Q-47 Enums 
        /*
        public enum Gander
        {
            male,
            famel
        }

        public enum Color
        {

            red,
            green,
            blue,
        }
        */
        ////////////////////////////////////////////////////////////////////////////
        // Q-48 Flags Enums
        /*
        [Flags]
        public enum WeekDays
        { 
            None = 0b_0000_0000,
            Saturday = 0b_0000_0001, 
            sunday = 0b_0000_0010,
            monday = 0b_0000_0100,
            tuesday = 0b_0000_1000,
            wensday = 0b_0001_0000,
            thursday = 0b_0010_0000,
            friday = 0b_0100_0000,
        }
        */
        ///////////////////////////////////////////////////////////////////////////////////////
        // Q-49 Training App: Random Values
        /*
        static void GenertedRandomNumber()
        {
            var rnd = new Random();
            var value = rnd.Next(1000, 9999);
            Console.WriteLine(value);
        }

        private const String Buffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz012345679--!@#%*()";
        private static void GenertedRandomString()
        {
            var sb = new StringBuilder();
            var rnd = new Random();
            while (sb.Length < 16)
            {
                var randomIndex = rnd.Next(0, Buffer.Length - 1);
                sb.Append(Buffer[randomIndex]);
            }
            Console.WriteLine($"Random String: {sb}");

        }
        */
        ////////////////////////////////////////////////////////////////////////////////
        // Q-58 Stack & Queue
        // Stack
        /*
        class AppendTextCommand
        {
            private string _orginalText;
            private readonly string _textToAppend;

            public AppendTextCommand(String orginalText, String textToAppend)
            {
                _orginalText = orginalText;
                _textToAppend = textToAppend;
            }

            public String Execute()
            {
                _orginalText += _textToAppend;
                Console.WriteLine(_orginalText);
                return _orginalText;
            }
            public String Undo()
            {
                _orginalText = _orginalText.Substring(0, _orginalText.Length - _textToAppend.Length);
                Console.WriteLine(_orginalText);
                return _orginalText;
            }
        }
        */
        // Queue
        /*
        static void ExecuteQueueExample()
        {
            var queue = new Queue<string>();
            while (true)
            {
                Console.Write("Please select a document to print ('print' to print): ");
                var input = Console.ReadLine();
                if (input.Equals("print", StringComparison.OrdinalIgnoreCase))
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine($"Printing document '{queue.Dequeue()}'....");
                        Console.WriteLine("Queue count: "+ queue.Count);
                    }
                }
                else
                    queue.Enqueue(input);
                }
        }
        */
    }
} 