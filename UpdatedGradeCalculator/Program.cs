

decimal totalAssignment = 5m;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor", "Test", "Test2" };
int[] studentScores = new int[10];

int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScroes = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };  
int[] testScores = new int[] {85, 65, 45, 78, 69, 45, 78, 35, 35};
int[] test2Scores = new int[] {98, 45, 45, 63, 75, 100};
Console.WriteLine("Student\t\tGrade\t\tOverall\t\tGrade\t\tExtra Credit\n");
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
    else if (currentStudent == "Test")
        studentScores = testScores;
    else
        continue;

    int gradedAssignments = 0;
    string studentScale = "";
    int sumAssignmentScores = 0;
    decimal currentStudentGrade = 0;
    int baseStudentGrade = 0;
    int extraAssignmentCount = 0;
    //decimal extraAssignmentScores = 0;
    decimal mereStudentGrade = 0;
    int sumExtra = 0;
    foreach (int score in studentScores)
    {
        gradedAssignments ++;
        if (gradedAssignments <= totalAssignment)
        { 
            sumAssignmentScores += score;
            baseStudentGrade += score;
        }
        else
        {    
            extraAssignmentCount++;
            sumAssignmentScores += score/10;
            sumExtra+=score;
        }
        //if (gradedAssignments > totalAssignment)
        //    sumExtra += score;
    }
    sumExtra = sumExtra/extraAssignmentCount;
    //extraAssignmentScores = (sumAssignmentScores - (decimal)baseStudentGrade)*10/extraAssignmentCount;
    mereStudentGrade = (decimal)baseStudentGrade / totalAssignment;
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

    Console.WriteLine($"{currentStudent}:\t\t{mereStudentGrade}\t\t{currentStudentGrade}\t\t{studentScale}\t\t{sumExtra} ({currentStudentGrade-mereStudentGrade})");
}
//Console.WriteLine("Press enter key to continue");
//Console.ReadLine();

