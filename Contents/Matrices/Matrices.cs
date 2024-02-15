using System;

class Matrices {
    static void Main() {
        // row, column (indexes)
        int[,] n = new int[3, 5] { // 3 rows, 5 columns
            {  10,  20,  30,  40,  50 },
            {  11,  22,  33,  44,  55 },
            {  12,  24,  36,  48,  60 }
        };

        Console.WriteLine(n[1, 3]); // output -> 44
    }
}
