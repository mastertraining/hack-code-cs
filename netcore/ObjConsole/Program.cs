using System;

namespace ObjConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Order
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderDetail[] Details { get; set; }
    }

    public class OrderDetail
    {        
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
    }
}
