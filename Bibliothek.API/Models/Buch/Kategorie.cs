﻿namespace Bibliothek.API.Models.Buch;

public class Kategorie
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = String.Empty;
}