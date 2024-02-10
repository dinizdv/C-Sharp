using System;

class ArrayVector {
    static void Main (){
        int[] numbers = new int[5]; // array int type with 5 vectors
        numbers[2] = 1200;

        int[] list = new int[3]{1, 2, 3}; // array with predefined vectors and values
        // [3] -> vectors       |       {1[0],2[1],3[2]} -> values
        int[] array = {10, 20, 30}; // the vectors are defined by the length of the array
        string[] vehicles = {"Car", "Bus", "Plane"}; // array of the string

        Console.WriteLine(numbers[2]); // output -> 1200
        Console.WriteLine(list[2]); // output -> 3
        Console.WriteLine(array[1]); // output -> 20
        // string.Join (concatenation in string)
        Console.WriteLine(string.Join(", ", array)); // output -> 10, 20, 30
        Console.WriteLine("\nArray numbers:");
        // loop method
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine(array[i]); // output -> 10 20 30
        }
    }
}
