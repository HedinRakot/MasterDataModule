
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Aspro
{
    	public class EmpEmployeeDuplicateChecker : BaseDuplicateChecker<EmpEmployee>, IAsProDuplicateChecker
    	{
    		private readonly Lazy<IEmpEmployeeManager> manager;
    
    		public EmpEmployeeDuplicateChecker (Lazy<IEmpEmployeeManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(EmpEmployee entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.PersonalNumber == entity.PersonalNumber &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
