using System;
using System.Collections.Generic;

namespace IT7BTestManagerWenAppCS.Models;

public partial class Test
{
    public int TestId { get; set; }

    public string TestName { get; set; } = null!;

    public int Marks { get; set; }
}
