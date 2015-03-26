
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class LanguageDuplicateChecker : BaseDuplicateChecker<Language>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<ILanguageManager> manager;
    
    		public LanguageDuplicateChecker (Lazy<ILanguageManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(Language entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.SysLanguageId == entity.SysLanguageId &&
    							o.OldAbbr == entity.OldAbbr &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
