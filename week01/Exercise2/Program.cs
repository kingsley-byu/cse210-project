using System;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("what is the student's grade? ");
        string grade = Console.ReadLine();
        int studentGrade = int.Parse(grade);
        string letter = "";
        string sign = "";
        if (studentGrade >= 90)
        {
            letter = "A";
            if (studentGrade % 10 >= 7)
            {
                
            }
            else if (studentGrade % 10 < 3)
            {
               sign = "-"; 
            }

        }
        else if (studentGrade >=80)
        {
            letter = "B";
            if (studentGrade % 10 >= 7)
            {
                sign = "+";
            }
            else if (studentGrade % 10 <3)
            {
                sign = "-";
            }
        }
        else if (studentGrade >=70)
        {
            letter = "C";
            if (studentGrade % 10 >= 7)
            {
                sign = "+";
            }
            else if (studentGrade % 10 <3)
            {
                sign = "-";
            }
        }
        else if (studentGrade >=60)
        {
            letter = "D";
            if (studentGrade % 10 >= 7)
            {
                sign = "+";
            }
            else if (studentGrade % 10 <3)
            {
                sign = "-";
            }
        }
        else 
        {
            letter = "F";
            sign = "";
        }

        if (sign != "")
        {
            Console.WriteLine($"Your grade is: {letter}{sign}");
        }
        else
        {
            Console.WriteLine($"Your grade is {letter}");
        }

        if (studentGrade >= 70)
        {
            Console.WriteLine("Congratulation you passed the course");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass, work harder next time.");
        } 
    }
}