using System.Security.Principal;

namespace Module_6._2
{


    class Pen
    {
        //Поля класса
        public string color;
        public int cost;

        //Конструктор 1
        public Pen()
        {
            color = "Черный";
            cost = 100; 
        }

        //Конструктор 2
        public Pen(string penColor, int penCost)
        {
            color=penColor;
            cost = penCost;
        }
    }

    //класс прямоугольник
    class Rectangle
    {
        //стороны
        public int a;
        public int b;

        //метод обозначающий расчет площади
        public int Square()
        {
            return a * b;
        }

        //конструктор 1
        public Rectangle()
        {
            a = 6;
            b = 4 ;
        }

        //конструктор 2
        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        //конструктор 3
        public Rectangle(int side)
        {
            a = side;
            b = side;
        }
    }

    class Company
    {
        public string Type;
        public string Name;
    }

    class Department
    {
        public Company Company;
        public City City;
    }

    class City
    {
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var department = GetCurrentDepartment();
        }

        static Department GetCurrentDepartment()
        {
            // logic

        }
    }


}