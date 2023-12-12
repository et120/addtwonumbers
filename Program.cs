// Name: Elizabeth Trotter 

// Date Revised: 9/7/2023

// Exercise: Mini Challenge # 2 - Add 2 Numbers

// Brief Description: Create a brand new console project where the user is asked to enter in 2 numbers. 
//                    Add them together & print out the results in a sentence.

// Peer Reviewer: Ellie Rasuli

Console.Clear();

string title = "Mini Challenge # 2";
Console.WriteLine(title);
string breakPoint = "--------------------------";
Console.WriteLine(breakPoint);

Console.WriteLine("First, enter a whole number between 1 and 1000:");
int firstNum = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Then, enter another whole number between 1 and 1000:");
int secondNum = Convert.ToInt16(Console.ReadLine());

int total = firstNum + secondNum;
Console.WriteLine($"The sum of your two numbers is {total}.");