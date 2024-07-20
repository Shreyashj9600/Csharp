namespace POLYMORPHISM
{

    internal class Program
    {
        // Method or function overloading

        public void Add()
        {
            int a = 11; 
            int b = 10;
            int c = a + b;
            Console.WriteLine("addation result is {0}", c);
        }
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
        }
        public void Add(string name , string Lname)
        {
            string fullName = name + " " + Lname;
            Console.WriteLine("your full name is " + fullName);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add("shreyash" , "jadhav");
        }
    }
}
