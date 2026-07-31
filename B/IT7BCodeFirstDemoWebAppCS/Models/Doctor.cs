namespace IT7BCodeFirstDemoWebAppCS.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public ICollection<Patient> patients { get; set; } = new List<Patient>();
    }
}
