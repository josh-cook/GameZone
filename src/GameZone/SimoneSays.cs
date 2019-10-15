using System;

public class SimoneSays {
    public static void Play() {
        Console.WriteLine("Welcome to Simone Says, a game about following orders.");
        string[] tasks = new string[] {
            "Pick your nose",
            "Jump",
            "Waggle your finger",
            "Sleep"
        };

        Random rand = new Random();
        int seed = rand.Next(2);
        bool simoneSaidIt = (seed == 0);
        int commandSeed = rand.Next(tasks.Length);
        if (simoneSaidIt) {
            Console.WriteLine("Simone Says:...");
        }
        string selectedTask = tasks[commandSeed];
        Console.WriteLine($"{selectedTask}");

        string input = Console.ReadLine();

        if (simoneSaidIt && input.Contains(selectedTask)) {
            Console.WriteLine("Congrats");
        } else if (!simoneSaidIt && input.Contains(selectedTask)) {
            Console.WriteLine("You've knacked it");
        }

        if (!simoneSaidIt && input.Contains("")) {
            Console.WriteLine("You're the best");
        }
    }
}