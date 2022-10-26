namespace Delegates
{
    public delegate void BuyingHandler(float maxMoney);
    public delegate double CalculateHandler(double value1, double value2);
    public delegate void MyDelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            //BuyingHandler buying = null;
            //// Bei Notwendigkeit
            //buying = Buying;
            //// ...
            //buying(50);

            //CalculateHandler calculate;
            //double value1 = 34.56;
            //double value2 = 98.76;

            //calculate = new CalculateHandler(Mathematics.Add);
            //Console.WriteLine(calculate(value1, value2));
            //calculate = new CalculateHandler(Mathematics.Subtract);
            //Console.WriteLine(calculate(value1, value2));

            //var del = (MyDelegate)A;
            //// del = (MyDelegate)Delegate.Combine(del, (MyDelegate)B);
            //del += (MyDelegate)B;
            //del += (MyDelegate)A;
            //del += (MyDelegate)B;

            //del();
            //del -= (MyDelegate)B;
            //del();

            Button button = new Button();
            button.Name = "TestButton";
            button._clicked = C;
            button._clicked += D;
            button.Click();
        }

        public static void Buying(float maxM)
        {
            Console.WriteLine("Es wird eingekauft für {0}", maxM);
        }

        public static void A()
        {
            Console.WriteLine("A");
        }

        public static void B()
        {
            Console.WriteLine("B");
        }

        public static void C(object sender, ClickArgs args)
        {
            var button = sender as Button;         
            Console.WriteLine(args.ClickTime);
            Console.WriteLine($"X = {args.X} ---- Y = {args.Y}");
        }
        public static void D(object sender, ClickArgs args)
        {
            var button = sender as Button;
            Console.WriteLine(button.Name);

        }
    }

    class Mathematics
    {
        public static double Add(double x, double y) => x + y;
        public static double Subtract(double x, double y) => x - y;
    }

    delegate void MyClickDelegate(object sender, ClickArgs args);

    class ClickArgs : EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }

        public DateTime ClickTime { get; set; }
    }

    class Button
    {
        //public MyClickDelegate _clicked;
        public EventHandler<ClickArgs> _clicked;
        public string Name { get; set; }

        public void Click()
        {
            var args = new ClickArgs
            {
                X = 1, Y = 2, ClickTime = DateTime.Now
            };
            _clicked(this, args);
        }
    }
}