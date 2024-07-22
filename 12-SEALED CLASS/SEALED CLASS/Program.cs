namespace SEALED_CLASS
{
    sealed class Parent 
    {
        public void show1()
        {
            Console.WriteLine("this is a parent classs");
        }
    }
    //class Child : Parent
    //{
    //    public void show2()
    //    {
    //        Console.WriteLine("this is a child classs");
    //    }
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            //Child c = new Child();
            //c.show1();
        }
    }
}
