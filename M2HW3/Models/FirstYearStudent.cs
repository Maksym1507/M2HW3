namespace M2HW3.Models
{
    internal class FirstYearStudent : Student
    {
        public FirstYearStudent(string name, int age, bool isWork, string studentTicket, int markForCourseWork) : base(name, age, isWork, studentTicket)
        {
            MarkForCourseWork = markForCourseWork;
        }

        public int MarkForCourseWork { get; set; }

        public override void Studying()
        {
            Console.WriteLine("I study as first year student. I wrote course work.");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nIs working: {IsWorking}\nStudent's ticket: {StudentTicket}\nMark for course work: {MarkForCourseWork}";
        }
    }
}
