using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Turoperator
    {
        private int id;
        private string name;
        private string adress;
        private string number;
        private string email;
        public Turoperator(int id, string name, string adress, string number, string email)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.number = number;
            this.email = email;
        }
        public int   ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
        public void show()
        {
            Console.WriteLine($"{id}  {name}   {adress}       {number}     {email}");
        }
    }
}
