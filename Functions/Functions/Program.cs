namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();//We hebben de vabiraal rogram aangemaakt.//
                                            // De type van de vabriaal is ook program//
            program.Run();//De functie is "Run" in de  vabriaal program en de Retrun is void.//
            Console.WriteLine("Hello, World!");


        }
        void Run() {
            Console.WriteLine("Dit is nu de start van mijn programma");

            vraag1();
            vraag2();
            vraag3();
            vraag4();
            vraag5();
            vraag6();
            vraag7();
            string antwoord = vraag7();
            Console.WriteLine(antwoord);
        }
        internal void vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag2() {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }

        internal void vraag3()
        {
            Console.WriteLine("What would you do if you won a million dollars ?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag4()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag5() {
            Console.WriteLine("Why do round pizzas come in square boxes?");
             string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal void vraag6() {
            Console.WriteLine("Has someone caught you dancing in front of the mirror ?");
              string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);
        }
        internal string vraag7()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        }   } 
