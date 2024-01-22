using System;

class OutputFormatting {
    static void Main(){
        int n1, n2, n3;
        n1 = 10;
        n2 = 20;
        n3 = 30;

        // index
        // \n -> break line
        // \t -> tab    
        Console.WriteLine("n1 = {0}, n2 = {1}, n3 = {2}", n1, n2, n3);

        // example:
        double value = 7.50;
        double sale;
        double profit = 0.1;
        string product = "Blueberry";

        sale = value + (value*profit); // 7,50 + (7,50 * 0,75) -> 8,25

        // {0,15} -> space
        Console.WriteLine("Product:{0,15}", product); // {0,15:c} -> $
        Console.WriteLine("Value:{0,15:c}", value);  // {0,15:c} -> $
        Console.WriteLine("Profit:{0,15:p}", profit); // {0,15:p} -> %
        Console.WriteLine("Sale:{0,15:c}", sale);
    }
}