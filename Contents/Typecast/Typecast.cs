using System;

class Typecast {
    static void Main() {
        int n1 = 10;
        float n2 = n1; // implicit conversion (safe)

        // cast operation (typecast)
        float f1 = 8.5f;
        int i1 = (int)f1;  // conversion
        Console.WriteLine(i1); // output -> 8
    }
}