using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MasterDataModule.Contracts;
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Contracts.Managers.Base;
using System.Web.Http.Dependencies;


namespace MasterDataModule.API.Controllers
{
    public partial class CollectionTypesModel
    {
        public bool Permission { get; set;}
        public bool Role { get; set; }
        public bool EditModeType { get; set; }
        public bool AssignationType { get; set; }
        public bool ExamType { get; set; }
    }

    public class IdNameModel<TId>
        where TId : struct, IEquatable<TId>
    {
        public TId id { get; set; }
        public string name { get; set; }
    }

    public class ViewCollectionController: ApiController
    {
        public ViewCollectionController()
        {
        }

        [Authorize]
        public IHttpActionResult Get([FromUri] CollectionTypesModel model)
        {
            if (model == null)
                return NotFound();

            var result = new Dictionary<string, IEnumerable<object>>();

            new CommonViewCollectionControllerFactory().GetViewCollections(
                GlobalConfiguration.Configuration.DependencyResolver, model, result);

            new TPViewCollectionControllerFactory().GetViewCollections(
                GlobalConfiguration.Configuration.DependencyResolver, model, result);

            new DrlViewCollectionControllerFactory().GetViewCollections(
                GlobalConfiguration.Configuration.DependencyResolver, model, result);

            new MasterDataViewCollectionControllerFactory().GetViewCollections(
                GlobalConfiguration.Configuration.DependencyResolver, model, result);

            //TODO localize
            if (model.EditModeType)
                result.Add("EditModeType", new[]
                {
                    new { id = 0, name = "nur lesen"},
                    new { id = 1, name = "editieren"},
                    new { id = 2, name = "editieren/anlegen"},
                    new { id = 3, name = "editieren/anlegen/löschen"},
                });

            if (model.AssignationType)
                result.Add("AssignationType", new[]
                {
                    new { id = 0, name = "Erweiterung"},
                    new { id = 1, name = "Ersterteilung"},
                    new { id = 2, name = "--"},
                });

            if (model.ExamType)
                result.Add("ExamType", new[]
                {
                    new { id = 1, name = "Theorie"},
                    new { id = 2, name = "Praxis"},
                });
			
			return Ok(result);
        }
    }
}
