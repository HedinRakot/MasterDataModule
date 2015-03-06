using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TuevSued.V1.IT.FE.DataAccess.Interfaces.MasterDataModule
{
    public static class FeDataContextRequestManager
	{
		public delegate IEntities FeDataContextRequestEventHandler();

		public static event FeDataContextRequestEventHandler DataContextRequest;

		public static IEntities GetDataContext()
		{
			lock (typeof(FeDataContextRequestManager))
			{
				if(DataContextRequest != null)
					return DataContextRequest();
			}

			return null;
		}
	}
}
