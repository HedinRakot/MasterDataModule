using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

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
                var result = "";

                if (CoreDataProductLocalizations != null && CoreDataProductLocalizations.Count != 0)
                {
                    result = CoreDataProductLocalizations.FirstOrDefault().ProductName;
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

                if (CoreDataProductLocalizations != null && CoreDataProductLocalizations.Count != 0)
                {
                    result = CoreDataProductLocalizations.FirstOrDefault().Description;
                }

                return result;
            }
        }

        /// <summary>
        /// Ins core data product Name
        /// </summary>
        public virtual string InsCoreDataProductName
        {
            get
            {
                //TODO?
                var result = String.Empty;
                var insCoreDataProductManager = (IInsCoreDataProductManager)GlobalConfiguration.Configuration.
                DependencyResolver.GetService(typeof(IInsCoreDataProductManager));
                var insCoreDataProduct = insCoreDataProductManager.GetById(InsCoreDataProductId);
                if (insCoreDataProduct != null)
                {
                    result = insCoreDataProduct.ProductName;
                }
                return result;
            }
        }
    }
}
