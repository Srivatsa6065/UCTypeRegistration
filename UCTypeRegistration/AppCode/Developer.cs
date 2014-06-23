namespace UCTypeRegistration.AppCode
{
    public interface IDeveloper
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Salary { get; set; }
    }

    public class Developer : IDeveloper
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }
    }
}
