namespace DESTRUCTORS
{
    class Person
    {
        public string name;
        public int age;

        public Person(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }
        public string getName () 
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age; 
        }
        ~Person() 
        {
            Console.WriteLine("Destructor is innovk !!..");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person rohit = new Person("rohit", 11);
            Console.WriteLine(rohit.getName());
            Console.WriteLine(rohit.getAge());
           
            //Console.ReadLine();
        }
    }
}
