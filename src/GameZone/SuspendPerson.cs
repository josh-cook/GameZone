using System;
using System.Collections.Generic;
using System.Text;

public class SuspendPerson {
    public static void Play () {
        Console.WriteLine ("Welcome to Suspend Person, a game about guessing.");
        string answer = "Terminator";
        List<char> guesses = new List<char> ();

        int lives = 3;

        while (lives > 0) {
            Console.WriteLine ("Movie / Film");
            Console.WriteLine ("Enter a letter...");

            // Read a lower-case character from the user.
            char guess = Char.ToLower (Console.ReadLine () [0]);

            // Check if the character was already guessed.
            if (guesses.Contains (guess)) {
                Console.WriteLine ("You've already guessed that!");
                continue;
            }

            guesses.Add (guess);

            if (answer.Contains (guess)) {
                Console.WriteLine ("Correct!");
            } else {
                lives--;
                Console.WriteLine ($"Wrong! You now have {lives} lives");
                continue;
            }

            StringBuilder outputBuilder = new StringBuilder ();

            // Build the output.
            for (var i = 0; i < answer.Length; i++) {
                char current = answer[i];

                if (guesses.Contains (Char.ToLower (current))) {
                    outputBuilder.Append (current);
                } else {
                    outputBuilder.Append ('_');
                }
            }

            if (outputBuilder.Equals (answer)) {
                Console.WriteLine ("*****YOU WON!*****");
                Console.WriteLine ("Would you like to play again?");
                var choice = Console.ReadLine ();
                if (choice == "y") {
                    Play ();
                } else {
                    break;
                }
            }
            Console.WriteLine (outputBuilder.ToString ());
        }
        Console.WriteLine ("You have been suspended...");
    }
}