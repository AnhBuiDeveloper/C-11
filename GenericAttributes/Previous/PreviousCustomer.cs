using GenericAttributes.Entities;
using System.ComponentModel.DataAnnotations;

namespace GenericAttributes.Previous
{
    internal class PreviousCustomer
    {
        [Required(ErrorMessage = "Name is required")]
        [NonGenericUnique(typeof(CustomerDataContext), typeof(Customer), propertyName: "Name", ErrorMessage = "Name is duplicate")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be 18 - 65")]
        public int Age { get; set; }
    }
}
