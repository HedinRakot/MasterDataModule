using MasterDataModule.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MasterDataModule.Contracts.Entities
{
    /// <summary>
    ///     EN: 5.3.5.15 Product - assign Additional Details  DE: 5.3.5.15 Produkt - FE-Zusatzdaten zuordnen
    /// </summary>
    public partial class InsCoreDataProduct
    {
        /// <summary>
        /// Navigation property to object INS_CORE_DATA_PRODUCT_LOCALIZATION. Comment: EN: Ins core data product localization  
        /// </summary>
        public virtual ICollection<InsCoreDataProductLocalization> InsCoreDataProductLocalizations { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductName
        {
            get
            {
                //TODO
                var result = "";

                if (InsCoreDataProductLocalizations != null && InsCoreDataProductLocalizations.Count != 0)
                {
                    result = InsCoreDataProductLocalizations.FirstOrDefault().ProductName;
                }

                return result;
            }
        }

        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductDescription
        {
            get
            {
                //TODO
                var result = "";

                if (InsCoreDataProductLocalizations != null && InsCoreDataProductLocalizations.Count != 0)
                {
                    result = InsCoreDataProductLocalizations.FirstOrDefault().Description;
                }

                return result;
            }
        }
    }
}
