using System;

class Operators {
    static void Main(){
        int res = 10 + 5;
        Console.WriteLine(res);

        // other operators -> > < >= <=

        // relational operators
        // bool -> true or false
        bool b = 10 < 5; 
        Console.WriteLine(b); // output -> false

        bool d = 10 != 5; 
        Console.WriteLine(d); // true, because 10 is different from 5

        int number = 10;
        number += 3; // output -> number(10) = number(10) + 3 == 13
        Console.WriteLine(number);
        
        // && = AND
        // || = OR
        bool and = (5 > 3) && (8 > 4); // true AND true
        Console.WriteLine(and); // output -> true

        bool and2 = 12 > 43 && 9 > 2; // false AND true
        Console.WriteLine(and2); // output -> false

        bool or = 89 == 89 || 23 < 4; // true OR false
        Console.WriteLine(or); // output -> true
    }  
}
