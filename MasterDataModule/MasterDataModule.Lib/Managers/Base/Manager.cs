using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TuevSued.V1.IT.FE.DataAccess.Interfaces;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule;
using TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule.Base;

namespace TuevSued.V1.IT.FE.MasterDataModule.Lib.Managers.Base
{
    /// <summary>
    /// 
    /// </summary>
	public abstract class Manager : IManager
	{
		#region Constructors
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
		protected Manager(IEntities context)
			:base()
		{
			if (context == null)
			{
				throw new ArgumentNullException();
			}

			DataContext = context;
		} 

		#endregion

		#region Properties

        /// <summary>
        /// 
        /// </summary>
		public IEntities DataContext
		{
			get;
			set;
		}

		#endregion

		#region Methods

        /// <summary>
        /// 
        /// </summary>
		public virtual void SaveChanges()
		{
			DataContext.SaveChanges();
		}

		#endregion
	}
}
