using System;

class VariablesScop {

    // global variable (antes de todos as classes)
    static int varGlobal = 13; // static because of the method static

    static void Main(){
        int num = 0;
        Console.WriteLine(varGlobal);
    }

    // other method
    void test(){
        int numTest = 1; // é possível acessar
        Console.WriteLine(num); // não é possível ter acesso à variável
        Console.WriteLine(varGlobal); // erro, porque não é um método estático
    }
}