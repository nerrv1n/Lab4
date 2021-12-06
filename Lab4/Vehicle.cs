using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{ 
    public class Vehicle 
    { 
        public virtual String GetInfo()
        {
            return "Я - ТС";
        }
    }
    public enum BikeType {Mountain, city, сhildren }
    public class Bike: Vehicle
    {
        public BikeType type = BikeType.city;
        public int rad_of_wheels = 20;

        public override string GetInfo()
        {
            var str ="Велосипед";
            str+="\r\n";
            switch(type)
            {
                case BikeType.city:
                    str += String.Format("Тип - {0}", "городской");
                    break;
                case BikeType.сhildren:
                    str += String.Format("Тип - {0}", "Детский");
                    break;
                case BikeType.Mountain:
                    str += String.Format("Тип - {0}", "Горный");
                    break;
            }
            str += "\r\n";
            str += String.Format("Радиус колёс = {0}", rad_of_wheels);
            return str;
        }

        private static int generate_rad(BikeType type)
        {
            var rnd = new Random();
            if(type == BikeType.Mountain)
                return rnd.Next(14, 25);
            else if(type == BikeType.city)
                return rnd.Next(13, 26);
            else
                return rnd.Next(10, 20);
        }

        public static Bike generate()
        {
            var rnd = new Random();

            BikeType tipe = (BikeType)rnd.Next(3);
            var rad_of_wheel = generate_rad(tipe);

            return new Bike
            {
                type = tipe,
                rad_of_wheels = rad_of_wheel
            };
        }
    }

    public enum CarType { Bus, Truck, SUV, passenger}
    public class Car : Vehicle
    {
        public CarType type = CarType.SUV;
        public double v_engine = 4;
        public int doors_num = 5;

        public override string GetInfo()
        {
            var str = "Автомобиль";
            str += "\r\n";
            switch (type)
            {
                case CarType.Bus:
                    str += String.Format("Тип - {0}", "автобус");
                    break;
                case CarType.Truck:
                    str += String.Format("Тип - {0}", "грузовик");
                    break;
                case CarType.SUV:
                    str += String.Format("Тип - {0}", "внедорожник");
                    break;
                case CarType.passenger:
                    str += String.Format("Тип - {0}", "легковой");
                    break;
            }
            str += "\r\n";
            str += String.Format("Объём двигателя = {0}", v_engine);
            str += "\r\n";
            str += String.Format("Количество дверей = {0}", doors_num);
            return str;
        }

        private static int generate_v(CarType type)
        {
            var rnd = new Random();
            if (type == CarType.Bus)
                return rnd.Next(3, 6);
            else if (type == CarType.passenger)
                return rnd.Next(1, 4);
            else if (type == CarType.SUV)
                return rnd.Next(3, 7);
            else
                return rnd.Next(4, 10);
        }

        private static int generate_doors_num(CarType type)
        {
            var rnd = new Random();
            if (type == CarType.Bus)
                return rnd.Next(2, 3);
            else if (type == CarType.passenger)
                return rnd.Next(3, 5);
            else if (type == CarType.SUV)
                return 5;
            else
                return 2;
        }

        public static Car generate()
        {
            var rnd = new Random();

            CarType tipe = (CarType)rnd.Next(3);
            var v = generate_v(tipe);
            var doors = generate_doors_num(tipe);

            return new Car
            {
                type = tipe,
                v_engine = v,
                doors_num = doors
            };
        }
    }
    public enum PlaneTypeOfEngines { React, TurboVint}
    public class Plane : Vehicle
    {
        public PlaneTypeOfEngines type = PlaneTypeOfEngines.React;
        public int max_height = 5000;

        public override string GetInfo()
        {
            var str = "Самолёе";
            str += "\r\n";
            switch (type)
            {
                case PlaneTypeOfEngines.React:
                    str += String.Format("Тип двигателя - {0}", "реактивынй");
                    break;
                case PlaneTypeOfEngines.TurboVint:
                    str += String.Format("Тип двигателя - {0}", "турбо-винтовой");
                    break;
            }
            str += "\r\n";
            str += String.Format("Максимальная высота полёта = {0}", max_height);
            return str;
        }

        public static Plane generate()
        {
            var rnd = new Random();

            PlaneTypeOfEngines tipe = (PlaneTypeOfEngines)rnd.Next(1);
            return new Plane
            {
                type = tipe,
                max_height = 100 * rnd.Next(20, 60)
            };
        }
    }
}