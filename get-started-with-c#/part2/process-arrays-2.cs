partial class Part2
{
    public static void processArrays2()
    {

        /* 
        int examAssignments = 5;

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

        int[] studentScores = new int[10];

        string currentStudentLetterGrade = "";

        Console.Clear();
        Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Sophia")
                studentScores = sophiaScores;

            else if (currentStudent == "Andrew")
                studentScores = andrewScores;

            else if (currentStudent == "Emma")
                studentScores = emmaScores;

            else if (currentStudent == "Logan")
                studentScores = loganScores;

            int gradedAssignments = 0;
            int sumAssignmentScores = 0;
            int extraCreditScores = 0;

            foreach (int score in studentScores)
            {
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                    sumAssignmentScores += score;

                else
                    extraCreditScores += score;
            }

            decimal extraCreditScore = (decimal)(extraCreditScores) / (studentScores.Length - examAssignments);
            decimal extraCreditPoints = (decimal)extraCreditScores / 10 / 5;
            decimal currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
            decimal studentOverallGrade = currentStudentGrade + extraCreditPoints;

            if (studentOverallGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (studentOverallGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (studentOverallGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (studentOverallGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (studentOverallGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (studentOverallGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (studentOverallGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (studentOverallGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (studentOverallGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (studentOverallGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (studentOverallGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (studentOverallGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t\t{studentOverallGrade}\t{currentStudentLetterGrade}\t{extraCreditScore} ({extraCreditPoints} pts)");
        }
        */

    }
}
