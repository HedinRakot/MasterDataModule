using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDataModule.Contracts.Exceptions
{
    /// <summary>
    /// Duplicate Entity Exception
    /// </summary>
    public class DuplicateEntityException : DbEntityValidationException
    {
        public DuplicateEntityException(string message) :
            base(message)
        {

        }
    }
}
