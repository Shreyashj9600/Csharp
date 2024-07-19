namespace PROPERTIES_WITH_GET_AND_SET
{
    class Student
    {
        private int _stdId;
        private string _stdName;
        private string _fName;

        public int stdId
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("value is not zero or negative");
                }
                else
                {
                    this._stdId = value;
                }
            }
            get 
            {
                return this._stdId;
            }
        }
        public string stdName
        {
           set
           {
                if (string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("Pleas enter your name");
                }
                else 
                {
                    this._stdName = value;
                }
           }
           get 
           {
                return _stdName;
           }
        }
        public string fName
        {
            set 
            {
                if(string.IsNullOrEmpty(value) == true)
                {
                    Console.WriteLine("enter your father name");
                }
                else
                {
                    this._fName = value;
                }
            }
            get
            {
                return _fName;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.stdId = 1;
            Console.WriteLine(s.stdId);
            s.stdName = "ali";
            Console.WriteLine(s.stdName);
            s.fName = "salman";
            Console.WriteLine(s.fName);
        }
    }
}