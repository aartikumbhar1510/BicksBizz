using System;
using System.Collections.Generic;

namespace bricksnetcoreapi.Models;

public partial class TblException
{
    public int ExceptionId { get; set; }

    public string? ExceptionType { get; set; }

    public string? ExceptionDetails { get; set; }

    public string? MethodName { get; set; }
}
