using System;
using System.Collections.Generic;

namespace bricksnetcoreapi.Models;

public partial class TblCustomerArchive
{
    public int ArchId { get; set; }

    public int CustomerId { get; set; }

    public string? CustomerOldName { get; set; }

    public string? CustomerNewName { get; set; }
}
