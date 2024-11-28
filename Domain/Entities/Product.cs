using System;

namespace Domain.Entities
{
    public class Product
    {
        public Guid Id { get; protected set; }
        public string Description { get; protected set; }

        public Product(Guid id, string description)
        {
            Id = id;
            Description = description;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(Description))
                throw new Exception("Description é obrigatório");
        }

        public void SetId(Guid id)
            => Id = id;
    }
}
