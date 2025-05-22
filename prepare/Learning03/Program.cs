using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}

/*
Activity Instructions
Practice the principle of encapsulation by creating classes to hold a fraction, such as 2/3. 
As youu recall from your Math classes, a fraction has a top number (numerator) and a bottom 
number (denominator). The fraction can be expressed as two integers with a slash between them, 
such as 3/4 or as a decimal, such as 0.75.

Step 1: Design the Classes
You need to create a class for a fraction that has:
• Attributes for the top and bottom numbers
• Constructors
• Getters and setters for the top and bottom numbers
• Methods to return representations of both the fractional and decimal views.

Step 2: Start the Project
1. Open the class project in VS Code.
2. Navigate to the Learning03 project in the prepare folder. Find the Program.cs 
    file, which will be your entry point for the program.
3. Verify that you can run the project.

Step 3: Create the Fraction class
1. Create a class to hold fraction.
2. The class should be in its own file.
3. The class should have two attributes for the top and bottom numbers.
4. Make sure the attributes are private.

Step 4: Create the Constructors
1. Create the following constructors:
    • Constructor that has no parameters that initializes the number to 1/1.
    • Constructor that has one parameter for the top and that initializes the denominator to 1.
        So that if you pass in the number 5, the fraction would be initialized to 5/1.
    • Constructor that has two parameters, one for the top and one for the bottom.

2. In your Program. cs file, verify that you can create fractions using all three of these 
    constructors. For example, create an instance for 1/1 (using the first constructor), for 
    6/1 (using the second constructor), for 6/7 (using the third constructor).

Step 5: Create the Getters and Setters
1. Create getters and setters for both the top and the bottom values.
2. In your Program. cs file, verify that you can call all of these methods and get the 
    correct values, using setters to change the values and then getters to retrieve these new 
    values and then display them to the console.

Step 6: Create methods to return the representations
1. Create a method called GetFractionString that returns the fraction in the form 3/4.
2. Create a method called GetDecimalValue that returns a double that is the result of dividing 
    the top number by the bottom number, such as 0.75.
3. Verify that you can call each constructor and that you can retrieve and display the different 
    representations for a few different fractions. For example, you could try: 1, 5, 3/4, 1/3

Sample Output
1/1
1
5/1
5
3/4
0.75
1/3
0.3333333333333333

Sample Solution
When you have finished please compare your approach to the following sample solution you may also 
use this sample solution as a guide if you need help finishing).
• Learning Activity_03 Sample Solution.

Submission
1. Verify that your program works as described.
2. Commit and push your code to your GitHub repository.
3. Verify that you can see your updated code at GitHub.
4. Submit the I-Learn quiz to report on your work.
*/