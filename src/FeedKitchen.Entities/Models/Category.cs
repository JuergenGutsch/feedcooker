﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FeedKitchen.Entities.Models;

public partial class Category
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long FixingId { get; set; }

    public virtual Fixing Fixing { get; set; }
}