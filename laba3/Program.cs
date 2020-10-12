using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading.Tasks;

namespace laba3
{
    class House
    {
        public int id, floor, amount, flat_number, time;
        public string square, street, building_type;
        public House(int id, int floor, string square, int amount, int flat_number, int time, string street, string building_type) //конструктор c параметром
        {
            this.id = id;
            this.floor = floor;
            this.square = square;
            this.amount = amount;
            this.flat_number = flat_number;
            this.time = time;
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
            time = 2015;

        }
        public void Info() //метод
        {
            Console.WriteLine($"{id} {floor} {square} {amount} {flat_number} {time} {street} {building_type}");
        }
        public int Age(int time)
        {
            int time1 = 2020 - time;
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
            Console.Write($"Enter expluatation time: ");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter street: ");
            string g = Console.ReadLine();
            Console.Write($"Enter building_type: ");
            string h = Console.ReadLine();
            House house = new House(a,b,c,d,e,f,g,h);
            house.Info();
            int res = house.Age(f);
            Console.WriteLine($"Age of building: {res}");
        }
    }
}
