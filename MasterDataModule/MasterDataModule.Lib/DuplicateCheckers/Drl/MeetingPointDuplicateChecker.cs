
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class MeetingPointDuplicateChecker : BaseDuplicateChecker<MeetingPoint>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IMeetingPointManager> manager;
    
    		public MeetingPointDuplicateChecker (Lazy<IMeetingPointManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		protected override bool HasDuplicate(MeetingPoint entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.Name == entity.Name &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
