namespace SEALED_METHOD
{
    class A
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of class A");
        }
    }
    class B : A
    {
        public sealed override void print()
        {
            Console.WriteLine("This is a method of class B");
        }
    }

    //class C : B 
    //{
    //    public override void print()
    //    {
    //        Console.WriteLine("This is a method of class C");
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.print();
        }
    }
}
