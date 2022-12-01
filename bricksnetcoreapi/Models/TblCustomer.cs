using System;
using System.Collections.Generic;

namespace bricksnetcoreapi.Models;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public string? CustomerContact { get; set; }

    public string? CustomerStatus { get; set; }

    public string? CustomerUserid { get; set; }

    public string? CustomerPwd { get; set; }
}
