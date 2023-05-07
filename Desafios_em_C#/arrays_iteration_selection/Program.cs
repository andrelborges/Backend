/* 


    Create a C# console application.

    Start with four students. Each student has five exam scores.

    Each exam score is an integer value, 0-100, where 100 represents 100% correct.

    A student's overall exam score is the average of their five exam scores.

    Criteria for extra credit assignments:
        Include extra credit assignment scores in the student's scores array.
        Extra credit assignments are worth 10% of an exam score (when calculating the final numeric grade).
        Add extra credit assignment scores to the student's total exam score before calculating the final numeric grade.

    Your application needs to automatically assign letter grades based on the calculated final score for each student.

    Your application needs to output/display each student’s name and formatted grade.

    Your application needs to support adding other students and scores with minimal impact to the code.
*/

//Adicionando 4 estudantes 


int currentAssignments = 5;

int sophia1 = 90;
int sophia2 = 86;
int sophia3 = 87;
int sophia4 = 98;
int sophia5 = 100;

int andrew1 = 92;
int andrew2 = 89;
int andrew3 = 81;
int andrew4 = 96;
int andrew5 = 90;

int emma1 = 90;
int emma2 = 85;
int emma3 = 87;
int emma4 = 98;
int emma5 = 68;

int logan1 = 90;
int logan2 = 95;
int logan3 = 87;
int logan4 = 88;
int logan5 = 96;

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;


sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();