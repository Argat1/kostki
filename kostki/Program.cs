namespace kostki
{
    internal class Program
    {
        void Zagraj()
        {
            int ilosck = 3;
            Console.WriteLine("Ile kostek chcesz rzucić?(3-10)");
            ilosck =  int.Parse(Console.ReadLine());
            if(ilosck > 2 && ilosck < 11) {
            
            }
            else
            {
                Zagraj();
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
