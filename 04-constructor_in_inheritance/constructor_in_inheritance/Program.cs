using System.Threading.Channels;

namespace constructor_in_inheritance
{
    class BaseClass 
    {
        public BaseClass(string massage ) 
        {
            Console.WriteLine("this is base class constructor" + " " + massage);
        }
    }
    class DeriverdClass : BaseClass
    {
       public DeriverdClass() : base("this is c sharp")
        {
            Console.WriteLine("this is Derived class constructor ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DeriverdClass obj = new DeriverdClass();

            Console.ReadLine();
        }
    }
}
