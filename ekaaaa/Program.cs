using System;

namespace ekzamen
{
    interface Lamp
    {
        static string type;
        static string manufacturer;
        static int power;
        static int count;
        void set_power(int new_power) { }
        void lamp_show_info() { }

    }
    interface Camera
    {
        static string type;
        static string manufacturer;
        static int sensitivity;
        void set_sensitivity() { }
        void camera_show_info() { }

    }
    class PhotoStudio : Camera
    {
        protected string type { get; set; }
        protected string manufacturer { get; set; }
        protected int sensitivity { get; set; }

        public PhotoStudio(string type, string manufacturer, int sensitivity)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.sensitivity = sensitivity;
        }

        public void remake(int a)
        {
            sensitivity = a;

        }
        public string lamp_show_info()
        {
            return "Тип: " + Lamp.type + "\nВиробник: " + Lamp.manufacturer + "\nПотужнiсть у люменах: " + Lamp.power + "СИ\nКiлькiсть освiтлювальних елементiв: " + Lamp.count;
        }
        public string camera_show_info()
        {
            return "Тип: " + type + "\nВиробник: " + manufacturer + "\nСвiтлочутливiсть: "  +sensitivity + "lux"; 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoStudio[] photostudio = {
                new PhotoStudio("Cannon 3000", "Україна, Київ", 3005),
                new PhotoStudio("Sony  NX0024", "Україна, Кам-Под", 2000),
            };
            Console.WriteLine("Лампи:");
            foreach (PhotoStudio str in photostudio)
            {

                Console.WriteLine($"{str.camera_show_info()}\n ");
            }
            Console.WriteLine("Камера яку ви хочете змiнити (0 або 1): ");
            int lampa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть нову свiточутливiсть: ");
            int a = Convert.ToInt32(Console.ReadLine());
            photostudio[lampa].remake(a);
            foreach (PhotoStudio str in photostudio)
            {

                Console.WriteLine($"{str.camera_show_info()}\n ");
            }



        }

    }
}