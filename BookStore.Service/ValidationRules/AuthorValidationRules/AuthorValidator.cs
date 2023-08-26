using BookStore.Core.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.ValidationRules.AuthorValidationRules
{
	public class AuthorValidator:AbstractValidator<AuthorDto>
	{
        public AuthorValidator()
        {
             RuleFor(x=> x.Name).NotEmpty().WithMessage("İsim alanı boş bırakılamaz.");
             RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz.");
      
        }
    }
}
