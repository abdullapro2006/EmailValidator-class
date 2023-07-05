// See https://aka.ms/new-console-template for more information


namespace ShoesOrder
{
    public abstract class Shoes
    {
        public string CompanyName { get; set; }
        
        public int Value { get; set; }
        public override string ToString()
        {
            return CompanyName + " " + " " + Value;
        }

        public Shoes(string companyname,  int value)
        {
            CompanyName = companyname;
            Value = value;
            
            
        }
        public abstract void TotalValue(int count);
    }
    public class TheFisrtShoes : Shoes
    {
        public override void TotalValue(int count)
        {
            Value = count * 200;
        }
        public TheFisrtShoes(string companyname,  int value) : base(companyname, value) { }



       
    }
    public class TheSecondShoes : Shoes
    {
        public override void TotalValue(int count)
        {
            Value = count * 1000;
        }
        public TheSecondShoes(string companyname,int value) : base(companyname,value) 
        {

        }
    }
    public class TheThirdShoes : Shoes
    {
        public override void TotalValue(int count)
        {
            Value = count * 150;
        }
        public TheThirdShoes(string companyname,int value) : base (companyname,value)
        {

        }
    }
    public class Program 
    { 
        public static void Main(string[] args)
        {
            TheFisrtShoes theFisrtShoes = new TheFisrtShoes("Adidas",  200);
            Console.WriteLine(theFisrtShoes);
            TheSecondShoes theSecondShoes = new TheSecondShoes("Gucci",  1000);
            Console.WriteLine(theSecondShoes);
            TheThirdShoes theThirdShoes = new TheThirdShoes("Nike", 150);
            Console.WriteLine(theThirdShoes);
            theFisrtShoes.TotalValue(4);
            Console.WriteLine(theFisrtShoes.Value);
            theSecondShoes.TotalValue(2);
            Console.WriteLine(theSecondShoes.Value);
            theThirdShoes.TotalValue(1);
            Console.WriteLine(theThirdShoes.Value);
        }
    }


}
