using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user
{
    class Program
    {
        static void Main(string[] args)
        {
            User SomeUser = new User();
            SomeUser.Login = "format1cle";
            SomeUser.Name = "Illya";
            SomeUser.Surname = "Korobkin";
            SomeUser.Age = 21;

            Console.WriteLine("Информация про користувача:\nЛогин: {0}\nИмя: {1}\nФамилия: {2}\nВозраст: {3}\nДата створення: {4}", SomeUser.Login, SomeUser.Name, SomeUser.Surname, SomeUser.Age, DateTime.Now);




        }




    }





    
}
