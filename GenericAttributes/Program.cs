using GenericAttributes.Current;
using GenericAttributes.Previous;
using System.ComponentModel.DataAnnotations;

var previousCustomer = new PreviousCustomer
{
    Name = "Anh"
};

var context = new ValidationContext(previousCustomer);
var validationResults = new List<ValidationResult>();
bool isValid = Validator.TryValidateObject(instance: previousCustomer,
    validationContext: context,
    validationResults: validationResults,
    validateAllProperties: true);

Console.WriteLine(isValid);


var newCustomer = new NewCustomer
{
    Name = "Anh"
};

context = new ValidationContext(newCustomer);
validationResults.Clear();
isValid = Validator.TryValidateObject(instance: newCustomer,
    validationContext: context,
    validationResults: validationResults,
    validateAllProperties: true);

Console.WriteLine(isValid);