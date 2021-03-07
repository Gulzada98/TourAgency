using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class TUR
    {
        private int id;
        private int id_hotel;
        private string strana;
        private string gorod;
        private string name_hotel;
        private int klass_hotel;
        private string eat;
        private int price;

        public TUR(int id, int id_hotel, string strana, string gorod, string name_hotel, int price, string eat, int klass_hotel)
        {
            this.id = id;
            this.id_hotel = id_hotel;
            this.strana = strana;
            this.gorod = gorod;
            this.name_hotel = name_hotel;
            this.eat = eat;
            this.klass_hotel = klass_hotel;
            this.price = price;
        }

        public int ID { get => id; set => id = value; }
        public int ID_Hotel { get => id_hotel; set => id_hotel = value; }
        public string Strana { get => strana; set => strana = value; }
        public string Gorod { get => gorod; set => gorod = value; }
        public string Name_hotel { get => name_hotel; set => name_hotel = value; }
        public int Klass_hotel { get => klass_hotel; set => klass_hotel = value; }
        public string Eat { get => eat; set => eat = value; }
        public int Price { get => price; set => price = value; }



        public void show() { Console.WriteLine($"{id} {id_hotel} {strana} {gorod} {name_hotel} {klass_hotel} {eat} {price}"); Console.WriteLine(); }


    }
}
