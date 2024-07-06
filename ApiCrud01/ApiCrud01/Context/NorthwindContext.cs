using System;
using System.Collections.Generic;
using ApiCrud01.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud01.Context;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext()
    {
    }

    public NorthwindContext(DbContextOptions<NorthwindContext> options) : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

}
