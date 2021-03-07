using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Klient
    {
        private string id;
        private string fio;
        private string adress;
        private string number;
        private string email;
        private string dataRozhdenie;
        private string deti;
        private int skidka;
        public Klient(string id, string fio, string adress, string number, string email, string dataRozhdenie, string deti, int skidka)
        {
            this.id = id;
            this.fio = fio;
            this.adress = adress;
            this.number = number;
            this.email = email;
            this.dataRozhdenie = dataRozhdenie;
            this.deti = deti;
            this.skidka = skidka;
        }

        public string FIO { get => fio; set => fio = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
        public string DataRozhdenie { get => dataRozhdenie; set => dataRozhdenie = value; }
        public string Deti { get => deti; set => deti = value; }
        public string ID { get => id; set => id = value; }
        public int Skidka { get => skidka; set => skidka = value; }

        public void show() { Console.WriteLine($"{id} {FIO} {adress} {number} {email} {dataRozhdenie} {deti} {skidka}");Console.WriteLine(); }

    }
}
