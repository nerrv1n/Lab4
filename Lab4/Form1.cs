using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        List<Vehicle> VehiclesList = new List<Vehicle>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void ShowInfo()
        {
            int bike_counter = 0;
            int car_counter = 0;
            int plane_counter = 0;

            foreach(var Vehicle in this.VehiclesList)
            {
                if(Vehicle is Bike)
                {
                    bike_counter += 1;
                }
                if (Vehicle is Car)
                {
                    car_counter += 1;
                }
                if (Vehicle is Plane)
                {
                    plane_counter += 1;
                }
            }

            txtInfo.Text = "Велосипеды\tАвто\tСамолёты";
            txtInfo.Text += "\r\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t{2}", bike_counter, car_counter, plane_counter);
        }

        private void btnRefill_Click(object sender, EventArgs e) // кнопка "Перезаполнить"
        {
            this.VehiclesList.Clear();
            var rnd = new Random();
            var temp = rnd.Next(0, 2);
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то велик
                        this.VehiclesList.Add(Bike.generate());
                        break;
                    case 1: // если 1 то машина
                        this.VehiclesList.Add(Car.generate());
                        break;
                    case 2: // если 2 то самолёт
                        this.VehiclesList.Add(Plane.generate());
                        break;
                }
            }
            ShowInfo();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if(this.VehiclesList.Count==0)
            {
                RichTxtInfo.Text = "Автомат пуст!";
                return;
            }

            var Vehicle = this.VehiclesList[0];
            this.VehiclesList.RemoveAt(0);

            RichTxtInfo.Text = Vehicle.GetInfo(); 
            ShowInfo();
        }
    }
}
