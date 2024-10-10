using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class ClientValidation : AbstractValidator<Client>
    {
        public ClientValidation()
        {
            RuleFor(client => client.Name)
           .NotEmpty().WithMessage("El nombre es requerido.")
           .Length(1, 50).WithMessage("El nombre debe tener entre 1 y 50 caracteres.");

            RuleFor(client => client.Dui)
                .NotEmpty().WithMessage("El DUI es requerido.")
                .Length(10).WithMessage("El DUI debe tener exactamente 10 caracteres.");

            RuleFor(client => client.PhoneNumber)
                .NotEmpty().WithMessage("El número de teléfono es requerido.")
                .Matches(@"^\+?\d{8,12}$").WithMessage("El número de teléfono debe tener entre 8 y 12 dígitos.");

            RuleFor(client => client.Address)
                .NotEmpty().WithMessage("La dirección es requerida.")
                .Length(1, 50).WithMessage("La dirección debe tener entre 1 y 50 caracteres.");

            RuleFor(client => client.Password)
                .NotEmpty().WithMessage("La contraseña es requerida.")
                .MinimumLength(8).WithMessage("La contraseña debe tener al menos 8 caracteres.")
                .Matches(@"[A-Z]").WithMessage("La contraseña debe contener al menos una letra mayúscula.")
                .Matches(@"[a-z]").WithMessage("La contraseña debe contener al menos una letra minúscula.")
                .Matches(@"[0-9]").WithMessage("La contraseña debe contener al menos un número.")
                .Matches(@"[\W]").WithMessage("La contraseña debe contener al menos un carácter especial.");
        }

    }
}
