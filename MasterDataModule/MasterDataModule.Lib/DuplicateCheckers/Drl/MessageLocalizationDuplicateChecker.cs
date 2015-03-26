
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class MessageLocalizationDuplicateChecker : BaseDuplicateChecker<MessageLocalization>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IMessageLocalizationManager> manager;
    
    		public MessageLocalizationDuplicateChecker (Lazy<IMessageLocalizationManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(MessageLocalization entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.ValidationErrorNumber == entity.ValidationErrorNumber &&
    										 true);
    						 return query.Any();
    		}
    	}
}
