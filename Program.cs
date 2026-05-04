namespace StrandC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<furdo> list = new List<furdo>();
            string[] sorok = File.ReadAllLines("strandok.txt").Skip(1).ToArray();
            foreach (string s in sorok)
            {
                list.Add(new furdo(s));
            }
            Console.WriteLine("7.feladat:");
            Console.WriteLine($"Fürdők száma: {list.Count}");

            int összeg = 0;
            foreach (var item in list)
            {
                összeg += item.Ár;
            }
            double átlag = összeg / (double)list.Count;
            Console.WriteLine("8.feladat\r\nA fürdőbelépők átlagos ára: {átlag:F1}\r\n");

            furdo min = list[0];
            foreach (var item in list)
            {
                if (item.Vízhőfok < min.Vízhőfok)
                    min = item;
            }
            Console.WriteLine($"9. feladat");
            Console.WriteLine($"A leghidegebb víz a(z) {min.Név} nevű fürdőben van.\r\n");

            Console.WriteLine($"10. feladat\r\nKérem, adja  meg a fürdő nevét!");
            string nev = Console.ReadLine();
            furdo valasz = null;
            foreach (var item in list)
            {
                if (item.Név == nev)
                {
                    valasz = item;
                }
            }

            if (valasz != null)
                Console.WriteLine($"A {valasz.Telepules()} településen van, " +
                    $"az irányítószám: " +
                    $"{valasz.IRSZ()}\r\n");
            else Console.WriteLine("Nincs ilyen nevű fürdő!");
        }

        }
    }
}
