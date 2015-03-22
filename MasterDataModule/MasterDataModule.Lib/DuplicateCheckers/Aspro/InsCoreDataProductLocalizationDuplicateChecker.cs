
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Aspro
{
    	public class InsCoreDataProductLocalizationDuplicateChecker : BaseDuplicateChecker<InsCoreDataProductLocalization>, IAsProDuplicateChecker
    	{
    		private readonly Lazy<IInsCoreDataProductLocalizationManager> manager;
    
    		public InsCoreDataProductLocalizationDuplicateChecker (Lazy<IInsCoreDataProductLocalizationManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(InsCoreDataProductLocalization entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.InsCoreDataProductId == entity.InsCoreDataProductId &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
