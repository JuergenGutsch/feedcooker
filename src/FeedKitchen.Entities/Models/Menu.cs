﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FeedKitchen.Entities.Models;

public partial class Menu
{
    public long Id { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime LastUpdate { get; set; }

    public string Url { get; set; }

    public long AuthorId { get; set; }

    public long RecipeId { get; set; }

    public virtual Author Author { get; set; }
}