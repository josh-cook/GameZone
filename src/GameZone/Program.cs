using System;

namespace GameZone {
    class Program {
        static void Main () {
            Console.WriteLine ("Which Game Would you like to play? (Pick a number)");
            string[] games = {
                "1.Simone Says",
                "2.Suspend Person",
            };
            foreach (string game in games) {
                Console.WriteLine ("{0,-20}", game);
            }

            string userInput = Console.ReadLine ();
            switch (userInput) {
                case "1":
                    SimoneSays.Play ();
                    break;
                case "2":
                    SuspendPerson.Play ();
                    break;
                default:
                    Console.WriteLine ("You didn't choose a correct number...");
                    Main ();
                    break;
            }
        }
    }
}