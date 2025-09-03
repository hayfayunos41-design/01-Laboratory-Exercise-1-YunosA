using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Laboratory_Exercise_1_YunosA
{
    internal class StudentInfoClass
    {
        public delegate string DelegateText(string txt);
         public delegate long DelegateNumber(long num);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static long GetStudentNo(long studentNo) => studentNo;
        public static string GetProgram(string program) => program;
    
        public static string GetFirstName(string firstName) => firstName;
        public static string GetMiddleName(string middleName) => middleName;
        public static string GetLastName(string lastName) => lastName;
        public static long GetAge(long age) => age;
        public static long GetContactNo(long contactNo) => contactNo;
        public static string GetAddress(string address) => address;

    }
}
