namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] words = new string[5][];
            words[0]= new string[] { "salam", "sagol" };
            words[1] = new string[] { "everthing ", " is", " good" };
            words[2] = new string[] { "sa,la,m", "Bonjour", "hola" };
            words[3] = new string[] { "123", "2343" };
            words[4] = new string[] { "good", "daysss" };
            //words[2]= words[2][0].Split(",");
            //foreach (var item in words[2][0].Split(","))
            //
                //Console.WriteLine(item);

            //}            
            //Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                foreach (var item in words[i])
                {
                    Console.WriteLine(item);
                    words[2][0].Split(",");

                }
                Console.WriteLine();
            }
        }
    }
}