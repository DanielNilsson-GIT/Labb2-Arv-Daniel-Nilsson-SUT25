namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bil:");
            Car volkswagen = new Car("VolksWagen", "Passat", 4, "Tyskland", 4500, 1, false,false);
            volkswagen.startEngine();

            Console.WriteLine("__________________\n");
            Console.WriteLine("Motorcykel:");
            Motorcycle triumph = new Motorcycle("Triumph","550",2,"England",2000,0,true,"Knatteligan");
            triumph.startEngine();

            Console.WriteLine("__________________\n");
            Console.WriteLine("Båt:");
            Boat optimistjolle = new Boat("Båtsson", "Optimistjolle", "Sverige", 50, 20,false);
            optimistjolle.startEngine();

            Console.WriteLine("__________________\n");
            Console.WriteLine("EPA:");
            EPA_Truck epa = new EPA_Truck("Volvo", "P12", 4, "Sverige", 56000, 38, false, true);
            epa.startEngine();

            Console.WriteLine("__________________\n");
            Console.WriteLine("Husbil:");
            Mobilehome husbil = new Mobilehome("Knaus", "Sky Ti 700", 4, "Tyskland", 128, 1, false,false);
            husbil.startEngine();

            
        }
    }
}
