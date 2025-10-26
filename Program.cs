namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Boat eka = new Boat("Eksjö båt", "Optimistjolle", 0, "Sverige", 1,4);
            eka.PrintInfo();

            Console.WriteLine("-----------------------------------------------");

            Car volle = new Car("Volvo", "S80", 4, "Sverige", 24000,0);
            volle.PrintInfo();
            volle.DistanceDriven();
            volle.PrintInfo();
        }
    }
}
