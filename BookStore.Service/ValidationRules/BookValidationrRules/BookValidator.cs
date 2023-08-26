using BookStore.Core.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.ValidationRules.BookDtoValidationrRules
{
	public class BookValidator:AbstractValidator<BookDto>
	{
        public BookValidator()
        {
          
            RuleFor(x => x.Title).NotNull().WithMessage("Kitap başlığı yazmak zorunludur.")
                .NotEmpty().WithMessage("Kitap alanı boş bırakılamaz.");
            RuleFor(x => x.Publisher).NotNull().WithMessage("Yayınevi alanı boş bırakılamaz.")
                .NotEmpty().WithMessage("Yayınevi alanı boş bırakılamaz.");
            RuleFor(x => x.PublishDate).NotNull().WithMessage("Yayın tarihi girilmesi zorunludur.")
                .NotEmpty().WithMessage("Yayın tarihi alanı boş bırakılamaz.");

        }
    }
}
