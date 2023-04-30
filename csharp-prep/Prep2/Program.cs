using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string answer = Console.ReadLine();
        int grade = int.Parse(answer);
        string grade_letter = "";
        int modifier_value = grade % 10;
        string modifier_sign = "";

        if(grade > 90)
        {
            grade_letter = "A";
        }

        else if(grade > 80)
        {
            grade_letter = "B";
        }

        else if(grade > 70)
        {
            grade_letter = "C";
        }

        else if(grade > 60)
        {
            grade_letter = "D";
        }

        else if(grade < 60)
        {
            grade_letter = "F";
        }


        //Set Modifier Sign
        if(modifier_value >= 7)
        {
            modifier_sign = "+";
        } 

        else if(modifier_value < 3)
        {
            modifier_sign = "-";
        }



        Console.WriteLine($"Your letter grade is: {grade_letter + modifier_sign}");
    }
}