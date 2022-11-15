using GenericAttributes.Previous;
using System.ComponentModel.DataAnnotations;

var previousCustomer = new PreviousCustomer
{
    Name = "Tri"
};

var context = new ValidationContext(previousCustomer);
var validationResults = new List<ValidationResult>();
bool isValid = Validator.TryValidateObject(instance: previousCustomer,
    validationContext: context,
    validationResults: validationResults,
    validateAllProperties: true);

Console.WriteLine(isValid);