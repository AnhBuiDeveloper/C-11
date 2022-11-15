using GenericAttributes.Entities;
using GenericAttributes.New;
using System.ComponentModel.DataAnnotations;

namespace GenericAttributes.Current
{
    internal class NewCustomer
    {
        [Required(ErrorMessage = "Name is required")]
        [GenericUniqueAttribute<CustomerDataContext, Customer>(propertyName: "Name", ErrorMessage = "Name is duplicate")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be 18 - 65")]
        public int Age { get; set; }
    }
}
