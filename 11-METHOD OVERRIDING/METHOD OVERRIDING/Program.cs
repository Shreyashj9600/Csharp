namespace METHOD_OVERRIDING
{
    class Parent
    { 
        public virtual void print()
        {
            Console.WriteLine("this is a method of PARENT  class");
        }
    }
    class Child : Parent
    {
        public override void print()
        {
            Console.WriteLine("this is a method of CHILD class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.print();  
        }
    }
}
