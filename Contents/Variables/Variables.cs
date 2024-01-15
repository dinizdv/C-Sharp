using System;

class Variables {
    static void Main(){
        byte n = 10; // 0 and 255
        int num = 0; // negative and positive
        char letter = 'g'; // contains ''
        float value = 14.34f; // 'f' in final
        string name = "Bruno"; // contains ""
        string secondName = "Diniz";

        var variable = "dinizdev.com.br"; // no type
    
        Console.WriteLine(n);
        Console.WriteLine("My name is: " + name + secondName);
        // compiler -> csc variables.cs
    }
}