using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Models;

[Table("document_types")]
public class DocumentType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(50, ErrorMessage = "Name field musn't be higher than {1} characters.")]
    public required string Name { get; set; }
    [Column("abbreviation")]
    [MinLength(2, ErrorMessage = "Abbreviation field musn't be lower than {1} characters.")]
    [MaxLength(10, ErrorMessage = "Abbreviation field musn't be higher than {1} characters.")]
    public required string Abbreviation { get; set; }
    [Column("description")]
    [MaxLength(500, ErrorMessage = "Description field musn't be higher than {1} characters.")]
    public string? Description { get; set; }
}
