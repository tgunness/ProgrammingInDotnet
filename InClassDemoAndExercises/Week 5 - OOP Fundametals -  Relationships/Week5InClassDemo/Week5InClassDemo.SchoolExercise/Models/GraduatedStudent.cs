namespace Week5InClassDemo.SchoolExercise
{
    public class GraduatedStudent : Student
    {
        public override bool HasGraduated()
        {
            IsGraduated = true;
            return IsGraduated;
        }
    }
}
