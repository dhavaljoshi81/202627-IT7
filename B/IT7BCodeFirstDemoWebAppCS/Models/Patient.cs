namespace IT7BCodeFirstDemoWebAppCS.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

    }
}
