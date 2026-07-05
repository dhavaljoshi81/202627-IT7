namespace RecordTypeDemoMVCWebAPPCS7A.Models
{
    public record EmpR (string Name, int Age, string Designation);


    public struct EmpStruct
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
