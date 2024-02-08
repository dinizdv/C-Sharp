using System;

class SwithCase {
    static void Main(){
        // test variable and compare with cases

        int time = 0;
        string choose;
        Console.WriteLine("Make your travel.");
        Console.WriteLine("Choose your vehicle:\n(P) for plane\n(B) for bus\n(C) for car.");
        
        choose = Console.ReadLine().ToLower(); // conversion to lowercase (for comparing)
        switch(choose) {
            case "p":
                time = 50;
                break;
            case "b":
                time = 250;
                break;
            case "c":
                time = 210;
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }

        Console.WriteLine("Travel time for " + choose + " is " + time + " minutes.");
    }
}