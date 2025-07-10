using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace inmind_lab3.Models;

public partial class Popularbook
{
    [Key]
    public string? Title { get; set; }

    public long? Tit { get; set; }
}
