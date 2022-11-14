using System.ComponentModel.DataAnnotations;

namespace GenericAttributes.Previous
{
    internal class PreviousCustomer
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 65, ErrorMessage = "Age must be 18 - 65")]
        public int Age { get; set; }
    }
}
