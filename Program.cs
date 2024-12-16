namespace oops_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMath obj = new CMath();
            int p = 10;
            int q = 20;
            Console.WriteLine("Before Swap : P ={0} , Q = {1}", p, q);

            //to pass arguments to a method there are two ways:
            // obj.Swap(p, q); //1. Pass by Value
            //2. Pass by refernce
            obj.swap(ref p, ref q);
            Console.WriteLine("After Swap : P ={0} , Q = {1}", p, q);

            //out parameter
            int sum, product;
            obj.Calculate(2, 3, out sum, out product);
            Console.WriteLine($"Sum :{sum} , Product:{product} ");
        }
    }
    public class CMath //Generic Class
    {
        public void swap(ref int x, ref int y) //Generic Method
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public void Calculate(int x, int y, out int sum, out int product)
        {



            sum = x + y;
            product = x * y;
        }
    }
}