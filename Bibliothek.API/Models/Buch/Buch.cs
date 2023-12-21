﻿using Bibliothek.API.Models.Ausweis;

namespace Bibliothek.API.Models.Buch;

public class Buch
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100)]
    [Required]
    public string Titel { get; set; } = String.Empty;

    [Required]
    [MaxLength(20)]
    public string ISBN { get; set; } = String.Empty;

    [Required]
    [NotMapped]
    [DataType(DataType.Date)]
    public DateOnly Erscheinungsdatum { get; set; } = new DateOnly();

    public Herausgeber Herausgeber { get; set; }

    public Kategorie Kategorie { get; set; }

    public Sprache Sprache { get; set; }

    public Author.Author Author { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}