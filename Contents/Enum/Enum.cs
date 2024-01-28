using System;

class Enum {
    
    // enum -> can only receive these elements
    enum Days{sunday, monday, tuesday, wednesday, thursday, friday, saturday}
    static void Main() {
        Days sunday = Days.sunday;
        Console.WriteLine(sunday); // output -> sunday

        // by index
        Days byIndex = (Days)2;
        Console.WriteLine(byIndex); // output -> tuesday

        int index = (int)Days.friday; // convert to int type
        Console.WriteLine(index); // output -> 5
    }
}