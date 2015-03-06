using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    public partial class ExamClassesController
    {
        protected override void Validate(ExamClassModel model, ExamClass entity, ActionTypes actionType)
        {
            if (!string.IsNullOrWhiteSpace(model.name))
            {
                var existingEntity = Manager.GetEntities(o => !o.DeleteDate.HasValue &&
                    o.Name.Equals(model.name.ToLower(), 
                    StringComparison.InvariantCultureIgnoreCase) && o.Id != model.Id &&
                    o.FromDate <= DateTime.Now && DateTime.Now <= o.ToDate).FirstOrDefault();

                if (existingEntity != null)
                {
                    //TODO localize
                    ModelState.AddModelError("model.name", "Klasse muss eindeutig im System sein");
                }
            }
        }

        protected override string BuildWhereClause<T>(Filter filter)
        {
            if (filter.Field == "name")
            {
                var clauses = new List<string>();

                    clauses.AddRange(new[] { 
						base.BuildWhereClause<T>(new Filter { Field = "Name", Operator = filter.Operator, Value = filter.Value }),
						base.BuildWhereClause<T>(new Filter { Field = "Description", Operator = filter.Operator, 
                            Value = filter.Value }),
					});

                return string.Join(" or ", clauses);
            }

            return base.BuildWhereClause<T>(filter);
        }
    }
}