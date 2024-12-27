namespace Lekce_5_HW
{
    internal class lesson5
    {
        public static void Demo(string[] args)
        {
            Console.WriteLine("Ahoj vítám tě v mém programu!");
            object infoUzivatel = zpracujUzivatele();
        }

        public static int Vek()
        {
            Console.Write("Prosim zadej svuj vek");
            string VekUzivatele = Console.ReadLine();
            int VekUzivateleInt = int.Parse(VekUzivatele);
            return VekUzivateleInt;
        }

        public static double CalculateBmiIndex(double height, double weight)
        {
            var bmi = weight / (height * height);
            return bmi;
        }

        public static double CalculateBmiIndex2(double height2, double weight2)
        {
            var bmi2 = weight2 / (height2 * height2);
            return bmi2;
        }

        public static double VyskaodUzivatele()
        {
            Console.Write("Prosim zadej svou vysku v cm ");
            string vstupVyska = Console.ReadLine();
            double VyskaDouble = double.Parse(vstupVyska);
            return VyskaDouble;
        }

        public static string JmenoUzivatele()
        {  
            Console.Write("Prosim zadej sve jmeno ");
            string JmenoUzivatele = Console.ReadLine();
            return JmenoUzivatele;
        }

        public static double VahaUzivatele()
        {
            Console.Write("Prosim zadej svou hmotnost ");
            string VahaUzivatele = Console.ReadLine();
            double VahaUzivateleDouble = double.Parse(VahaUzivatele);
            return VahaUzivateleDouble;
        }

        public static object zpracujUzivatele()
        {

            string name = JmenoUzivatele();
            int vek = Vek();
            double vyska = VyskaodUzivatele();
            double vaha = VahaUzivatele();

            Console.WriteLine(name + " je starý(á) " + vek + " let. Váží " + vaha + " kilogramů a je " + vyska + " centimetrů vysoký(á).");
            double height = vyska / 100;
            double weight = vaha;
            double bmi = CalculateBmiIndex(height, weight);
            double BmiRounded = Math.Round(bmi);
            Console.WriteLine("Vaše bmi je " + BmiRounded);

            if (BmiRounded <= 15)
            {
                Console.WriteLine("Tohle není úplně zdravé, zkus přibrat");
            }
            else if (BmiRounded >= 15 && BmiRounded <= 45)
            {
                Console.WriteLine("Mas idealni BMI");
            }
            else
            {
                Console.WriteLine("Zkus zhubnout");
            }

            string name2 = JmenoUzivatele();
            int vek2 = Vek();
            double vyska2 = VyskaodUzivatele();
            double vaha2 = VahaUzivatele();

            Console.WriteLine(name2 + " je starý(á) " + vek2 + " let. Váží " + vaha2 + " kilogramů a je " + vyska2 + " centimetrů vysoký(á).");
            double height2 = vyska2 / 100;
            double weight2 = vaha2;
            double bmi2 = CalculateBmiIndex2(height2, weight2);
            double BmiRounded2 = Math.Round(bmi2);
            Console.WriteLine("Vaše bmi je " + BmiRounded2);

            if (BmiRounded2 <= 15)
            {
                Console.WriteLine("Tohle není úplně zdravé, zkus přibrat");
            }
            else if (BmiRounded2 >= 15 && BmiRounded2 <= 45)
            {
                Console.WriteLine("Mas idealni BMI");
            }
            else
            {
                Console.WriteLine("Zkus zhubnout");
            }
            return true;
        }
    }
}
