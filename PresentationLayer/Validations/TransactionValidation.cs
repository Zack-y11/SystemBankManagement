using CommonLayer.Entities;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class TransactionValidation : AbstractValidator<Transaction>
    {
        public TransactionValidation()
        {
            RuleFor(transaction => transaction.TypeTransaction)
           .NotEmpty().WithMessage("El tipo de transacción es requerido.")
           .Must(type => type == "Withdrawal" || type == "Deposit").WithMessage("El tipo de transacción debe ser 'Withdrawal' o 'Deposit'.");

            RuleFor(transaction => transaction.Amount)
                .GreaterThan(0).WithMessage("La cantidad debe ser mayor que cero.")
                .LessThanOrEqualTo(999999999999999.99m).WithMessage("La cantidad no puede ser mayor a 999999999999999.99.");

            RuleFor(transaction => transaction.Date)
                .NotEmpty().WithMessage("La fecha de la transacción es requerida.")
                .Must(BeAValidDate).WithMessage("La fecha no es válida.");

            RuleFor(transaction => transaction.Description)
                .MaximumLength(100).WithMessage("La descripción no debe exceder los 100 caracteres.");
            //valida que el accountNumber si corresponda a un AcountId
            RuleFor(transaction => transaction.AccountId)
                .NotEmpty().WithMessage("El número de cuenta es requerido.");
        }
        private bool BeAValidDate(string date)
        {
            return DateTime.TryParse(date, out _);
        }
    }
}
