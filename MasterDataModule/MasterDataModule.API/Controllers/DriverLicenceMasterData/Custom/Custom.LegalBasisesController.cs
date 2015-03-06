using TuevSued.V1.IT.FE.MasterDataModule.API.Models.DriverLicenceMasterData;
using TuevSued.V1.IT.FE.MasterDataModule.API.Security;
using TuevSued.V1.IT.FE.MasterDataModule.API.SystemLog;
using System.Linq;
using System;
using System.Collections.Generic;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.DriverLicenceMasterData;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Controllers.DriverLicenceMasterData
{
    public partial class LegalBasisesController
    {
        protected override void Validate(LegalBasisModel model, LegalBasis entity, ActionTypes actionType)
        {
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