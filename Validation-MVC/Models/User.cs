using Microsoft.AspNetCore.Mvc;
using Validation_MVC.Validators.DataAnnotation;

namespace Validation_MVC.Models;

[ModelMetadataType(typeof(UserValidator))]
public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

}