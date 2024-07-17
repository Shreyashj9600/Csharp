namespace ENCAPSULATION
{
    class Person
    {
        private string name;
        private int age;

        public void setName(string name)
        {
            if (string.IsNullOrEmpty(name) == true)
            {
                Console.WriteLine("name is required !");
            }
            else
            {
                this.name = name;
            }
        }
        public void getName()
        {
            if (string.IsNullOrEmpty(this.name) == true)
            {
            }
            else
            {
                Console.WriteLine(this.name = name);
            }
        }
        public void setAge(int age) 
        {
            if(age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("age is not negative or zero ");
            }
        }
        public void getAge()
        {
            if(age > 0) 
            {
                Console.WriteLine("your age is " + this.age);
            }
            else
            {

            }
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
                Person obj = new Person();
                obj.setName("rohit");
                obj.getName();
                obj.setAge(10);
                obj.getAge();
            }
        }
}
