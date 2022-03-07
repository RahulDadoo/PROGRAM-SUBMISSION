using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your Choice : ");
            Console.WriteLine("1.....Average");
            Console.WriteLine("2.....Absolute value");
            Console.WriteLine("3.....Compound Interest");
            Console.WriteLine("4.....Cube of a Number");
            Console.WriteLine("5.....Leap Year");
            Console.WriteLine("6.....Even or Odd");
            Console.WriteLine("7.....Even Number From 1 to N");
            Console.WriteLine("8.....Largest Of Two Number");
            Console.WriteLine("9.....Largest of Three Number");
            Console.WriteLine("10....Multipilaction Table");
            Console.WriteLine("11....Number is Divisible 5 and 11");
            Console.WriteLine("12....Interest");
            Console.WriteLine("13....Number is Armstrong Number");
            Console.WriteLine("14....Prime Number");
            Console.WriteLine("15....Number from 1 to 11");
            Console.WriteLine("16....Area of Parallelogram");
            Console.WriteLine("17....TrapeZoid");
            Console.WriteLine("18....Area of Right Angled Triangle");
            Console.WriteLine("19....Area of Equilateral Triangle");
            Console.WriteLine("20....Area Of Rhombus");
            Console.WriteLine("21....Perimeter of Rhombus");
            Console.WriteLine();
            Console.WriteLine();
            dynamic num = 1;
            while(num != 0) 
            {
                
                Console.WriteLine("Enter Your Choice.............");
                dynamic select = Console.ReadLine();

                switch (select)
                {
                    case "1":
                        Average();
                        break;
                    case "2":
                        Absolute();
                        break;
                    case "3":
                        CompoundInterest();
                        break;
                    case "4":
                        Cube();
                        break;
                    case "5":
                        LeapYear();
                        break;
                    case "6":
                        EvenOrOdd();
                        break;
                    case "7":
                        EvenNumber();
                        break;
                    case "8":
                        LargestOfTwoNumbers();
                        break;
                    case "9":
                        LargestOfThreeNumbers();
                        break;
                    case "10":
                        MultipilactionTable();
                        break;
                    case "11":
                        NumDivOnly_5_And_11();
                        break;
                    case "12":
                        Interest();
                        break;
                    case "13":
                        ArmgstrongNum();
                        break;
                    case "14":
                        PrimeNum();
                        break;
                    case "15":
                        NumFrom_1_to_11();
                        break;
                    case "16":
                        Parallelogram();
                        break;
                    case "17":
                        TrapeZoid();
                        break;
                    case "18":
                        AreaOf_RightAngledTriangle();
                        break;
                    case "19":
                        AreaOf_EquilateralTriangle();
                        break;
                    case "20":
                        AreaOf_Rhombas();
                        break;
                    case "21":
                        PerimeterOf_Rhombus();
                        break;

                    default:
                        Console.WriteLine("Select Correct Choice.........");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("If you Want to CHECK One MORE Solution...So PRESS 1");
                Console.WriteLine("....................OR..........................");
                Console.WriteLine("If you Want to EXIST!!...So PRESS 0");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("PRESS HERE.........");
                dynamic check = Convert.ToInt32(Console.ReadLine());
                num = check;

            }
            Console.ReadLine();


        }      
        /// <summary>
        /// This is a method to Find the Average Value
        /// </summary>

        private static void Average()
        {
            Console.WriteLine();
            Console.WriteLine("How Many Values You have To Find The Average??");
            Console.WriteLine("Enters a Number : ");
            dynamic num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            double sum = 0;
            dynamic count = 0;
            while(num != 0)
            {
                Console.WriteLine($"Enter....VALUE {count + 1} : ");
                dynamic value = Convert.ToInt32(Console.ReadLine());
                sum = sum + value;
                count++;
                num = num - 1;
            }
            double Avg = sum / count;
            Console.WriteLine($".........Average : {Avg}");
        }

        /// <summary>
        /// This is the to find the Absolute value
        /// </summary>
        private static void Absolute()
        {
            Console.WriteLine("Enters a Number : ");
            dynamic Abs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (Abs < 0)
                Console.WriteLine($"............Absolute Value : {-Abs}");
            else
                Console.WriteLine($".............Absolute Value : {Abs}");
                   
        }

        /// <summary>
        /// This is a meathod to Find the CompoundInterest
        /// </summary>
        private static void CompoundInterest()
        {
            Console.WriteLine("Enter.. Initial Principal Balance : ");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter..Interest Rate : ");
            double r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter..Number Of Times Interest Applied Per Time Period : ");
            dynamic n = Convert.ToInt32(Console.ReadLine());
            dynamic CI = p*(Math.Pow(1 + (r / 100),n)) - p;
            Console.WriteLine($"..............COMPOUND INTEREST : {CI}");
        }

        /// <summary>
        /// This is a method to Find the Cube Of a Number
        /// </summary>
        private static void Cube()
        {
            Console.WriteLine("Enter the Value : ");
            dynamic cube = Convert.ToInt32(Console.ReadLine());
            cube = cube * cube * cube;
            Console.WriteLine();
            Console.WriteLine($"............CUBE : {cube}");
        }

        /// <summary>
        /// This is a method to Find the Leap Year
        /// </summary>
        private static void LeapYear()
        {
            Console.WriteLine("Enter Year.... : ");
            dynamic Leap_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (Leap_year % 4 == 0)
                Console.WriteLine("..............Leap Year...............");
            else
                Console.WriteLine(".............NOT Leap Year.............");
        }

        /// <summary>
        /// This is method to Find this number is Even or Odd Number
        /// </summary>
        private static void EvenOrOdd()
        {
            Console.WriteLine("Enter The Value.....");
            dynamic num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (num % 2 == 0)
                Console.WriteLine("..........EVEN NUMBER............");
            else
                Console.WriteLine("..........ODD NUMBER..............");
        }

        /// <summary>
        /// This is a method to Find the Even Number
        /// </summary>
        private static void EvenNumber()
        {
            Console.WriteLine("Enter Value1.....");
            dynamic num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value2.....");
            dynamic num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (num1 != num2 + 1)
            {
                if (num1 % 2 == 0)
                    Console.WriteLine($"..........EVEN NUMBER...{num1}");
                num1++;
            }

        }

        /// <summary>
        /// This is a method to Find the Largest Of Two Number
        /// </summary>
        private static void LargestOfTwoNumbers()
        {
            Console.WriteLine("Enter Value1.....");
            dynamic num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value2.....");
            dynamic num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (num1 > num2)
                Console.WriteLine($".............Greater Number.... {num1}");
            else if (num1 < num2)
                Console.WriteLine($".............Greater Number..... {num2}");
            else
                Console.WriteLine("..........BOTH NUMBER ARE EQUAL");
        }

        /// <summary>
        /// This is a method to Find the Largest Of Three Number
        /// </summary>
        private static void LargestOfThreeNumbers()
        {
            Console.WriteLine("Enter Value1.....");
            dynamic num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value2.....");
            dynamic num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value3.....");
            dynamic num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (num1 > num2  && num1 > num3)
                Console.WriteLine($".........Greater Number.... {num1}");
            else if (num1 < num2 && num3 < num2)
                Console.WriteLine($".........Greater Number..... {num2}");
            else if (num1 < num3 && num2 < num3)
                Console.WriteLine($"..........Greater Number.....{num3}");
            else if(num1 == num2 && num1 < num3)
                Console.WriteLine($"..........Greater Number.....{num3}");
            else if(num1 == num2 && num2 > num3)
                Console.WriteLine($"..........Greater Number.....{num2}");
            else if(num1 == num3 && num3 < num2)
                Console.WriteLine($"..........Greater Number.....{num2}");
            else if(num1 == num3 && num3 > num2)
                Console.WriteLine($"..........Greater Number.....{num3}");
            else if(num2 == num3 && num3 < num1)
                Console.WriteLine($"..........Greater Number.....{num1}");
            else if(num2 == num3 && num2 > num1)
                Console.WriteLine($"..........Greater Number.....{num2}");
            else
                Console.WriteLine($"..........All Number Are Equal");
        }

        /// <summary>
        /// This is a method to Find the Multipication Table
        /// </summary>
        private static void MultipilactionTable()
        {
            Console.WriteLine("Enter Number.......");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine($"{num} *  {count} :  {num*count}");
                count++;
            }
        }

        /// <summary>
        /// This is a method to Find the Numeber Divisible by 5 and 11
        /// </summary>
        private static void NumDivOnly_5_And_11()
        {
            Console.WriteLine("Enter Number.......");
            dynamic num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (num % 5 == 0 && num % 11 == 0)
                Console.WriteLine("............ CORRECT NUMBER !!....");
            else
                Console.WriteLine(".............NOT CORRECT NUMBER !!....");
        }

        /// <summary>
        /// This is a method to Find the Interest
        /// </summary>
        private static void Interest()
        {
            Console.WriteLine("Enter.. Principal Value : ");
            double p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter...Rate : ");
            double r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter..Time: ");
            dynamic t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            dynamic Interest = (p * r * t)/100;
            Console.WriteLine($"...........Interest : {Interest}");
        }

        /// <summary>
        /// This is a method to Find the Armgstrong Number
        /// </summary>
        private static void ArmgstrongNum()
        {
            Console.WriteLine("Enter Number.......  ");
            string number = Console.ReadLine();
            int length = number.Length;
            int num = Convert.ToInt32(number);
            Console.WriteLine();
            double Armst = 0;
            double Value = num*1;
            while(num != 0)
            {
                double rem = num % 10;
                Armst = Armst + Math.Pow(rem, length);
                num = num / 10;
            }
            if (Value == Armst)
                Console.WriteLine("............ARMSTRONG NUMBER");
            else
                Console.WriteLine("............NOT ARMSTRONG NUMBER");
        }

        /// <summary>
        /// This is a method to Find the Prime Number
        /// </summary>
        private static void PrimeNum()
        {
            Console.WriteLine("Enter Value.....");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int PrimeNumber = num*1;
            num = (num - 1)/2;
            Boolean temp = false;
            while(num > 1)
            {
                if ((PrimeNumber % num) == 0)
                    temp = true;
                num = num - 1;
            }
            
            if(temp == true)
                Console.WriteLine("............NOT PRIME NUMBER");
            else
                Console.WriteLine("............PRIME NUMBER");

        }

        /// <summary>
        /// This is a method to Find the Number From 1 to 11
        /// </summary>
        private static void NumFrom_1_to_11()
        {
            int num = 1;
            Console.WriteLine();
            while (num <= 11)
            {
                Console.WriteLine($"..............NUMBER....{num}");
                num = num + 1;  
            }
        }

        /// <summary>
        /// This is a method to Find the Parallelogram
        /// </summary>
        private static void Parallelogram()
        {
            Console.WriteLine("Enter..Base.....");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter..Height....");
            int Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"..............Area Of Parallelogram..... {Base * Height}");
        }

        /// <summary>
        /// This is a method to Find the TrapeZoid
        /// </summary>
        private static void TrapeZoid()
        {
            Console.WriteLine("Enter....Base1....");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter....Base2....");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter....Height....");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($".............Area of TrapeZoid........{((a+b)*h)/2}");
        }

        /// <summary>
        /// This is a method to Find the Area Of Right Angled Triangle
        /// </summary>
        private static void AreaOf_RightAngledTriangle()
        {
            Console.WriteLine("Enter....Base....");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter....Height....");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($".............Area of Right Angled Triangle.....{(Base * height) / 2}");
        }

        /// <summary>
        /// This is a method to Find the Equilateral Triangle
        /// </summary>
        private static void AreaOf_EquilateralTriangle()
        {
            Console.WriteLine("Enter.....Side....");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($".............Area Of Equilateral Triangle......{(1.732*side*side)/4}");
        }

        /// <summary>
        /// This is a method to Find the Area of Rhombus
        /// </summary>
        private static void AreaOf_Rhombas()
        {
            Console.WriteLine("Enter....Diagonal_1....");
            int diagonal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter....Diagonal_2....");
            int diagonal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($".............Area of Rhombus.......{(diagonal1 * diagonal2) / 2}");
        }
        /// <summary>
        /// This is a method to Find the Perimeter Of Rhombus
        /// </summary>
        private static void PerimeterOf_Rhombus()
        {
            Console.WriteLine("Enter.....Side....");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($".............Perimeter Of Rhombus......{4 * side}");
        }

    }
}
