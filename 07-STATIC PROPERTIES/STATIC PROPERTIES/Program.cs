namespace STATIC_PROPERTIES
{
    class University
    {
        private static string UniversityName;
        private static string DeparmentName;

        public static string _UniversityName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("University name is not null or empty");
                }
                else
                {
                   UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }

        public static string _DeparmentName
        {
            set 
            {
                if(string.IsNullOrEmpty(value)) 
                {
                    Console.WriteLine("deparment name is not null or empty ");
                }
                else
                {
                    DeparmentName = value;
                }
            }
            get 
            {
                return DeparmentName;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            University._UniversityName = "shivaji university kolhapur ";
            Console.WriteLine(University._UniversityName);
            University._DeparmentName = "computer deparment ";
            Console.WriteLine(University._DeparmentName );
        }
    }
}
