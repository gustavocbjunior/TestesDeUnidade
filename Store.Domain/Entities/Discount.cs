using System;
using Flunt.Validations;

namespace Store.Domain.Entities
{
    public class Discount : Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            AddNotifications(
                new Contract<Discount>()
                    .Requires()
                    .IsGreaterThan(DateTime.Now, ExpireDate, "ExpireDate", "Desconto expirado")
            );

            Amount = amount;
            ExpireDate = expireDate;
        }

        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        public decimal Value()
        {
            if (IsValid)
                return Amount;
            else
                return 0;
        }
    }
}