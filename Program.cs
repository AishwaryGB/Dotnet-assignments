namespace Generic_Collections2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            Customer cust1 = new Customer();
            cust1.id = 14;
            cust1.name = "kkk";
            cust1.address = "jjj";

            Customer cust2 = new Customer();
            cust2.id = 15;
            cust2.name = "jjj";
            cust2.address = "llll";

            Customer cust3 = new Customer();
            cust3.id = 16;
            cust3.name = "ooo";
            cust3.address = "yyyy";

            List<Customer> list = new List<Customer>();
            list.Add(cust1);
            list.Add(cust2);
            list.Add(cust3);
            foreach (Customer cust in list)
            {
                Console.WriteLine($"Id: {cust.id}, Name: {cust.name}, Address: {cust.address}");

            }
        }
    }
        public class Customer
        {
            private int _Id;
            private string _Name;
            private string _Address;



            public int id
            {
                get { return _Id; }
                set { _Id = value; }
            }


            public String name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public String address
            {
                get { return _Address; }
                set { _Address = value; }
            }
        }
    }