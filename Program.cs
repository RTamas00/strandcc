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
        }
    }
}
