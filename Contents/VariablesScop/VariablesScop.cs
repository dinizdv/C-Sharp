using System;

class VariablesScop {

    // global variable (before classes)
    static int varGlobal = 13; // static because of the method static

    static void Main(){
        int num = 0;
        Console.WriteLine(varGlobal);
    }

    // other method
    void test(){
        int numTest = 1; // it is possible to access
        Console.WriteLine(num); // unable to access variable
        Console.WriteLine(varGlobal); // error, because it is not a static method
    }
}