using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp2
{
    class ALL_QUERY
    {   
    int AAA = 5;
    int AA = 1;
    int A = 1;
        List<Klient> klient = new List<Klient>(20);
        List<Hotel> hotel = new List<Hotel>(20);
        List<Turoperator> turoperator = new List<Turoperator>(20);
        List<TUR> tur = new List<TUR>(20);
        List<Zakaz> zakaz = new List<Zakaz>(20);
        public void Load_Klient()
        {
            klient.Clear();
            StreamReader sr;
            sr = new StreamReader("Klients.txt");
            int count = System.IO.File.ReadAllLines("Klients.txt").Length; // 6
            string[] str = new string[count];

            for (int i = 0; i < count; i++)
            {
                str[i] = sr.ReadLine();
            }

            string[] d = new string[count];
            for (int i = 0; i < count; i++)
            {
                d = str[i].Split(' ');
                int skidka = Convert.ToInt32(d[7]);
                klient.Add(new Klient(d[0], d[1], d[2], d[3], d[4], d[5], d[6], skidka));

            }
            sr.Close();
        }
        public void Show_Klient()
        {
            foreach (Klient s in klient)
                s.show();
        }
        public void Add_Klient()
        {
            string ID = "";
            string name = "";
            string mesto = "";
            string number = "";
            string email = "";
            string god = "";
            string deti = "";
            string skidka = "";

            Console.WriteLine("введите ИИН");
            ID = Console.ReadLine();
            Console.WriteLine("введите F_I_O через нижний пробел");
            name = Console.ReadLine();
            Console.WriteLine("введите место прописки");
            mesto = Console.ReadLine();
            Console.WriteLine("введите номер телефона");
            number = Console.ReadLine();
            Console.WriteLine("введите емайл");
            email = Console.ReadLine();
            Console.WriteLine("введите год рождение");
            god = Console.ReadLine();
            Console.WriteLine("есть ли у вас дети?");
            deti = Console.ReadLine();
            Console.WriteLine("введите свою скидку");
            skidka = Console.ReadLine();

            int discount = Convert.ToInt32(skidka);
            klient.Add(new Klient(ID, name, mesto, number, email, god, deti, discount));

            File.Delete("Klients.txt");
            StreamWriter writer = new StreamWriter("Klients.txt");
            int count = 0;
            string ss = "";
            foreach (Klient s in klient)
            {
                ss += s.ID + " " + s.FIO + " " + s.Adress + " " + s.Number + " " + s.Email + " " + s.DataRozhdenie + " " + s.Deti + " " + s.Skidka;
                writer.Write(ss);
                if (count != klient.Count - 1) writer.WriteLine();
                ss = "";
                count++;
            }
            writer.Close();
        }
        public void Update_Klient_Info(string str)
        {
            Console.WriteLine("What do you want to change? If it is address -> click 1 || If it is phone -> click 2 || If it is email -> click 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new info");
            string tmp = Console.ReadLine();
            if (choice == 1)
            {
                foreach (Klient s in klient)
                    if (str == s.Adress)
                        s.Adress = tmp;
            }
            else if (choice == 2)
            {
                foreach (Klient s in klient)
                    if (str == s.Number)
                        s.Number = tmp;
            }
            else if (choice == 3)
            {
                foreach (Klient s in klient)
                    if (str == s.Email)
                        s.Email = tmp;
            }
            File.Delete("Klients.txt");
            StreamWriter writer = new StreamWriter("Klients.txt");
            int count = 0;
            string ss = "";
            foreach (Klient s in klient)
            {
                ss += s.ID + " " + s.FIO + " " + s.Adress + " " + s.Number + " " + s.Email + " " + s.DataRozhdenie + " " + s.Deti + " " + s.Skidka;
                writer.Write(ss);
                if (count != klient.Count - 1) writer.WriteLine();
                ss = "";
                count++;
            }
            writer.Close();
        }
        public void Delete_Klient_Info(string tmp)
        {
            string ss = "";

            File.Delete("Klients.txt");
            StreamWriter writer = new StreamWriter("Klients.txt");
            int count = 0;

            foreach (Klient s in klient)
            {
                if (s.ID != tmp)
                {
                    ss += s.ID + " " + s.FIO + " " + s.Adress + " " + s.Number + " " + s.Email + " " + s.DataRozhdenie + " " + s.Deti + " " + s.Skidka;
                    writer.Write(ss);
                    if (count != klient.Count - 1) writer.WriteLine();
                    ss = "";
                    count++;
                }
            }

            writer.Close();
        }
        public void Search_Klient_Info(string tmp)
        {
            Console.WriteLine("If you want to find by IIN -> click 1 || If you want to find by FIO -> click 2 ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                foreach (Klient s in klient)
                    if (s.ID == tmp)
                        s.show();
            }
            else if (choice == 2)
            {
                foreach (Klient s in klient)
                    if (s.FIO == tmp)
                        s.show();
            }
        }

        public void Load_hotels()
        {
            StreamReader sr;
            sr = new StreamReader("Hotels.txt");
            int count = System.IO.File.ReadAllLines("Hotels.txt").Length; // 5
            string[] str = new string[count];

            for (int i = 0; i < count; i++)
            {
                str[i] = sr.ReadLine();
            }
            string[] d = new string[count];
            for (int i = 0; i < count; i++)
            {
                d = str[i].Split(' ');
                int id = Convert.ToInt32(d[0]);
                int klass = Convert.ToInt32(d[4]);
                hotel.Add(new Hotel(id, d[1], d[2], d[3], klass));
            }
            sr.Close();
        }
        public void Show_Hotels()
        {
            foreach (Hotel s in hotel)
                s.show();
        }
        public void Update_Hotel_Info(string str)
        {
            Console.WriteLine("Enter new info");
            string tmp = Console.ReadLine();

            foreach (Hotel s in hotel)
                if (s.Hotel_name == str)
                    s.Hotel_name = tmp;

            File.Delete("Hotels.txt");
            StreamWriter writer = new StreamWriter("Hotels.txt");
            int count = 0;
            string ss = "";
            foreach (Hotel s in hotel)
            {
                ss += s.ID_Hotel + " " + s.Country_name + " " + s.City_name + " " + s.Hotel_name + " " + s.Klass;
                writer.Write(ss);
                if (count != hotel.Count - 1) writer.WriteLine();
                ss = "";
                count++;
            }
            writer.Close();
        }
        public void Delete_Hotel_Info(int tmp)
        {
            File.Delete("Hotels.txt");
            StreamWriter writer = new StreamWriter("Hotels.txt");
            int count = 0;
            string ss = "";
            foreach (Hotel s in hotel)
            {
                if (tmp != s.ID_Hotel)
                {
                    ss += s.ID_Hotel + " " + s.Country_name + " " + s.City_name + " " + s.Hotel_name + " " + s.Klass;
                    writer.Write(ss);
                    if (count != hotel.Count - 1) writer.WriteLine();
                    ss = "";
                    count++;
                }
            }
            writer.Close();
        }
        public void Search_Hotel_Info(string tmp)
        {
            Console.WriteLine("If you want to find by ID_Hotel -> click 1 || If you want to find by Country -> click 2 ");
            Console.WriteLine("If you want to find by City -> click 3 || If you want to find by Hotel_name -> click 4 ");
            Console.WriteLine("If you want to find by Klass -> click 5");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                foreach (Hotel s in hotel)
                    if (s.ID_Hotel == Convert.ToInt32(tmp))
                        s.show();
            }
            else if (choice == 2)
            {
                foreach (Hotel s in hotel)
                    if (s.Country_name == tmp)
                        s.show();
            }
            else if (choice == 3)
            {
                foreach (Hotel s in hotel)
                    if (s.City_name == tmp)
                        s.show();
            }
            else if (choice == 4)
            {
                foreach (Hotel s in hotel)
                    if (s.Hotel_name == tmp)
                        s.show();
            }
            else if (choice == 5)
            {
                foreach (Hotel s in hotel)
                    if (s.Klass == Convert.ToInt32(tmp))
                        s.show();
            }
        }
        public void Add_Hotels()
        {
            int id_Hotel;  // код отеля
            string country_name; // Страна
            string city_name; // Город где находится сам ОТЕЛЬ
            string hotel_name; // Название отеля
            int klass; // пятизвездочный

            Console.WriteLine("введите айди отея");
            id_Hotel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите страну отеля");
            country_name = Console.ReadLine();
            Console.WriteLine("введите город отеля ");
            city_name = Console.ReadLine();
            Console.WriteLine("введите имя отеля");
            hotel_name = Console.ReadLine();
            Console.WriteLine("введите класс отеля");
            klass = Convert.ToInt32(Console.ReadLine());

            hotel.Add(new Hotel(id_Hotel, country_name, city_name, hotel_name, klass));

            File.Delete("Hotels.txt");
            StreamWriter writer = new StreamWriter("Hotels.txt");
            int count = 0;
            string ss = "";
            foreach (Hotel s in hotel)
            {
                ss += s.ID_Hotel + " " + s.Country_name + " " + s.City_name + " " + s.Hotel_name + " " + s.Klass;
                writer.Write(ss);
                if (count != hotel.Count - 1) writer.WriteLine();
                ss = "";
                count++;
            }
            writer.Close();
        }

        public void Load_Turoperators()
        {
            turoperator.Clear();
            StreamReader sr;
            sr = new StreamReader("turoperator.txt");
            int count = System.IO.File.ReadAllLines("turoperator.txt").Length; // 5
            string[] str = new string[count];

            for (int i = 0; i < count; i++)
            {
                str[i] = sr.ReadLine();
            }
            string[] d = new string[count];
            for (int i = 0; i < count; i++)
            {
                d = str[i].Split(' ');
                int id = Convert.ToInt32(d[0]);
                turoperator.Add(new Turoperator(id, d[1], d[2], d[3], d[4]));
            }
            sr.Close();
        }
        public void Show_Turoperators()
        {
            foreach (Turoperator s in turoperator)
                s.show();
        }
        public void Update_Turoperator_Info(string str)
        {
            Console.WriteLine("What do you want to change? If it is address -> click 1 || If it is phone -> click 2 || If it is email -> click 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new info");
            string tmp = Console.ReadLine();

            if (choice == 1)
            {
                foreach (Turoperator s in turoperator)
                    if (s.Adress == str)
                        s.Adress = tmp;
            }
            else if (choice == 2)
            {
                foreach (Turoperator s in turoperator)
                    if (s.Number == str)
                        s.Number = tmp;
            }
            else if (choice == 3)
            {
                foreach (Turoperator s in turoperator)
                    if (s.Email == str)
                        s.Email = tmp;
            }

            File.Delete("turoperator.txt");
            StreamWriter writer = new StreamWriter("turoperator.txt");
            int count = 0;
            string ss = "";
            foreach (Turoperator s in turoperator)
            {
                ss += s.ID + " " + s.Name + " " + s.Adress + " " + s.Number + " " + s.Email;
                writer.Write(ss);
                if (count != turoperator.Count - 1) writer.WriteLine();
                ss = "";
                count++;
            }
            writer.Close();
        }
        public void Delete_Turoperator_Info(int tmp)
        {
            File.Delete("turoperator.txt");
            StreamWriter writer = new StreamWriter("turoperator.txt");
            int count = 0;
            string ss = "";
            foreach (Turoperator s in turoperator)
            {
                if (tmp != s.ID)
                {
                    ss += s.ID + " " + s.Name + " " + s.Adress + " " + s.Number + " " + s.Email;
                    writer.Write(ss);
                    if (count != turoperator.Count - 1) writer.WriteLine();
                    ss = "";
                    count++;
                }
            }
            writer.Close();
        }
        public void Search_TurOperator_Info(string tmp)
        {
            Console.WriteLine("If you want to find by ID_turoperator -> click 1 || If you want to find by Name -> click 2 ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                foreach (Turoperator s in turoperator)
                    if (s.ID == (Convert.ToInt32(tmp)))
                        s.show();
            }
            else if (choice == 2)
            {
                    foreach (Turoperator s in turoperator)
                        if (s.Name == tmp)
                            s.show();
            }
        }

        public void Load_TUR()
        {
            tur.Clear();
            StreamReader sr = new StreamReader("TUR.txt");
            int count = System.IO.File.ReadAllLines("TUR.txt").Length;
            string[] str = new string[count];
            string[] d = new string[count];

            for (int i = 0; i < count; i++)
            {
                str[i] = sr.ReadLine();
            }

            for (int i = 0; i < count; i++)
            {
                d = str[i].Split(' ');
                int id_tur = Convert.ToInt32(d[0]);
                int id_hotel = Convert.ToInt32(d[1]);
                int price = Convert.ToInt32(d[5]);
                int klass = Convert.ToInt32(d[7]);
                tur.Add(new TUR(id_tur, id_hotel, d[2], d[3], d[4], price, d[6], klass));
            }
            sr.Close();
        }
        public void Show_TUR()
        {
            foreach (TUR s in tur)
                s.show();
        }
        public void Add_Tur()
        {
            string pit;
            int id_hot;
            int price;

                Console.WriteLine("Enter id_hotel");
                foreach (Hotel s in hotel)
                    s.show();

                id_hot = Convert.ToInt32(Console.ReadLine());
                for (int j = 0; j < 5; j++)
                {
                    if (id_hot == hotel[j].ID_Hotel)
                    {
                        Console.WriteLine("Enter price and pitanie");
                        price = Convert.ToInt32(Console.ReadLine());
                        pit = Console.ReadLine();
                        tur.Add(new TUR(AAA++, hotel[j].ID_Hotel, hotel[j].Country_name,
                            hotel[j].City_name, hotel[j].Hotel_name, price, pit, hotel[j].Klass));
                    }
                }

                File.Delete("TUR.txt");
                StreamWriter writer = new StreamWriter("TUR.txt");
                int count = 0;
                string ss = "";
                foreach (TUR s in tur)
                {
                    ss += s.ID + " " + s.ID_Hotel + " " + s.Strana + " " + s.Gorod + " " + s.Name_hotel + " " + s.Price + " " + s.Eat + " " + s.Klass_hotel;
                    writer.Write(ss);
                    if (count != tur.Count - 1) writer.WriteLine();
                    ss = "";
                    count++;
                }
                writer.Close();
            
        }
        public void Delete_TUR_Info(int tmp)
        {
            File.Delete("TUR.txt");
            StreamWriter writer = new StreamWriter("TUR.txt");
            int count = 0;
            string ss = "";
            foreach (TUR s in tur)
            {
                if (s.ID != tmp)
                {
                    ss += s.ID + " " + s.ID_Hotel + " " + s.Strana + " " + s.Gorod + " " + s.Name_hotel + " " + s.Price + " " + s.Eat + " " + s.Klass_hotel;
                    writer.Write(ss);
                    if (count != tur.Count - 1) writer.WriteLine();
                    ss = "";
                    count++;
                }
            }
            writer.Close();
        }
        public void Search_TUR_Info(int tmp)
        {
            Console.WriteLine("If you want to find by ID_TUR -> click 1 || If you want to find by Price -> click 2 ");
            Console.WriteLine("If you want to find by Hotel_Klass -> click 3");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                foreach (TUR s in tur)
                    if (s.ID == tmp)
                        s.show();
            }
            else if (choice == 2)
            { 
                foreach (TUR s in tur)
                    if (s.Price == tmp)
                        s.show();
            }
            else if (choice == 3)
            {
                foreach (TUR s in tur)
                    if (s.Klass_hotel == tmp)
                        s.show();
            }
        }

        public void Load_Zakaz()
        {
            zakaz.Clear();

            StreamReader sr = new StreamReader("zakaz.txt");

            while (!sr.EndOfStream)
            {
                string[,] d = new string[20, 100];
                string str = sr.ReadLine();
                int size = str.Length;
                int index = 0;
                int index2 = 0;

                for (int i = 0; i < size; i++)
                {
                    if (str[i] == ' ')
                    {
                        index++;
                        index2 = 0;
                        continue;
                    }
                    d[index, index2++] = str[i].ToString();
                }
                string id_klient = "";
                string id_zakaz = "";
                string fio = "";
                string from_city_fly = ""; //город вылета
                string date_fly = ""; // 12.02.19
                string reic_nom = "";// номер рейса
                string id_turoper = "";
                string turoperName = "";
                string country = "";
                string city = "";
                string id_hotel = "";
                string hottel = ""; //+
                string pit = "";
                string came_time = ""; // 12:35:10
                string price = "";
                string skidka = "";
                for (int i = 0; i < 20; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (i == 0) id_zakaz += d[i, j];
                        if (i == 1) id_klient += d[i, j];
                        if (i == 2) fio += d[i, j];
                        if (i == 3) from_city_fly += d[i, j];
                        if (i == 4) date_fly += d[i, j];
                        if (i == 5) reic_nom += d[i, j];
                        if (i == 6) id_turoper += d[i, j];
                        if (i == 7) turoperName += d[i, j];
                        if (i == 8) country += d[i, j];
                        if (i == 9) city += d[i, j];
                        if (i == 10) id_hotel += d[i, j];
                        if (i == 11) hottel += d[i, j];
                        if (i == 12) pit += d[i, j];
                        if (i == 13) came_time += d[i, j];
                        if (i == 14) price += d[i, j];
                        if (i == 15) skidka += d[i, j];
                    }
                }
                int id_h = Convert.ToInt32(id_hotel);
                int id_z = Convert.ToInt32(id_zakaz);
                int id_n = Convert.ToInt32(reic_nom);
                int id_t = Convert.ToInt32(id_turoper);
                int prs = Convert.ToInt32(price);
                int discount = Convert.ToInt32(skidka);

                 zakaz.Add(new Zakaz(id_z, id_klient, fio, from_city_fly, date_fly, id_n, id_t, turoperName, country, city, id_h, hottel, pit, came_time, prs, discount));
            }
                sr.Close();
        }
        public void Add_Zakaz()
        {
            int fix1 = 0;
            int fix2 = 0;
            int fix3 = 0;
            string id_klient;
            string from_city_fly;
            string date_fly;
            int reic_num;
            int id_TUR;
            int id_turop;
            string came_time;

            foreach (Klient s in klient)
                s.show();
            Console.WriteLine("Enter id_klient");
                id_klient = Console.ReadLine();

            foreach (TUR s in tur)
                s.show();
            Console.WriteLine("Enter id_tur");
                id_TUR = Convert.ToInt32(Console.ReadLine());

            foreach (Turoperator s in turoperator)
                s.show();
            Console.WriteLine("Enter id_turop");
                id_turop = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < klient.Count; i++)
                {
                    if (id_klient == klient[i].ID)
                    {
                        fix1 = i;
                    }
                }
                for (int j = 0; j < tur.Count; j++)
                {
                if (id_TUR == tur[j].ID)
                    {
                        fix2 = j;
                    }
                }
                for (int k = 0; k < turoperator.Count; k++)
                 {
                if (id_turop == turoperator[k].ID)
                    {
                        fix3 = k;
                    }
                }
                Console.WriteLine("Enter from_city_fly, date_fly, reic_number and came time ");
                from_city_fly = Console.ReadLine();
                date_fly = Console.ReadLine();
                reic_num = Convert.ToInt32(Console.ReadLine());
                came_time = Console.ReadLine();
                zakaz.Add(new Zakaz(AA++, klient[fix1].ID, klient[fix1].FIO, from_city_fly, date_fly, reic_num, turoperator[fix3].ID, turoperator[fix3].Name,
                    tur[fix2].Strana, tur[fix2].Gorod, tur[fix2].ID_Hotel, tur[fix2].Name_hotel, tur[fix2].Eat, came_time,
                    ((tur[fix2].Price * klient[fix1].Skidka) / 100), klient[fix1].Skidka));


            
            File.Delete("zakaz.txt");
            StreamWriter writer = new StreamWriter("zakaz.txt");
            int count = 0;
            string ss = "";
            foreach (Zakaz s in zakaz)
            {
                ss += s.Id_zakaz + " " + s.ID_Klient + " " + s.FIO + " " + s.From_city_fly + " " + s.Date_fly + " " + s.Reic_nom + " " + s.Id_turoper + " " + s.TuroperName + " " + s.Country + " " + s.City + " " + s.Id_hotel + " " + s.Hottel + " " + s.PIT + " " + s.Came_time + " " + s.Price + " " + s.Skidka;

                writer.Write(ss);

                if (count != zakaz.Count - 1) 
                    writer.WriteLine();

                ss = "";

                count++;
            }
            writer.Close();
        }
        public void Show_Zakaz()
        {
            foreach (Zakaz s in zakaz)
                s.show();
        }
        public void Delete_ZAKAZ_Info(int tmp)
        {
            File.Delete("zakaz.txt");
            StreamWriter writer = new StreamWriter("zakaz.txt");
            int count = 0;
            string ss = "";
            foreach (Zakaz s in zakaz)
            {
                if (s.Id_zakaz != tmp)
                {
                    ss += s.Id_zakaz + " " + s.ID_Klient + " " + s.FIO + " " + s.From_city_fly + " " + s.Date_fly + " " + s.Reic_nom + " " + s.Id_turoper + " " + s.TuroperName + " " + s.Country + " " + s.City + " " + s.Id_hotel + " " + s.Hottel + " " + s.PIT + " " + s.Came_time + " " + s.Price + " " + s.Skidka;

                    writer.Write(ss);

                    if (count != zakaz.Count - 1)
                        writer.WriteLine();

                    ss = "";

                    count++;
                }
            }
            writer.Close();
        }
        public void Search_ZAKAZ_Info(int tmp)
        {
            foreach (Zakaz s in zakaz)
                if (s.Id_zakaz == tmp) s.show();
        }


    }
}
