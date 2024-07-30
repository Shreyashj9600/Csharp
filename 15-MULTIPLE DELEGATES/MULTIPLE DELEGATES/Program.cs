namespace MULTIPLE_DELEGATES
{
    internal class Program
    {
        public delegate void Show_DG();
        public delegate void calc(int a);
        public static void Show()
        {
            Console.WriteLine("this is a show method ! ..");
        }
        public static void Square(int num)
        {
            int square = num * num;
            Console.WriteLine("The square of {0} is {1}" , num , square);
        }
        public static void Cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("the cube of {0} is {1}", num , cube);
        }
        static void Main(string[] args)
        {
                Show_DG obj = new Show_DG(Show);
                obj();

                calc obj1 = new calc(Square);
                obj1.Invoke(5);
                obj1 = Cube;
                obj1.Invoke(5);
            
                Console.ReadLine();
        }
    }
}
