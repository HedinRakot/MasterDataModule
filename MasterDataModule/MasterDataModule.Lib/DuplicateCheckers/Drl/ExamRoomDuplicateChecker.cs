
using MasterDataModule.Contracts.Entities;
using MasterDataModule.Contracts.Managers;
using MasterDataModule.Lib.DuplicateCheckers.Base;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using System;
using System.Linq;
namespace MasterDataModule.Lib.DuplicateCheckers.Drl
{
    	public class ExamRoomDuplicateChecker : BaseDuplicateChecker<ExamRoom>, IDrlDuplicateChecker
    	{
    		private readonly Lazy<IExamRoomManager> manager;
    
    		public ExamRoomDuplicateChecker (Lazy<IExamRoomManager> manager)
    		{
    			this.manager = manager;
    		}
    
    		public override string[] BusinessKeys 
    		{
    			get 
    			{
    				return new[] 
    				{
    					 "roomNumber"
    				};
    			}
    		}
    
    		protected override bool HasDuplicate(ExamRoom entity)
    		{
    			var query = manager.Value.GetEntities().Where(o => o.Id != entity.Id &&
    						o.RoomNumber == entity.RoomNumber &&
    											o.FromDate <= entity.ToDate && o.ToDate >= entity.FromDate);
    						 return query.Any();
    		}
    	}
}
