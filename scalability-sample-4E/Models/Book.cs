using System;
using System.Collections.Generic;

namespace scalability_sample_4E.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string? Published { get; set; }

    public string? Isbn { get; set; }
}
