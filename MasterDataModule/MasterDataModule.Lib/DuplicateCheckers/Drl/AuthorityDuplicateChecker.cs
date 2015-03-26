
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class AuthorityDuplicateChecker : BaseDuplicateChecker<Authority>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IAuthorityManager> manager;
    
    		public AuthorityDuplicateChecker (Lazy<IAuthorityManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(Authority entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.AuthorityNumber == entity.AuthorityNumber &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
