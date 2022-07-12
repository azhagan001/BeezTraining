using System;
class invoice
{
    public static void Main(String[] args)
    {
       
            int again = 0;
            String customerid;
            String name;
            int unit;
            
        do
        {
            Console.WriteLine(" Enter the ID :");
            customerid = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Enter the Name :");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" Enter the Unit :");
            unit = Convert.ToInt32(Console.ReadLine());
            var value = calculate(unit);
            Console.WriteLine("Customer ID :" + customerid);
            Console.WriteLine("Customer Name :" + name);
            Console.WriteLine("Customer Unit :");
            Console.WriteLine(value);
            Console.WriteLine(" If You Continue Press 1");
            again = Convert.ToInt32(Console.ReadLine());
        } while (again == 1);
    }
    public static double calculate(int unit)
    {
        double price=0.0;
        if (unit <= 199)
        {
           return price = 1.20;
        }
        else if (unit > 200 || unit <= 400)
        {
            return price = 1.50;
        }
        else if (unit > 400 || unit <= 600)
        {
            return price = 1.80;
        }
        else if (unit > 600)
        {
            return price = 2.00;
        }
        return price;
        
    }
}

