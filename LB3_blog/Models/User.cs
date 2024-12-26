﻿using System;
using System.Collections.Generic;

namespace LB3_blog.Models;

public partial class User
{
    public short Id { get; set; }

    public string Nickname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public DateOnly? Birthday { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
}
