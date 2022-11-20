namespace Module_6._3
{
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
            Bus bus = new Bus();
            bus.Load = 5;
            bus.PrintStatus();
    //        var department = GetCurrentDepartment();
    //    }

    //    static Department GetCurrentDepartment()
    //    {
    //        //Department department = new Department();
    //        //string nameCity = department?.City?.Name;
    //        //string typeCompany = department?.Company?.Type;
    //        //string nameCompany = department?.Company?.Name;
    //        //if (nameCity == "Санкт-Петербург" & typeCompany == "Банк")
    //        //{
    //        //   Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", nameCompany ?? "Неизвестная компания");
    //        //}
    //        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
    //        {
    //            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
    //        }
        }
    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            //Load = 10;
            if (Load == null) Console.WriteLine("Автобус пуст");
            else Console.WriteLine(Load);

        }
    }

    class square
    {
        public int side;

        public int S()
        {
            //int a = side;
            //int b = side;
            return side^2;
        }
    }

    class Circle
    {
        public int R;

        public Double S()
        {
            return R^2/2;
        }
    }

    class triangle
    {
        public int a;
        public int b;
        public int c;

        public Double S()
        {

        }
    }
}