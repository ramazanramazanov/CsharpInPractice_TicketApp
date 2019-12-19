using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemApp.Core
{
  public  class EntityValidator
    {
        public IEnumerable<ValidationResult> Validate(object obj)
        {
            List<ValidationResult> errorResult = new List<ValidationResult>();
            ValidationContext con = new ValidationContext(obj);
            if (!Validator.TryValidateObject(obj, con, errorResult, true))
            {
                return errorResult;
            }
            return default(List<ValidationResult>);

        }

    }
}
