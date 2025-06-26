using ConsoleCoreApp.Constants;
using System.Text;

namespace ConsoleCoreApp
{
    internal class Program
    {
        // Comment multiple lines at a time---- Ctrl+kc
        //uncomment---  ctrl+Ku
        //format document---ctrl+kd
        //console.writeline---cw+tab key

        static void Main(string[] args)
        {
            #region variables

            //string userName = "vanishree";//explict type declartion
            //var city = "Bangalore";//Implicit type declration
            //int _pincode = 1234;//private variables
            //var age;//implicit typed variables must be intialized
            //age = 30;
            //string addr;
            //addr = "14-15";

            //Console.WriteLine(userName);
            //Console.WriteLine(city);

            //Console.WriteLine($"userName is ::{userName}\tCity::{city}");
            #endregion
            #region Datatypes
            //string studentName = "vanishree";
            //string pinCode = "1234";
            //int marks = 80;
            //string city = "Chennai";
            //float avg = 75.67f;
            //decimal fee = 3456.123M;
            //double max = 123456.45678d;
            //bool isActive = true;

            ////datatype conversion
            //float studentMarks = marks;//implicit conversion
            //marks =( int)avg;//explicit conversion

            //int name = Convert.ToInt32( pinCode);
            #endregion
            #region default values
            //int marks = default;
            //float avg = default;
            //bool isActive = default;
            //string name = default;
            //Console.WriteLine($"Marks::{marks}\tAvg::{avg}\tActive::{isActive}\tname::{name}");
            #endregion
            #region Taking User Input
            //Console.WriteLine("enter your Name::");
            //string userName = Console.ReadLine();
            //Console.WriteLine("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            ////int age = int.Parse(Console.ReadLine());
            ////Console.WriteLine("enter the Date");
            ////DateTime joinedDate = Convert.ToDateTime( Console.ReadLine());
            //DateTime joinedDate = DateTime.Now;
            //// int age = int.TryParse(Console.ReadLine());--return a boolean value mentioning conversion successful
            //Console.WriteLine($"Name is::{userName}\tAge::{age}\tdate::{joinedDate}");
            #endregion
            #region Accessing Structure Members
            //Address address = new Address();
            //address.houseNum = "123-456";
            //address.city = "Bangalore";
            //address.pinCode = 12345;
            //Console.WriteLine($"h.No::{address.houseNum}\tCity::{address.city}\tpincode::{address.pinCode}");
            #endregion
            #region Accessing Enums
            //Console.WriteLine(Categories.Fashion); //4
            //int categoryId = (int)Categories.Electronics;
            #endregion

            //int num1 = 100;
            //int num2 = 300;
            //Console.WriteLine(num1+num2);
            #region Conditional Statements
            //Console.WriteLine("enter your Name::");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Enter your Password::");
            //string password = Console.ReadLine();
            //if(userName=="vanishree"&& password == "password")
            //{
            //    Console.WriteLine("Login Success");
            //}
            //else
            //{
            //    Console.WriteLine("name or password field is not matching");
            //}
            #endregion
            #region Dynamic Types
            //dynamic age;
            //age = 100;
            //dynamic age1 = 100;
            //age1 = "100";
            //Console.WriteLine(age1.GetType());
            //Console.WriteLine(age.GetType());
            #endregion
            #region anonymous Type
            //var address = new { hNum = 1, City = "Bangalore", pin = 12345 };
            //Console.WriteLine(address.hNum);
            // address.hNum = 2;//anonymous types are readonly--value cannot be changed
            #endregion
            #region Nullable types
            //string name = null ;
            //int? age = null;
            //if (age.HasValue)//bool type, if variable contains value it returns true else false
            //    Console.WriteLine(age);
            //else
            //    Console.WriteLine("value is null");

            //bool? isActive = null;
            //int myAge = age ?? 0;
            //Console.WriteLine(myAge);
            #endregion
            #region string and stringBuilder
            //string msg = "hello";
            //string msg1 = "team";
            //StringBuilder stringBuilder = new StringBuilder();
            //Console.WriteLine(stringBuilder.Capacity); //
            //stringBuilder.Append(msg);
            ////stringBuilder.Append("");
            ////stringBuilder.Append(msg1);
            //Console.WriteLine(stringBuilder.Capacity); 
            //Console.WriteLine(stringBuilder);
            DateTime startTime;
            DateTime endTime;
            TimeSpan totalTime;
            string name = "";
            //startTime = DateTime.Now;
            //for(int i = 0; i < 10000; i++)
            //{
            //    name += i;//concatination
            //}
            //endTime = DateTime.Now;
            //totalTime = endTime - startTime;
            //Console.WriteLine($"Total time Taken is::{totalTime.TotalSeconds}");//0.2481

            //string builder
            StringBuilder sb = new StringBuilder();
            startTime = DateTime.Now;
            for(int i = 0; i < 10000; i++)
            {
                sb.Append(i);
            }
            endTime = DateTime.Now;
            totalTime = endTime - startTime;
            Console.WriteLine($"Total time taken is ::{totalTime.TotalSeconds}");//0.0064
            #endregion
            Console.WriteLine("working with github");
            Console.WriteLine("working on payment");


        }

    }
    #region donot add class or struct in program.cs file
    //public  struct Address
    //  {
    //    public  string houseNumber;
    //   public   string city;
    //      string street;
    //      int pincode;
    //  }
    #endregion

}
