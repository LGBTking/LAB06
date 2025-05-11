using System;
using ClassLibrary; 

class Program
{
    static void Main()
    {
        Phone[] arrPhones;
        Console.Write("Введiть кiлькiсть телефонiв: ");
        int cntPhones = int.Parse(Console.ReadLine());
        arrPhones = new Phone[cntPhones];
        for (int i = 0; i < cntPhones; i++)
        {
            Console.WriteLine($"\nТелефон #{i + 1}:");
            Console.Write("Введiть бренд: ");
            string brand = Console.ReadLine();
            Console.Write("Введiть модель: ");
            string model = Console.ReadLine();
            Console.Write("Введiть розмiр екрана (дюйми): ");
            double screenSize = double.Parse(Console.ReadLine());
            Console.Write("Введiть ємнiсть батареї (мАг): ");
            int battery = int.Parse(Console.ReadLine());
            Console.Write("Введiть обсяг RAM (ГБ): ");
            int ram = int.Parse(Console.ReadLine());
            Console.Write("Введiть обсяг пам'ятi (ГБ): ");
            int storage = int.Parse(Console.ReadLine());
            Console.Write("Введiть цiну (грн): ");
            decimal price = decimal.Parse(Console.ReadLine());

            Phone phone = new Phone();
            phone.Brand = brand;
            phone.Model = model;
            phone.ScreenSize = screenSize;
            phone.BatteryCapacity = battery;
            phone.RAM = ram;
            phone.Storage = storage;
            phone.Price = price;
            arrPhones[i] = phone;
        }

        foreach (Phone p in arrPhones)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Iнформацiя про телефон: " + p.Union());
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Бренд: " + p.Brand);
            Console.WriteLine("Модель: " + p.Model);
            Console.WriteLine("Розмiр екрана: " + p.ScreenSize.ToString("0.0") + " дюймiв");
            Console.WriteLine("Батарея: " + p.BatteryCapacity + " мАг");
            Console.WriteLine("RAM: " + p.RAM + " ГБ");
            Console.WriteLine("Пам'ять: " + p.Storage + " ГБ");
            Console.WriteLine("Цiна: " + p.Price.ToString("0.00") + " грн");
        }
        Console.ReadKey();
    }
}