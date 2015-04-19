
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class CoreDataProductDuplicateChecker : BaseDuplicateChecker<CoreDataProduct>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<ICoreDataProductManager> manager;
    
    		public CoreDataProductDuplicateChecker (Lazy<ICoreDataProductManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		public override string[] BusinessKeys 
    		{
    			get 
    			{
    				return new[] 
    				{
    					 "feProductNumber"
    				};
    			}
    		}
    
    		protected override bool HasDuplicate(CoreDataProduct entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.FeProductNumber == entity.FeProductNumber &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
