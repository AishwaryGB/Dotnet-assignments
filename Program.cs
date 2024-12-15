namespace oops_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region cmath add and adv obj
            //cmath cmath = new cmath();
            //Console.WriteLine("enter first number");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the sec number");
            //int y = Convert.ToInt32(Console.ReadLine());
            //int result = cmath.add(x, y);
            //Console.WriteLine("add" + result.ToString());

            //advmath advmath = new advmath();
            //Console.WriteLine(advmath.square(5));
            //Console.WriteLine(advmath.advclassadd(5, 5)); 
            #endregion
            demo2 dem=new demo2();
            dem.saybye();
            dem.sayhi();
        
        }
    }

    public class demo1
    {
        public virtual void sayhi()
        {
            Console.WriteLine("hello");
        }

        public virtual void saygreet()
        {
            Console.WriteLine("hello world");

        }

        public void saybye()
        {
            Console.WriteLine("bye");
        }

        
    }
    public class demo2 :demo1
    {
        public override void sayhi()
        {
            Console.WriteLine("hello aish");
        }
        public new void saybye()
        {
            Console.WriteLine("bye bye");
        }
    }
        public class cmath
        {
            private int _num1;
            public cmath()
            {

            }
            public cmath(int para1)
            {
                _num1 = para1;
            }
            public int add(int x, int y)
            {
                return x + y;

            }
            public int sub(int x, int y)
            {
                return x - y;
            }


        }
        public class advmath : cmath
        {
            private int num2;

            public advmath()
            {

            }
            public advmath(int num2, int para) : base(para)
            {
                this.num2 = num2;
            }
            public int square(int x)
            {
                return x * x;
            }
            public int sub(int x, int y, int p)
            {
                return x - y + p;
            }

            public int advclassadd(int x, int y)
            {
                int result = base.add(x, y);
                return result;
            }
        }
    }

