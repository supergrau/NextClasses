namespace NextClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Zeichenketten
            string s = "Hallo C#";
            string [] slist = s.Split(" ");
            for (int i = 0; i < slist.Length; i++)
                Console.WriteLine(slist[i]);
            if (s.Contains('#'))
                Console.WriteLine("# gefunden");
            if (!s.Contains('z'))
                Console.WriteLine("z nicht gefunden");
            Console.WriteLine(s.Substring(1, 3));
            for(int i = 0; i < s.Length; i++)
                Console.WriteLine(s[i]);
            
            string n = "123";
            try
            {
                int i = Convert.ToInt32(n);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}