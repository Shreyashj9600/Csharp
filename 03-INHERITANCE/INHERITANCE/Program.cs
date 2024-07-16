namespace INHERITANCE
{

    class VesitingEmployess : Employess
    {
        public int vesitingSalary;
        public int vesitingHours;
    }

    class PermentEmployes : Employess
    {
        public int permentSalary;
        public int permentHours;
    }
    
    class Employess 
    {
        public int EmpId;
        public string EmpName;
        public int Age;
        public int contact;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            VesitingEmployess rohit = new VesitingEmployess();
            rohit.EmpId = 1;

            PermentEmployes ali = new PermentEmployes();
            ali.EmpId = 2;

            Console.WriteLine(rohit.EmpId);
            Console.WriteLine(ali.EmpId);

            Console.ReadLine();
        }
    }
}
