namespace STATIC_CLASS
{
    
    static class Product
    {
        static int produvtId;
        static string productName;
        static int productPrice;

        static Product() 
        {
            produvtId = 111;
            productName = "gitar";
            productPrice = 5000;
        }
        public static void getProductDetails()
        {
            Console.WriteLine(produvtId);
            Console.WriteLine(productName);
            Console.WriteLine(productPrice);
        }   
        public static void offerProduct()
        {
            var offerdPrice = productPrice / 10;

            Console.WriteLine("your finel price is : " + ( productPrice - offerdPrice ));
        }

        //class item : product  // static class cannot be inherite 
        //{ 
            
        //}
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product.getProductDetails();
            Product.offerProduct();
            //Console.ReadLine();
             
        }
    }
}
