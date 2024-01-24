using System;

class KeyboardValues {
    static void Main() {
        // Read and Readline -> return (string) 
        int v1, v2, addition;
        string name;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Your name is: {0}", name);

        // convert string in int (two ways)
        Console.WriteLine("Number 1: ");
        v1 = int.Parse(Console.ReadLine()); // int.Parse

        Console.WriteLine("Number 2: ");
        v2 = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32

        addition = v1 + v2;
        Console.WriteLine("Addition -> " + v1 + " + " + v2 + " = " + addition);
    }
}