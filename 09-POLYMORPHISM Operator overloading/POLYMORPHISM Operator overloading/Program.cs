namespace POLYMORPHISM_Operator_overloading
{
   class NewClass
    {
        public string Srt;
        public int num;

        public static NewClass operator +(NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.srt = obj1.srt + " " + obj2.srt;
            obj3.num = obj1.num + obj2.num;

            return obj3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NewClass obj1 = new NewClass();
            obj1.srt = "shreyash";
            obj1.num = 1;

            NewClass obj2 = new NewClass();
            obj2.srt = "jadhav";
            obj2.num = 2;

            NewClass obj3 = new NewClass();
            obj3 = obj1 + obj2;

            Console.WriteLine(obj3.srt);
            Console.WriteLine(obj2.num);
        }
    }
}
