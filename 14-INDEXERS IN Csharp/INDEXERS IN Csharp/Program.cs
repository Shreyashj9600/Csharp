namespace INDEXERS_IN_Csharp
{
    class Employee
    {
        private int[] myArr = new int[3];

        public int this[int index]
        {
            set 
            {
                if (index >= 0 && index < myArr.Length)
                {
                    if (value > 0)
                    {
                        myArr[index] = value;
                    }
                    else
                    {
                        Console.WriteLine("value is not negative ");
                    }
                }
                else
                {
                    Console.WriteLine("Enter correct index ! ");
                }
                   
            }
            get 
            {
                return myArr[index];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Employee emp = new Employee();
            emp[0] = 5;
            Console.WriteLine(emp[0]);
        }
    }
}