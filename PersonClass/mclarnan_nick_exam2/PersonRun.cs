/*

    Nicholas McLarnan
    Exam 2
    Create a program using properties, instance variables, methods that will 
                tell user how many years until they retire
    07/20/2022
*/

// create PersonRun class
class PersonRun
{
    // create Main method
    static void Main()
    {
        // create a new instance variable
        Person person = new Person();

        // input user's name
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        // input user's age
        Console.Write("Pleaee enter your age: ");
        int age = Convert.ToInt32( Console.ReadLine() );

        // assign yearsToWork to person.YTK() with age argument
        int yearsToWork = person.YTK(age);

        // display results
        Console.WriteLine();
        Console.WriteLine("{0}, you  will work: {1} years before you retire.", name, yearsToWork);


    } // end Main method
    
} // end PersonRun class

// END PROGRAM
