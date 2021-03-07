using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Zakaz
    {
        private string id_klient;
        private int id_zakaz;
        private string fio;
        private int id_turoper;
        private int id_hotel;
        private int reic_nom;// номер рейса
        private string turoperName;
        private string country;
        private string city;
        private string hottel; //+
        private string pit;
        private string from_city_fly; //город вылета
        private string date_fly; // 12.02.19
        private string came_time; // 12:35:10
        private int price;
        private int skidka;
        public string ID_Klient { get => id_klient; set => id_klient = value; }
        public int Id_zakaz { get => id_zakaz; set => id_zakaz = value; }
        public string FIO { get => fio; set => fio = value; }
        public int Id_turoper { get => id_turoper; set => id_turoper = value; }
        public int Id_hotel { get => id_hotel; set => id_hotel = value; }
        public int Reic_nom { get => reic_nom; set => reic_nom = value; }
        public string TuroperName { get => turoperName; set => turoperName = value; }
        public string Country { get => country; set => country = value; }
        public string City { get => city; set => city = value; }
        public string Hottel { get => hottel; set => hottel = value; }
        public string PIT { get => pit; set => pit = value; }
        public string From_city_fly { get => from_city_fly; set => from_city_fly = value; }
        public string Date_fly { get => date_fly; set => date_fly = value; }
        public string Came_time { get => came_time; set => came_time = value; }
        public int Price { get => price; set => price = value; }
        public int Skidka { get => skidka; set => skidka = value; }


      
        public Zakaz(int id_zakaz, string id_klient, string fio, string from_city_fly, string date_fly,
            int reic_nom, int id_turoper, string turoperName, string country, string city, int id_hotel,
            string hottel, string pit, string came_time, int price, int skidka)
        {
            this.id_zakaz = id_zakaz; //+
            this.id_klient = id_klient; //+
            this.fio = fio; //+
            this.from_city_fly = from_city_fly; //+
            this.date_fly = date_fly; //+
            this.reic_nom = reic_nom;//+
            this.id_turoper = id_turoper; //+               
            this.turoperName = turoperName; //+
            this.country = country; //+
            this.city = city; //+
            this.id_hotel = id_hotel; //+
            this.hottel = hottel; //+
            this.pit = pit; //+
            this.came_time = came_time; //+
            this.price = price; //+
            this.skidka = skidka; //+
        }

       public void show()
        {
        Console.WriteLine($"{id_zakaz}  {id_klient}   {fio}    {from_city_fly}   {date_fly}   {reic_nom}  {id_turoper}  {turoperName}");
        Console.WriteLine($"{country}  {city}   {id_hotel}    {hottel}   {pit}   {came_time}  {price}  {skidka}");
   
        }

    }
}
