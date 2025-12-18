// initialize variables - graded assignments 
using System.Runtime.CompilerServices;

int currentAssignments = 5;

int [] sophiaExams = {90, 86, 87, 98, 100, 94, 90};
int [] andrewExams = {92, 89, 81, 96, 90, 89};
int [] emmaExams = {90, 85, 87, 98, 68, 89, 89, 89};
int [] loganExams = {90, 95, 87, 88, 96, 96};
int [] beckyExams = {92, 91, 90, 91, 92, 92, 92};
int [] chrisExams = {84, 86, 88, 90, 92, 94, 96, 98};
int [] ericExams = {80, 90, 100, 80, 90, 100, 80, 90};
int [] gregorExams = {91, 91, 91, 91, 91, 91, 91};

string [] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

Console.WriteLine("Students\tScore\tGrade");
Console.WriteLine("-----------------------------");

foreach (string name in studentNames)
{
    decimal sum = 0;
    int count = 0;
    int [] currentScore;

    if (name == "Sophia")
    currentScore = sophiaExams;
    else if (name == "Andrew")
    currentScore = andrewExams;
    else if (name == "Logan")
    currentScore = loganExams;
    else if (name == "Emma") 
    currentScore = emmaExams;
    else if (name == "Becky")
    currentScore = beckyExams;
    else if (name == "Chris")
    currentScore = chrisExams;
    else if (name == "Eric")
    currentScore = ericExams;
    else
    currentScore = gregorExams;

    foreach (int score in currentScore)
    {
        count ++;
        if (count <= currentAssignments)
        {
            sum += score;
        }
        else
        {
            sum += (decimal) score / 10;
        }
    }
    decimal currentAverage = sum / currentAssignments;
    string letterGrade = "";

    if (currentAverage >= 97)
    letterGrade = "A+";
    else if (currentAverage >= 93)
    letterGrade = "A";
    else if (currentAverage >= 90)
    letterGrade = "A-";
    else if (currentAverage >= 87)
    letterGrade = "B+";
    else if (currentAverage >= 83)
    letterGrade = "B";
    else if (currentAverage >= 80)
    letterGrade = "B-";
    else if (currentAverage >= 77)
    letterGrade = "C+";
    else if (currentAverage >= 73)
    letterGrade = "C";
    else if (currentAverage >= 70)
    letterGrade = "C-";
    else if (currentAverage >= 67)
    letterGrade = "D+";
    else if (currentAverage >= 63)
    letterGrade = "D";
    else if (currentAverage >= 60)
    letterGrade = "D-";
    else 
    letterGrade = "F";
    Console.WriteLine($"{name}\t\t{currentAverage}\t{letterGrade}");
}
Console.WriteLine("Press Enter to continue");
Console.ReadLine();

// Assigning Grades to the score.
