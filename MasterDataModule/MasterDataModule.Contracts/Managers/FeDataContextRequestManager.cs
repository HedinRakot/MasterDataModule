namespace MasterDataModule.Contracts.Managers
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
