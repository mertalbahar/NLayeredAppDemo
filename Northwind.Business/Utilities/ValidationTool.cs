using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<T>(IValidator<T> validator, T entity)
        {
            var result = validator.Validate(new ValidationContext<T>(entity));

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
