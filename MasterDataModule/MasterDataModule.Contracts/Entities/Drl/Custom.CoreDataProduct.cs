using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     EN: 5.3.5.15 Product - assign Additional Details  DE: 5.3.5.15 Produkt - FE-Zusatzdaten zuordnen
    /// </summary>
    public partial class CoreDataProduct
    {
        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductName
        {
            get
            {
                //TODO
                var result = "TODO";

                if (CoreDataProductLocalizations != null && CoreDataProductLocalizations.Count != 0)
                {
                    result = CoreDataProductLocalizations.FirstOrDefault().ProductName;
                }

                return result;
            }
        }
    }
}
