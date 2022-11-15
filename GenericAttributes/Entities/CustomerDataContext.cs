namespace GenericAttributes.Entities
{
    internal class CustomerDataContext
    {
        private readonly List<Customer> customers = new()
        {
            new Customer { Name = "Anh", Age = 40 },
            new Customer { Name = "Nghia", Age = 39 },
            new Customer { Name = "Tin", Age = 36 },
        };

        public List<Customer> GetAll() => customers;
    }
}