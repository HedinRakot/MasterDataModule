using System;
using System.Collections.Generic;
using System.Linq;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule.Common;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Common;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Data;
using TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Common
{
    /// <summary>
    /// 
    /// </summary>
    public class EmpEmployeeSysRoleRspManager : EntityManager<EmpEmployeeSysRoleRsp, int>, IEmpEmployeeSysRoleRspManager
	{
        public EmpEmployeeSysRoleRspManager(IASProEntities context) :
            base(context)
        {
        }
	}
}
