namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }

        public string LetterGrade
        {
            get
            {
                double letterGrade = (double)EarnedMarks / (double)PossibleMarks;

                if (letterGrade >= .90)
                {
                    return "A";
                }
                else if (letterGrade >= .80)
                {
                    return "B";
                }
                else if (letterGrade >= .70)
                {
                    return "C";
                }
                else if (letterGrade >= .60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }
        public HomeworkAssignment (int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }
    }
}
