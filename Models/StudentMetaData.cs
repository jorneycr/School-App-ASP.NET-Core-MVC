using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class StudentMetadata
{
    [Display(Name = "First Name")]
    [StringLength(50)]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Birth")]
    public DateTime? DateOfBirth { get; set; }
}

[ModelMetadataType(typeof(StudentMetadata))]
public partial class Student { }