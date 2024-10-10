using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class AccountValidation : AbstractValidator<Account>
    {
        public AccountValidation()
        {
            RuleFor(account => account.AccountNumber)
            .NotEmpty().WithMessage("El número de cuenta es requerido.")
            .Matches(@"^ACC\d{7}$").WithMessage("El número de cuenta debe comenzar con 'ACC' seguido de 5 dígitos.");

            RuleFor(account => account.Saldo)
                .GreaterThan(0).WithMessage("El saldo debe ser mayor que cero.")
                .LessThanOrEqualTo(999999999999999.99m).WithMessage("El saldo no puede ser mayor a 999999999999999.99.");

            RuleFor(account => account.OpenDateAccount)
                .NotEmpty().WithMessage("La fecha de apertura es requerida.");

            RuleFor(account => account.AccountTypeId)
                .GreaterThan(0).WithMessage("El tipo de cuenta es requerido.");

            RuleFor(account => account.ClientId)
                .GreaterThan(0).WithMessage("El cliente es requerido.");
        }
    }
}
