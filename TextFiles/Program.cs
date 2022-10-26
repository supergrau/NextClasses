namespace TextFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            byte[] buffer = new byte[26];
            for (int i = 0; i < buffer.Length; i++)
                buffer[i] = (byte)(i + 65);

            FileStream write = new FileStream("write.txt", FileMode.Create);

            for(int i = 65; i < 91; i++)
                write.WriteByte(Convert.ToByte(i));

            // Zeilenvorschub einfügen
            write.WriteByte(Convert.ToByte(13));
            // Carrige Return einfügen
            write.WriteByte(Convert.ToByte(10));

            write.Write(buffer, 0, buffer.Length);

            write.Close();

            Console.WriteLine("Schreiben erledigt");
        }
    }
}