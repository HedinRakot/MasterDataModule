using MasterDataModule.API.Controllers;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;

namespace MasterDataModule.API.Controllers
{
    /// <summary>
    ///     DrlViewCollectionControllerFactory class
    /// </summary>
    public class DrlViewCollectionControllerFactory: ViewCollectionControllerFactoryBase
    {
        public void GetViewCollections(IDependencyResolver resolver, CollectionTypesModel model, Dictionary<string, IEnumerable<object>> result)
        {
            if (model.ExamClass)
            	result.Add("ExamClass", GetViewCollection<ExamClass, int, IExamClassManager>(
            		(IExamClassManager)resolver.GetService(typeof(IExamClassManager))));

            if (model.LegalBasis)
            	result.Add("LegalBasis", GetViewCollection<LegalBasis, int, ILegalBasisManager>(
            		(ILegalBasisManager)resolver.GetService(typeof(ILegalBasisManager))));

        }
    }
}
