using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user
{
    class User
    {
        string login;
        string name;
        string surname;
        int age;
        public DateTime date;

        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "Не заповнено!";
                else
                    return login;
            }
        
        }
        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "Не заповнено!";
                else
                    return name;

            }
        }
        public string Surname
        {
            set { surname = value; }
            get
            {
                if (surname == null)
                    return "Не заповнено!";
                else 
                    return surname;


            }
        }
        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    return 18;
                else
                    return age;
            }
        }
        public User()
        {
            date = DateTime.Now;    
        }
        public User(string login,string name, string surname, int age)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age; 
            date = DateTime.Now;
        }

    }

}