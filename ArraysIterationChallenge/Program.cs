int totalAssignment = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];

int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScroes = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };  

Console.WriteLine("Student\t\tGrade\n");
foreach (string name in studentNames)
{
    string currentStudent = name;
    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScroes;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int gradedAssignments = 0;
    string studentScale = "";
    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments ++;
        if (gradedAssignments <= totalAssignment)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score/10;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / totalAssignment;
    if (currentStudentGrade >= 97)
        studentScale = "A+";
    else if (currentStudentGrade >= 93)
        studentScale = "A";
    else if (currentStudentGrade >= 90)
        studentScale = "A-";
    else if (currentStudentGrade >= 87)
        studentScale = "B+";
    else if (currentStudentGrade >= 83)
        studentScale = "B";
    else if (currentStudentGrade >= 80)
        studentScale = "B-";
    else if (currentStudentGrade >= 77)
        studentScale = "C+";
    else if (currentStudentGrade >= 73)
        studentScale = "C";
    else if (currentStudentGrade >= 70)
        studentScale = "C-";
    else if (currentStudentGrade >= 67)
        studentScale = "D+";
    else if (currentStudentGrade >= 63)
        studentScale = "D";
    else if (currentStudentGrade >= 60)
        studentScale = "D-";
    else
        studentScale = "F";

    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{studentScale}");
}
Console.WriteLine("Press enter key to continue");
Console.ReadLine();

/*
Console.WriteLine("Student\t\tGrade");
Console.WriteLine($"Sophia:\t\t{sophiaAvr}");
Console.WriteLine($"Andrew:\t\t{andrewAvr}");
Console.WriteLine($"Emma:\t\t{emmaAvr}");
Console.WriteLine($"Logan:\t\t{loganAvr}");
*/