namespace METHOD_HIDING
{
    class Parent
    {
        public void show() 
        {
            Console.WriteLine("this is public method !");
        }
    }
    class Child : Parent
    {
        public new void show() 
        {
            //base.show();
            Console.WriteLine("this is a child method ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Child();
            p.show();
            //((Parent)obj).show(); 
            //obj.show();
        }   
    }
}
