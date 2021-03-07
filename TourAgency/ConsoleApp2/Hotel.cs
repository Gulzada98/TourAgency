using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Hotel
    {
        // Поля
        private int id_Hotel;  // код отеля
        private string country_name; // Страна
        private string city_name; // Город где находится сам ОТЕЛЬ
        private string hotel_name; // Название отеля
        private int klass; // пятизвездочный


                           // Конструктор
                           // Конструктор с 5 параметрами
        public Hotel(int id_Hotel, string country_name, string city_name, string hotel_name, int klass)
        {
            this.id_Hotel = id_Hotel;
            this.country_name = country_name;
            this.city_name = city_name;
            this.hotel_name = hotel_name;
            this.klass = klass;
        }
        // Свойства
        public int ID_Hotel { get => id_Hotel; set => id_Hotel = value; }
        public string Country_name { get => country_name; set => country_name = value; }
        public string City_name { get => city_name; set => city_name = value; }
        public string Hotel_name { get => hotel_name; set => hotel_name = value; }
        public int Klass { get => klass; set => klass = value; }
        public void show()
        {
            Console.WriteLine($"{id_Hotel}  {country_name}   {city_name}   {hotel_name}   {klass}"); Console.WriteLine();
        }
    }
}
