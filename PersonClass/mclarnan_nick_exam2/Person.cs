/*

    Nicholas McLarnan
    Exam 2
    Create a program using properties, instance variables, methods that will 
                tell user how many years until they retire
    07/20/2022
*/

// create Person class
class Person
{
    // declare empty name variable
    string name = "";
    // declare empty age variable
    int age;


    // Name property
    public string Name
    {
        get { return name; } // get name

        set { name = value; } // set name
    }



    // Age property
    public int Age
    {
        get { return age; } // get age

        set { age = value; } // set age

    }

    // declare empty yearsToWork variable
    int yearsToWork;

    // YearsToWork property
    public int YearsToWork
    {
        get { return yearsToWork; } // get yearsToWork

        set { yearsToWork = value; } // set yearsToWork
    }

    // YTK method
    public int YTK(int Age)
    {
        // return years until you can retire
        return YearsToWork = 65 - Age;
    } // end YTK method


} // end Person class

// END PROGRAM