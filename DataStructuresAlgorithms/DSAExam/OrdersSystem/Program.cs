using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace OrdersSystem
{
    public class Program
    {
        private static Dictionary<string, OrderedBag<Order>> ordersByConsumer = new Dictionary<string, OrderedBag<Order>>();
        private static OrderedDictionary<decimal, List<Order>> ordersByPrice = new OrderedDictionary<decimal, List<Order>>();

        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string inputString = Console.ReadLine();
                string command = inputString.Substring(0, inputString.IndexOf(' '));
                string[] info = inputString.Substring((inputString.IndexOf(' ') + 1), inputString.Length - 1 - inputString.IndexOf(' ')).Split(';');

                switch (command)
                {
                    case "AddOrder":
                        AddOrder(info);
                        break;

                    case "FindOrdersByConsumer":
                        FindOrdersByConsumer(info);
                        break;

                    case "FindOrdersByPriceRange":
                        FindOrdersByPriceRange(info);
                        break;

                    case "DeleteOrders":
                        DeleteOrders(info);
                        break;
                }
            }
        }

        private static void AddOrder(string[] info)
        {
            string name = info[0];
            decimal price = decimal.Parse(info[1]);
            string consumer = info[2];

            Order order = new Order(name, price, consumer);

            if (!ordersByConsumer.ContainsKey(consumer))
            {
                ordersByConsumer.Add(consumer, new OrderedBag<Order>());
            }

            ordersByConsumer[consumer].Add(order);

            if (!ordersByPrice.ContainsKey(order.Price))
            {
                ordersByPrice.Add(order.Price, new List<Order>());
            }

            ordersByPrice[order.Price].Add(order);

            Console.WriteLine("Order added");
        }

        private static void DeleteOrders(string[] info)
        {
            string consumerName = info[0];

            if (ordersByConsumer.ContainsKey(consumerName))
            {
                OrderedBag<Order> subset = ordersByConsumer[consumerName];
                foreach (Order set in subset)
                {
                    ordersByPrice[set.Price].Remove(set);
                }

                ordersByConsumer.Remove(consumerName);

                Console.WriteLine(subset.Count + " orders deleted");
            }
            else
            {
                Console.WriteLine("No orders found");
            }
        }

        private static void FindOrdersByPriceRange(string[] info)
        {
            decimal minPrice = decimal.Parse(info[0]);
            decimal maxPrice = decimal.Parse(info[1]);

            var ordersPriceRange = ordersByPrice.Range(minPrice, true, maxPrice, true).Values.ToArray();
            OrderedBag<Order> ordered = new OrderedBag<Order>();
            foreach (var price in ordersPriceRange)
            {
                foreach (var order in price)
                {
                    ordered.Add(order);
                }
            }

            if (ordered.Any())
            {
                foreach (var order in ordered)
                {
                    Console.WriteLine(order);
                }
            }
            else
            {
                Console.WriteLine("No orders found");
            }
        }

        private static void FindOrdersByConsumer(string[] info)
        {
            string consumer = info[0];
            if (!ordersByConsumer.ContainsKey(consumer))
            {
                Console.WriteLine("No orders found");
            }
            else
            {
                var byConsumer = ordersByConsumer[consumer];

                if (byConsumer.Count == 0)
                {
                    Console.WriteLine("No orders found");
                }
                else
                {
                    foreach (var item in byConsumer)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        public class Order : IComparable<Order>
        {
            public Order(string name, decimal price, string consumer)
            {
                this.Name = name;
                this.Price = price;
                this.Consumer = consumer;
            }

            public string Name { get; set; }

            public decimal Price { get; set; }

            public string Consumer { get; set; }

            public override string ToString()
            {
                string result = string.Format("{0};{1};{2:f2}", this.Name, this.Consumer, this.Price);
                return ("{" + result + "}");
            }

            public int CompareTo(Order other)
            {
                int result = this.Name.CompareTo(other.Name);

                return result;
            }
        }
    }
}
