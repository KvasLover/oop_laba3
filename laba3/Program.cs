using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading.Tasks;

namespace laba3
{
    class House
    {
        public partial class Class
        {
            public void Meth()
            {
                Console.Write("\nHel");
            }
        }
        public partial class Class
        {
            public void Meth2()
            {
                Console.WriteLine("lo");
            }
        }
        const int const1 = 10; //константное поле
        
        readonly int id; //поле "readonly"
        public int amount = 6, floor;
        private int flat_number=25, year=2016;
        public string square = "Circle", street = "Kiseleva", building_type = "type";
        static int obj_amount=0;
        public int Floor
        {
            set
            {             
                floor = value;
            }
            get
            {
                return floor;
            }
        }
        public int Amount
        {
            private set
            {
                amount = value;
            }
            get
            {
                return amount;
            }
        } //тут set с ограниченным доступом
        private int Flat_number
        {
            set
            {
                flat_number = value;
            }
            get
            {
                return flat_number;
            }
        }
        private int Year
        {
            set
            {
                year = value;
            }
            get
            {
                return year;
            }
        }
        private string Square
        {
            set
            {
                square = value;
            }
            get
            {
                return square;
            }
        }
        private string Street
        {
            set
            {
                street = value;
            }
            get
            {
                return street;
            }
        }
        private string Building_type
        {
            set
            {
                building_type = value;
            }
            get
            {
                return building_type;
            }
        }

        public House(int id, int floor, string square, int amount, int flat_number, int year, string street, string building_type) //конструктор c параметром
        {
            obj_amount++;
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
            obj_amount++;
            id = 1645;
            floor = 5;
            square = "Pushkina";
            amount = 2;
            flat_number = 247;
            year = 2015;
            street = "Gromova";
            building_type = "block";
        }
        public House(int id, int floor) //конструктор по умолчанию
        {
            obj_amount++;
            this.id = id;
            this.floor = floor;
        }
        public void Info() //метод
        {
            Console.WriteLine($"{id} {floor} {square} {amount} {flat_number} {year} {street} {building_type}");
        }
        public void Age(ref int year, out int time1) //метод с ref и out
        {
            time1 = 2020 - year;
        }
        static House() //статический конструктор
        {
            Console.WriteLine("'In static constructor'");
        }
        private House(string a) //закрытый конструктор
        {
            a = "Closed construct";
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
            int res;
            house.Age(ref f,out res);
            Console.WriteLine($"Age of building: {res}");
            House house2 = new House();
            Console.WriteLine();
            house2.Info();
            House house3 = new House(3, 3);
            Console.WriteLine();
            house3.Info();

            house3.Floor = 1000;
            Console.WriteLine();
            house3.Info();
            //Console.WriteLine($"{house3.obj_amount}");

            House.Class var = new House.Class();
            var.Meth();
            var.Meth2();

            int n = 2, x = 0, y = x; //a)
            int min = 1, max = 2; //b)
            House[] Mas = new House[3];
            Mas[0]=house;
            Mas[1] = house2;
            Mas[2] = house3;
            for(int i=0;i<3;i++)
            {
                if (Mas[i].amount == n)
                    x++;
                if (Mas[i].amount == n && Mas[i].floor >= min && Mas[i].floor <= max)
                    y++;
            }
            Console.WriteLine($"Квартир, имеющих 2 комнаты: {x}");
            Console.WriteLine($"Квартир, имеющих 2 комнаты и находящиеся между 1 и 2 этажами включительно: {y}");

        }
    }
}
