using System;

namespace ObjConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var order = new Order {
                CustomerName = "John Doe",
                OrderDate = DateTime.Now,
                Details = new OrderDetail[] {
                    new OrderDetail {
                        ProductId = "123",
                        ProductName = "Pen",
                        Quantity = 1,
                        UnitPrice = 50,
                    },
                    new OrderDetail {
                        ProductId = "223",
                        ProductName = "Pencil",
                        Quantity = 12,
                        UnitPrice = 5,
                    },
                },
            };
            foreach (var item in order.Details)
            {
                ReserveStock(item);
            }
            ShipOrder(order);
            IsLate(order);
            IsLate(order.OrderDate);
        }

        public static void ShipOrder(Order order) {}

        public static bool IsLate(Order order) {
            throw new NotImplementedException();
        }
        public static bool IsLate(DateTime orderDate) {
            throw new NotImplementedException();
        }

        public static void ReserveStock(OrderDetail item) {
            // TODO: Reserve stock for an item
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
