namespace Example1
{
    internal class Program
    {
        static List<Animale> animals = new List<Animale>();

        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("habitatList.txt");

            foreach (var line in lines)
            {
                var animale = new Animale();
                animale.Habitat = line;
                animals.Add(animale);
            }

            Console.ReadLine();

















            ////var animale = new Animale("Cavallo", new DateTime(2000, 1, 1));

            ////var umano = new Uomo("Alessio");

            ////animals.Add(animale);
            ////animals.Add(umano);

            //var umano = new Uomo("Alessio");
            //var ghepardo = new Ghepardo("xxx");
            //var bradipo = new Bradipo("yyy");

            //Console.WriteLine($"Uomo {umano.GetVelocitaAttuale()}");
            //Console.WriteLine($"Ghepardo {ghepardo.GetVelocitaAttuale()}");
            //Console.WriteLine($"Bradipo {bradipo.GetVelocitaAttuale()}");

            //umano.Cammina();
            //ghepardo.Cammina();
            //bradipo.Cammina();

            //Console.WriteLine($"Uomo {umano.GetVelocitaAttuale()}");
            //Console.WriteLine($"Ghepardo {ghepardo.GetVelocitaAttuale()}");
            //Console.WriteLine($"Bradipo {bradipo.GetVelocitaAttuale()}");

            ////Console.WriteLine($"{umano.GetName()} ha {umano.GetAge()} anni");
        }
    }
}