// initialize variables - graded assignments 
using System.Runtime.CompilerServices;

int currentAssignments = 5;

//Sophias Exam scores and total score
int [] sophiaExams = {90, 86, 87, 98, 100};
int sum = 0;
foreach (int score in sophiaExams)
{
    sum += score;
}
decimal sophiaTotal = (decimal) sum / currentAssignments;

//Andrews Exam scores and total score
int [] andrewExams = {92, 89, 81, 96, 90};
sum = 0;
foreach (int score in andrewExams)
{
    sum += score;
}
decimal andrewTotal = (decimal) sum / currentAssignments;

//Emmas Exam scores and total score
int [] emmaExams = {90, 85, 87, 98, 68};
sum = 0;
foreach (int score in emmaExams)
{
    sum += score;
}
decimal emmaTotal = (decimal) sum / currentAssignments;

//Logans Exam scores and total score
int [] loganExams = {90, 95, 87, 88, 68};
sum = 0;
foreach (int score in loganExams)
{
    sum += score;
}
decimal loganTotal = (decimal) sum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaTotal + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewTotal + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaTotal + "\tB");
Console.WriteLine("Logan:\t\t" + loganTotal + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();