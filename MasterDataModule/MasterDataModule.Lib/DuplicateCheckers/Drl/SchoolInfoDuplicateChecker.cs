
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class SchoolInfoDuplicateChecker : BaseDuplicateChecker<SchoolInfo>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<ISchoolInfoManager> manager;
    
    		public SchoolInfoDuplicateChecker (Lazy<ISchoolInfoManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(SchoolInfo entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Text == entity.Text &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
