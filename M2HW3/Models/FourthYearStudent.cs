namespace M2HW3.Models
{
    public class FourthYearStudent : Student
    {
        public FourthYearStudent(string name, int age, bool isWorking, string studentTicket, int markForDiplomeWork) : base(name, age, isWorking, studentTicket)
        {
            MarkForDiplomeWork = markForDiplomeWork;
        }

        public int MarkForDiplomeWork { get; set; }

        public override void Studying()
        {
            Console.WriteLine("I study as fourth year student. I wrote diplome work.");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nIs working: {IsWorking}\nStudent's ticket: {StudentTicket}\nMark for diplome work: {MarkForDiplomeWork}";
        }
    }
}
