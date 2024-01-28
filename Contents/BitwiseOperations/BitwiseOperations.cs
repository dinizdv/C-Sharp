using System;

class BitwiseOperations {
    static void Main() {
        // <<   double
        // >>   half
        int num = 10;
        num = num >> 1; // displacement in one position
        int num2 = 10;
        num2 = num2 << 1; // displacemente in one position
        Console.WriteLine(num); // output -> 5
        Console.WriteLine(num2); // output -> 20
    }
}