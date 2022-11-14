using GenericAttributes.Previous;
using System.ComponentModel.DataAnnotations;

var previousCustomer = new PreviousCustomer();

var context = new ValidationContext(previousCustomer);
var validationResults = new List<ValidationResult>();
bool isValid = Validator.TryValidateObject(previousCustomer, context, validationResults, true);

Console.WriteLine(isValid);