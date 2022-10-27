using Card_number;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

class program
{
    public static void Main(string[] val)
    {
        Console.WriteLine("Welcome to redit card number checker ");
        Console.WriteLine("Enter your credit card number");
        long ccnumber =(long)Convert.ToDouble(Console.ReadLine());
        
        Checkers ck = new Checkers();

        // ck.Checkcc();
        ck.ReverseCCNumber(ccnumber);
       
        

    }
}

