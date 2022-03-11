using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    // Question ---> 14
    //..............................................................................
    interface IContractEmployee
    {
        void CalculateSalary(int hour, int perHourRupees);
    }
    internal class Infosys : IContractEmployee
    {
        public void CalculateSalary(int hour, int perHourRupees)
        {
            Console.WriteLine($"SALARY : { CalculateSalary()}"); 

            int CalculateSalary()
            {
                int salary = hour * perHourRupees;
                return salary;
            }
        }
    }
    //..............................................................................
    // Question----> 10
    internal class Student
    {
        int StudentID;
        string FullName;
        string CourseName;
        string PhoneNo;
        public Student(int studentId, string fullName, string courseName, string phoneNo)
        {
            StudentID = studentId;
            FullName = fullName;
            CourseName = courseName;
            PhoneNo = phoneNo;
        }
        public void Summary()
        {
            Console.WriteLine($"STUDENT ID : {StudentID}");
            Console.WriteLine($"FULL NAME : {FullName}");
            Console.WriteLine($"COURSE NAME : {CourseName}");
            Console.WriteLine($"PHONE NUMBER : {PhoneNo}");
        }
    }
    //..................................................................................
    //Question----->13
    internal class Employee
    {
        public int EmployeeID;
        public string FullName;
        public string PhoneNo;
        public string DepartmentName;
        public Employee(int employeeID,string fullName,string phoneNo,string departmentName)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            PhoneNo = phoneNo;
            DepartmentName = departmentName;

        }
        public void ShowDetail()
        {
            Console.WriteLine($"EMPLOYEE ID : {EmployeeID}");
            Console.WriteLine($"FULL NAME : {FullName}");
            Console.WriteLine($"PHONE NUMBER : {PhoneNo}");
            Console.WriteLine($"DEPARTMENT : {DepartmentName}");
        }
    }
    internal class ITEmployee : Employee
    {
        public ITEmployee(int employeeID, string fullName, string phoneNo, string departmentName) : base(employeeID, fullName, phoneNo, departmentName)
        {
            employeeID = employeeID;
            fullName = fullName;
            phoneNo = phoneNo;
            departmentName = departmentName;
        }
    }
    //.................................................................................
    internal class Program
    {
        string UserName;
        int ID;
        string Password;
        Program(string UserName, int ID, string Password)
        {
            this.UserName = UserName;
            this.ID = ID;
            this.Password = Password;
        }
        static void Main(string[] args)
        {
            //Question1();
            //Question2();
            //Question3();
            //Question4();
            //Question5();
            //Question7();
            //Question8();
            //Question9();
            //Question10();
            //Question11();
            //Question13();
            //Question14();
            //Question15A();
            //Question15B();
            //Question15C();
            //Question17();

            Console.ReadLine();
        }

        /// <summary>
        /// 1. What will be the output of below code -----
        /// Console.WriteLine(Math.Round(12.5));------
        /// Console.WriteLine(Math.Round(10.5));
        /// </summary>
        private static void Question1()
        {
            Console.WriteLine(Math.Round(12.5));
            Console.WriteLine(Math.Round(10.5));
            
        }

        /// <summary>
        /// 2. Accept no from user and write table as follows. For example user types 19 then output should be:
        /// </summary>
        private static void Question2()
        {
            Console.WriteLine("Enter Number.......");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int count = 1;
            while (count <= 10)
            {
                Console.WriteLine($"{num} *  {count} :  {num * count}");
                count++;
            }
        }

        /// <summary>
        /// 3.Add values following fields from user in dictionary. After inserting ask user's input to accept key to delete data from dictionary.
        ///If key does not exist then prompt message that Key does not exist in collection.If key exists then delete it.

        /// </summary>
        private static void Question3()
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Rahul");
            d.Add(2, "Omveer");
            d.Add(3, "shubhum");
            d.Add(4, "Shivani");
            d.Add(5, "Aayush");
            d.Add(6, "Piyush");

            Console.WriteLine("Enter a number : ");
            int user = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            foreach (KeyValuePair<int, string> i in d)
            {
                if (i.Key == user)
                    Console.WriteLine("key {0} value{1}", i.Key, i.Value);
                count++;
            }
            if (user > count)
                Console.WriteLine("Key does not exist");
        }

        /// <summary>
        /// 4.Create an enum with  below values, accept value from user and using switch case show respective Day
        ///Enum :Sun, Mon, Tue, Wed, Thur, Fri, Sat

        /// </summary>


        private static void Question4()
        {
            Console.WriteLine("Enter the Value : ");
            int Value = Convert.ToInt32(Console.ReadLine());
            switch (Value)
            {
                case 0:
                    Console.WriteLine($"{Days.Sun}");
                    break;
                case 1:
                    Console.WriteLine($"{Days.Sun}");
                    break;
                case 2:
                    Console.WriteLine($"{Days.Mon}");
                    break;
                case 3:
                    Console.WriteLine($"{Days.Tue}");
                    break;
                case 4:
                    Console.WriteLine($"{Days.Thur}");
                    break;
                case 5:
                    Console.WriteLine($"{Days.Fri}");
                    break;
                case 6:
                    Console.WriteLine($"{Days.Sat}");
                    break;
                case 7:
                    Console.WriteLine($"{Days.Sun}");
                    break;
            }

        }


        /// <summary>
        /// 5. Accept key as "No. of developers" prefering programing language and Value as "Progrmmming lanugage" in preferred collection.
        ///basedon on count of developers preferring programming language give ranking to that programming language.
        ///For example: 1200 - CSharp, 1400 - Python, 456 -  Java, 1900 - javascript, 1500 - SQL

        /// </summary>
        private static void Question5()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("RANK 1", "SQL");
            d.Add("RANK 2", "PYTHON");
            d.Add("RANK 3", "C_SHARP");
            d.Add("RANK 4", "JAVA");
            d.Add("RANK 5", "JAVASCRIPT");

            foreach (KeyValuePair<string, string> i in d)
            {
                Console.WriteLine("key {0}--> value{1}", i.Key, i.Value);
            }
        }

        /// <summary>
        /// 7. Create a method which takes Number of string parameters. Number of parameters may varry in every call, but it should call same function.
        /// </summary>
        private static void Question7()
        {
            Param("Rahul", "Omveer", "Shubhum", "Shivani", "Ayush", "pyush");
            void Param(params string[] name)
            {
                foreach (string s in name)
                    Console.WriteLine(s);
            }
        }

        /// <summary>
        /// 8. Use an appropriate collection which holds multiple values of different types. Make a note that collection item is readonly
        /// </summary>
        private static void Question8()
        {
            Tuple<int, string, float> t = new Tuple<int, string, float>(1, "Rahul", 93.2f);
            Console.WriteLine($"ID : {t.Item1}");
            Console.WriteLine($"NAME : {t.Item2}");
            Console.WriteLine($"PERCENTAGE : {t.Item3}");
        }

        /// <summary>
        /// 9. Create an string array of size 5, accept Students name using loop. Print all the member of that array.
        ///Now try to add one more member at 6th position, If any exception occurs please handle it.
        /// </summary> 

        private static void Question9()
        {
            string[] vs = { "Rahul", "Omveer", "Shubhum", "Shivani", "Ayush", "pyush" };
            int i = 0;
            for (i = 0; i < vs.Length; i++)
            {
                Console.WriteLine(vs[i]);
            }
            try
            {
                vs[vs.Length + 1] = "Anmol";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// 10.Create a student class and include below properties:
        ///StudentID int, FullName string, CourseName string, PhoneNo string
        ///Accept of Student's  details 5 entries at least and print as a summary
        /// </summary>
        private static void Question10()
        {
            Student stu = new Student(1, "Rahul", "java", "4556456");
            stu.Summary();
        }

        /// <summary>
        /// 11. Create an array of 10 numbers and print the 3rd highest no.
        /// </summary>

        private static void Question11()
        {
            // USING with SORT METHOD

            int[] num = { 9, 5, 7, 8, 2, 4, 3, 1 };
            Array.Sort(num);
            int i = 0;
            Console.WriteLine($"Third Highest Value : {num[2]}");


            // USING without METHOD

            int[] num2 = { 9, 5, 7, 8, 2, 4, 3, 1 };
            int J = 0;
            int temp;
            int k;
            for (J = 1; J < num2.Length; J++)
            {

                if (num2[J - 1] > num2[J])
                {
                    int index;
                    for (index = J - 1; index >= 0; index--)
                    {
                        if (num2[index] > num2[index + 1])
                        {
                            temp = num2[index];
                            num2[index] = num2[index + 1];
                            num2[index + 1] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"Third Highest Value : {num2[2]}");

        }

        /// <summary>
        /// a. 	Create a class Employee with 4 properties : EmployeeID, FullName, PhoneNo, DepartmentName
        /// Create a method which returns List of Employees which holds at least 5 employees details
        ///Write a method Show all employees details
        ///b.Create a class ITEmployee and inherit it from Employee.
        ///Add a method in this class to show some dummy Technical skills like "SQL, Python, Azure, CSharp, Angular etc."
        /// </summary>
        private static void Question13()
        {
            Employee e = new ITEmployee(1, "Rahul", "58557657", "IT");
            e.ShowDetail();
        }

        /// <summary>
        /// a. Create an Interface named IContractEmployee with one method declaration  CalculateSalary(int hour, int perHourRupees)
        /// b.Create a class Named Infosys which impliments IContractEmployee
        /// c.Impliment function CalculateSalary such that salary is hour* PerHourRupees
        /// </summary>


        private static void Question14()
        {
            Infosys info = new Infosys();
            info.CalculateSalary(2, 5000);
        }

        /// <summary>
        /// 15(a). Create  function Given a string, write a method that checks if it is a palindrome. String length may be >= 0.
        /// </summary>

        private static void Question15A()
        {
            Console.WriteLine("Enter a name : ");
            string nm = Console.ReadLine();
            Console.WriteLine(IsPalidromeOrNot(nm));

            Boolean IsPalidromeOrNot(string name)
            {
                string Rev_name = null;
                int i;
                for (i = 0; i < name.Length; i++)
                {
                    Rev_name = name[i] + Rev_name;
                }
                Console.WriteLine(Rev_name);
                if (Rev_name == name)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

            /// <summary>
            /// 15(b).  create a static method to accept value from user and checks if year is leap.
            /// </summary>
            private static void Question15B()
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
        /// 15(c).  Create a function in c# to take input from user and check if a method that returns n-th element of Fibonacci sequence using recursion.
        /// </summary>
        private static void Question15C()
        {
            Console.WriteLine("Enter Element.......");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(0);
            FiboSeries(0, 1, num);
            int FiboSeries(int min, int max, int dec)
            {
                Console.WriteLine(max);
                int temp;
                temp = min + max;
                min = max;
                max = temp;

                if (dec == 0)
                {
                    return 1;
                }
                return FiboSeries(min, max, dec - 1);
            }
        }

        /// <summary>
        ///  a. Create a class named UserInfo with 3 properties : UserName, Password and EmailID
        ///hardcode username and password in constructor
        /// b.write a method to authenticate User
        ///if password matches then populate message "Welcome to portal...! have a nice day"
        ///if not matched then show messag "Invalid login name or password. Please provide correct credentials"

        /// </summary>
        private static void Question17()
        {
            Program obj = new Program("Rahul", 1, "Dadoo");

            string Pass = Console.ReadLine();
            if (Pass == obj.Password)
                Console.WriteLine("Welcome to portal...! have a nice day");
            else
                Console.WriteLine("Invalid login name or password");
        }



    }

    enum Days
    {
        Sun,
        Mon,
        Tue, 
        Wed, 
        Thur,
        Fri,
        Sat
    }
    


}
