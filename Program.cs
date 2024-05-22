
namespace C_8
{
    internal class Program : N
    {
        static void Main(string[] args)
        {
            //Делегаты, события, анонимные методы, лямбды и LINQ
            MyDelegate del = delegate (string msg)
            {
                Console.WriteLine(msg);
            };
            del("Hello from Delegate");

            //N n = new N();
            //n.TakeMsg("sad");
            //n.OnMsg += HandleMes("asd");   // эта хуйня не работает! Препод не осилил


            //LINQ



            //List<Person> list = new List<Person>();
            //new Person()
            //{
            //    Name = "Test",
            //    Age = 10
            //};
            //new Person()
            //{
            //    Name = "Test2",
            //    Age = 10
            //};
            //new Person()
            //{
            //    Name = "Test3",
            //    Age = 10
            //};
            //new Person()
            //{
            //    Name = "Test4",
            //    Age = 10
            //};
            //var result = from x in list  //query syntax
            //             select x.Name;
            //var result2 = from x in list
            //              where x.Age > 18 && x.Age == 25
            //              where x.Age < 30
            //              select x;
            //var result3 = from x in list
            //              group x by x.Name;   // сортировка

            //var result4 = list.Where(x => x.Age > 18).ToString();
            //var result5 = list.Select(x => x.Age * 2).ToList();
            
            //foreach ( var x in result )  
            //    Console.WriteLine($"{x.Name}"); 
            //OrderBy / OrderByDescending: Сортирует элементы в последовательности данных по возрастанию / убыванию

            //Distinct : Группирует элементы по определенному ключу

            //Reversr : Разворачивает порядлк элементов в последовательности

            //First / FirstOrDefault: Возвращает первый элемент из последовательности. First выбросит исключение 
            //eсли последовательность пуста, а FirstOrDefault  вернет значение по умолчанию

            List<Students> students = new List<Students>()
            {
                new Students{Name = "Alice", Grades = new List<int> { 1, 2, 3}},
                new Students{Name = "Bob", Grades = new List<int> { 4, 5, 6,}},
                new Students{Name = "Vasilii", Grades = new List<int> { 7, 8, 9}}
            };

            var sortedList = students.OrderByDescending(students => students.Grades.Average());
            Console.WriteLine("Отсортированный список: ");
            foreach (var student in sortedList) 
                Console.WriteLine($"{student.Name} : {student.Grades.Average()}");


            List<Order> orders = new List<Order>()
            {
                new Order{OrderID = 1, Customer = "Alice", Products = new List<OrderProduct>
                    {
                        new OrderProduct { ProductName = "Laptop", Price = 1000},
                        new OrderProduct { ProductName = "Mouse", Price = 10}
                    } 
                },
                new Order{OrderID = 2, Customer = "Vasilii", Products = new List<OrderProduct>
                    {
                        new OrderProduct { ProductName = "Keyboard", Price = 1000},
                        new OrderProduct { ProductName = "Pen", Price = 15}
                    }
                },
                new Order{OrderID = 3, Customer = "Petr", Products = new List<OrderProduct>
                    {
                        new OrderProduct { ProductName = "Keyboard", Price = 1000},
                        new OrderProduct { ProductName = "Сarpet", Price = 1000}
                    }
                }
            };

            var SumOrder = orders.Select(orders => new
            {
                OrderID = orders.OrderID,
                TotalSum = orders.Products.Sum(p => p.Price)
            });
            Console.WriteLine("Общая сумма заказа");
            foreach(var order in SumOrder)
            {
                Console.WriteLine($"{order.OrderID}, {order.TotalSum}");
            }

            Console.WriteLine("Сумма по всем зщаказам");                      
            var SumOrders = orders.SelectMany(p => p.Products).Sum(p=>p.Price);

            Console.WriteLine($"Повторяющиеся заказы");

            var duplicate = orders.SelectMany(o => o.Products).GroupBy(p => p.ProductName).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
            foreach(var order in duplicate)
            {
                Console.WriteLine(order);
            }

            Console.WriteLine("пОТРАТИЛ НАИБОЛЬШУЮ СУММУ");
            var TopSpender = orders.GroupBy(o => o.Customer).Select(g => new
            {
                Customer = g.Key,
                TotalSpent = g.SelectMany(o => o.Products).Sum(p => p.Price)
            }).OrderBy-Descending(c => c.)




            Console.WriteLine("Средняя сумма заказа");
            var average = orders.Select(o => o.Products.Sum(p => p.Price)).Average();







        }


    }
}
