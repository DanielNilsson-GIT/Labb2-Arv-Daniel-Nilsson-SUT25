namespace Labb2_Arv_Daniel_Nilsson_SUT25
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Boat eka = new Boat("Eksjö båt", "Optimistjolle", "Sverige",0, 4);
            //eka.PrintInfo();
            //Console.WriteLine("-----------------------------------------------");
            //eka.AddMiles();
            //eka.PrintInfo();
            //Console.WriteLine("-----------------------------------------------");
            //eka.AddMiles();
            //Console.WriteLine("-----------------------------------------------");
            //eka.PrintInfo();

            //Console.WriteLine("-----------------------------------------------");
            //Motorcycle moppe = new Motorcycle("Puch","340",2,"sweden",0,0,false,null);
            //moppe.PrintInfo();

            //Boat yacht = new Boat();
            //yacht.PrintInfo();

            //Car bil = new Car();
            //bil.PrintInfo();
            //Console.WriteLine("\n_______________________________\n");
            //bil.PopTheTrunk();
            //Console.WriteLine("\n_______________________________\n");
            //bil.PrintInfo();
            //bil.PopTheTrunk();
            //bil.PrintInfo();

            Motorcycle bike = new Motorcycle("Yamasaki","Y20",2,"Japan",100,2,true,"Knatteligan");
            bike.DoAWheelie();
            bike.DoAWheelie();
            bike.DoAWheelie();
            bike.DoAWheelie();
            bike.DoAWheelie();
            bike.PrintInfo();


            //Car volle = new Car("Volvo", "S80", 4, "Sverige", 24000,0);
            //volle.PrintInfo();
            //volle.AddMiles();
            //volle.PrintInfo();
        }
    }
}
