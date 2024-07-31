namespace ANONYMOUS_FUNCTION
{
    public delegate void myDelegate(int num);

    internal class Program
    {
        public static void myMethod(myDelegate del, int a)
        {
            a += 10;
            del.Invoke(a);
        }
        static void Main(string[] args)
        {
            Program.myMethod(delegate (int b)
            {
                b += 10;
                Console.WriteLine(b);
            }, 5);  
        }
    }
}
