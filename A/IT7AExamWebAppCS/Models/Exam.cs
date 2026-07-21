using System;
using System.Collections.Generic;

namespace IT7AExamWebAppCS.Models;

public partial class Exam
{
    public int ExamId { get; set; }

    public string ExamName { get; set; } = null!;

    public int Marks { get; set; }
}
