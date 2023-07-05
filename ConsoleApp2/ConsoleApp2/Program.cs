// See https://aka.ms/new-console-template for more information


namespace MyProgram
{
    public enum Planets
        
    {
        Mercury=1,
        Earth=2,
        Mars=4,
        Saturn,
        Jupiter,
        Plato



    }
    public enum PlanetsRadius 
    {
        Mercury =2345 ,
        Earth =1234,
        Mars =3456,
        Saturn=4567,
        Jupiter=5678,
        Plato=1267,
    }




    public class Program
    {
        public static void Main(string[] args)
        {
            int radius = (int)PlanetsRadius.Mercury;
            Console.WriteLine(radius);
        }
    }
}

