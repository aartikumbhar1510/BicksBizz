﻿using System;
using System.Collections.Generic;

namespace bricksnetcoreapi.Models;

public partial class TblUser
{
    public int Userid { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Status { get; set; }
}
