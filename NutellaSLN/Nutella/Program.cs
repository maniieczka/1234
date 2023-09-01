namespace Nutella
{
    internal class Program
    {
        const string ADD_DESCRIPTION = "dodawania";
        const string SUB_DESCRIPTION = "odejmowania";
        const string MUL_DESCRIPTION = "mnożenia";
        const string DIV_DESCRIPTION = "dzielenia";



        private static void Calculator(string operation)
        {
            Console.WriteLine("Otrzymasz wynik "+operation+", podaj pierwszą liczbę całkowitą");
            string pierwszaLiczbaCałkowita = Console.ReadLine();
            int Pierwsza = Int32.Parse(pierwszaLiczbaCałkowita);
            Console.WriteLine("Otrzymasz wynik "+operation+", podaj drugą liczbę całkowitą");
            string drugaLiczbaCałkowita = Console.ReadLine();
            int Druga = int.Parse(drugaLiczbaCałkowita);

            int Wynik = 0;
            switch (operation)
            {
                case ADD_DESCRIPTION:
                    Wynik = Pierwsza + Druga;
                    break;
                case SUB_DESCRIPTION:
                    Wynik = Pierwsza - Druga;
                    break;
                case MUL_DESCRIPTION:
                    Wynik = Pierwsza * Druga;
                    break;
                case DIV_DESCRIPTION:
                    Wynik = Pierwsza / Druga;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa operacja");
                    return;

            }
            Console.WriteLine("Wynik to:" + Wynik);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Siema,celem aplikacji jest to zebys podał dwie liczby całkowite i otrzymał wynik dodawania, odejmowania, mnożenia, dzielenia.");
            Console.WriteLine("Jeśli chcesz otrzymać wynik dodawania wpisz +, jeśli chcesz otrzymać wynik odejmowania wpisz -, mnożenie wpisz *, dzielenie wpisz /");
            string działanie;
            działanie = Console.ReadLine();
            if (działanie == "+")
            {
                Calculator(ADD_DESCRIPTION);

            }
            if (działanie == "-")
            {
                Calculator(SUB_DESCRIPTION);
            }
            if (działanie == "*")
            {
                Calculator(MUL_DESCRIPTION);
            }
            if (działanie == "/")
            {
                Console.WriteLine("Otrzymasz wynik dzielenia, podaj pierwszą liczbę całkowitą");
                string pierwszaLiczbaCałkowita = Console.ReadLine();
                int Pierwsza = int.Parse(pierwszaLiczbaCałkowita);
                Console.WriteLine("Otrzymasz wynik dzielenia, podaj drugą liczbę całkowitą");
                string drugaLiczbaCałkowita = Console.ReadLine();
                int Druga = int.Parse(drugaLiczbaCałkowita);
                double rodzynek = (double)Pierwsza;
                double Wynik = rodzynek / Druga;
                Console.WriteLine("Wynik to:" + Wynik);
            }
        }
    }
}


//  0,6666666666666666
//666,6666666666666