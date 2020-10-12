using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading.Tasks;

namespace laba3
{
    class House
    {
        public int id, floor, amount=6, flat_number=25, year=2016;
        public string square="Circle", street="Kiseleva", building_type="type";
        public House(int id, int floor, string square, int amount, int flat_number, int year, string street, string building_type) //конструктор c параметром
        {
            this.id = id;
            this.floor = floor;
            this.square = square;
            this.amount = amount;
            this.flat_number = flat_number;
            this.year = year;
            this.street = street;
            this.building_type = building_type;
        }
        public House() //конструктор без параметров
        {
            id = 1645;
            floor = 5;
            square = "Pushkina";
            amount = 2;
            flat_number = 247;
            year = 2015;
            street = "Gromova";
            building_type = "block";
        }
        public House(int id, int floor) //конструктор по умоолчанию
        {
            this.id = id;
            this.floor = floor;
        }
        public void Info() //метод
        {
            Console.WriteLine($"{id} {floor} {square} {amount} {flat_number} {year} {street} {building_type}");
        }
        public int Age(int year)
        {
            int time1 = 2020 - year;
            return time1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter id: "); 
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter floor: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter square: ");
            string c = Console.ReadLine();
            Console.Write($"Enter amount: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter flat_number: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter expluatation year: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter street: ");
            string g = Console.ReadLine();
            Console.Write($"Enter building_type: ");
            string h = Console.ReadLine();
            House house = new House(a,b,c,d,e,f,g,h);
            house.Info();
            int res = house.Age(f);
            Console.WriteLine($"Age of building: {res}");
            House house2 = new House();
            Console.WriteLine();
            house2.Info();
            House house3 = new House(3, 3);
            Console.WriteLine();
            house3.Info();
        }
    }
}
