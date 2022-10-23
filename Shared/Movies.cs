using System;
using System.ComponentModel.DataAnnotations;

namespace blazorsample02.Shared;

public class Movies
{
    [Key]
    public int Id { get; set; }
    public string? Movie_Name { get; set; }
    public string? Director { get; set; }
    public string? Year { get; set; }

}