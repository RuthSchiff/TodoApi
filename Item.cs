using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class Item
{
    public int Id { get; set; }

    public string? NameT { get; set; }

    public sbyte IsComplete { get; set; }

    public int? UserId { get; set; }
}
