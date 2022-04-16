/**
  Problem: Punish the Students 
    A Professor conducts a Computer Science paper for N students. He had strictly instructed all students to sit according to their roll numbers. 
    However when he started checking the papers, he found out that all the papers were randomly ordered because the students had sat randomly during the exam instead of sitting according to their roll numbers. The order is given in list of integers roll[ ]. The professor became very angry and he wanted to teach the students a lesson.
    He decided to sort the papers according to roll numbers by Bubble Sort and count the number of swaps required for each and every student and deduct as many marks of a student as were the number of swaps required for that student. The marks of every student is given in list of integers marks[ ] in the order in which they were sitting. However he also has to maintain the class average greater than or equal to a set minimum avg, else he may lose his job. The Professor wants to know whether he should punish the students or save his job.
*/
class ExerciseA
{
    public static int shouldPunish(int roll[], int marks[], int n, double avg)
    {
        double totalScore = 0;
        for(int x : marks)
        {
            totalScore += x;
        }
    
        for(int i = 0; i < n -1 ; i++)
        {
            for(int j = 0; j < n -i -1; j++)
            {
                if (roll[j] > roll[j+1])
                {
                    int temp = roll[j];
                    roll[j] = roll[j+1];
                    roll[j+1] = temp;
                    
                    int temp2 = marks[j];
                    marks[j] = marks[j+1] - 1;
                    marks[j+1] = temp2 - 1;
                    totalScore -= 2;
                    if ((totalScore / n) < avg)
                    {
                        return 0;
                    }
                }
            }
        }
        return 1;
    }

    public static void main(String[] args)
    {
        int[] roll = new int[]{3, 2, 4, 1, 5};
        int[] marks = new int[]{50, 67, 89, 79, 58};
        int minAvg = 68;
        int result = shouldPunish(roll, marks, roll.length, minAvg);
        System.out.println(String.format("Result: %d", result));
    }
}

/**
Output:  
  Result: 0

Online Resource: 
  https://www.geeksforgeeks.org/bubble-sort/
  https://practice.geeksforgeeks.org/problems/punish-the-students5726/1/#
*/