using System;

class DoWhile {
    static void Main(){
        // ensure that the commands will be executed at least once
        string password = "123";
        string userPassword;
        int t =  0;
        int limit =  5;

        do {
            Console.Clear();
            Console.WriteLine("Password: ");
            userPassword = Console.ReadLine();
            t++;

            if (userPassword == password) {
                Console.Clear();
                Console.WriteLine("Correct password.\nAttempts: " + t + ".");
                break;
            }

            if (t == limit){
                Console.Clear();
                Console.WriteLine("Many attempts.");
                break;
            }
        } while (true);
    }
}
