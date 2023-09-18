namespace Week3InClassDemo.Common
{
    public class Student
    {
        public Student(int studentId, string firstName, string lastName, int grade)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            ExamGrade = grade;
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ExamGrade { get; set; }

        public override string ToString()
        {
            return $"Student->ID:{StudentId},FName:{FirstName},LName:{LastName},ExamGrade:{ExamGrade}";
        }
    }
}
