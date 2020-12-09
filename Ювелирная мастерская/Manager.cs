using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ювелирная_мастерская
{
    class Manager
    {
        public static int id;
        public static string surname;
        public static string name;
        public static string patronymic;
        public static string address;
        public static string phone;
        public static float salary;
        public static string login;
        public static string password;


        public Manager(int ID, string Surname, string Name, string Patronymic, string Address, string Phone, float Salary, string Login, string Password)
        {
            ID = id;
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Address = address;
            Phone = phone;
            Salary = salary;
            Login = login;
            Password = password;
        }
    }
}
