using System;

namespace Domain.Entities
{
    public class Order
    {
        public Guid Id { get; protected set; }
        public string CustomerName { get; protected set; }
        public int Status { get; protected set; }
        public DateTime Date { get; protected set; }

        public Order(Guid id, string customerName, int status, DateTime date)
        {
            Id = id;
            CustomerName = customerName;
            Status = status;
            Date = date;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(CustomerName))
                throw new Exception("CustomerName é obrigatório");

            if (Status < 0)
                throw new Exception("Status é obrigatório");

            if (Date == DateTime.MinValue)
                throw new Exception("Date é obrigatório");
        }

        public void SetId(Guid id)
            => Id = id;
    }
}
