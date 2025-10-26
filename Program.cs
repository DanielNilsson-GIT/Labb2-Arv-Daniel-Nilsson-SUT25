namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Boat eka = new Boat("eksjö båt", "optimistjolle", 0, "Sverige", 1);
            eka.PrintInfo();

            Console.WriteLine("-----------------------------------------------");

            Car volle = new Car("Volvo", "S80", 4, "Sverige", 24000);
            volle.PrintInfo();
            volle.Drive();
            volle.PrintInfo();
        }
    }
}
