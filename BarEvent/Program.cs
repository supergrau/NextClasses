namespace BarEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bar bar = new Bar();
            Person person1 = new Person() { Name = "Paul"};
            Person person2 = new Person() { Name = "Paula" };
            Person person3 = new Person() { Name = "Julius"};
            person1.Eintreten(bar);
            person2.Eintreten(bar);
            person3.Eintreten(bar);
            bar.RundeAusgeben();
            bar.RundeAusgeben2();
            person2.Verlassen(bar);
            bar.RundeAusgeben2();

        }
    }
}