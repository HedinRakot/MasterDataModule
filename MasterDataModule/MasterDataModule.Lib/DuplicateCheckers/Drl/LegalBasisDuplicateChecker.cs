
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class LegalBasisDuplicateChecker : BaseDuplicateChecker<LegalBasis>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<ILegalBasisManager> manager;
    
    		public LegalBasisDuplicateChecker (Lazy<ILegalBasisManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(LegalBasis entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Name == entity.Name &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
