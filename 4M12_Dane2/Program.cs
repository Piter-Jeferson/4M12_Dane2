namespace _4M12_Dane2
{
    class Pojazd
    {
        private int id, rocznik, przebieg, cena;
        private string marka, model, kolor;

        public Pojazd(int id, int rocznik, int przebieg, int cena, string marka, string model, string kolor)
        {
            this.id = id;
            this.rocznik = rocznik;
            this.przebieg = przebieg;
            this.cena = cena;
            this.marka = marka;
            this.model = model;
            this.kolor = kolor;
        }
        public override string ToString()
        {
            return $"{id} {marka} {model} {kolor} {przebieg} {rocznik} {cena}";
        }
    }
    internal class Program
    {
        private static List<Pojazd> pojazd = new List<Pojazd>();
        static void Main(string[] args)
        {
            using (TextReader plik = File.OpenText("pojazd.csv")) {
                string s;
                int id = 0, rocznik = 0, przebieg = 0, cena = 0;
                string marka = "", model = "", kolor = "";
                s = plik.ReadLine();
                Console.WriteLine(s);
                //while (plik.Peek() > -1){
                int p;
                string pom;
                s= plik.ReadLine();
                p = s.IndexOf(";");
                pom = s.Substring(1, p - 2);
                id = int.Parse(pom);
                Console.WriteLine(pom);

                pojazd.Add(new Pojazd(id, rocznik, przebieg, cena, marka, model, kolor));
               // }
            }
            Console.WriteLine("Obiekty z Listy");
            foreach( var p in pojazd){
                Console.WriteLine(p.ToString());
            }
        }
    }

}