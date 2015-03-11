namespace MasterDataModule.API
{
    public static class Configuration
    {
        public static int ConfigValue
        {
            get
            {
                var value = System.Configuration.ConfigurationManager.AppSettings["ConfigValue"];
                int result;

                if (!int.TryParse(value, out result))
                {
                    result = 10;
                }

                return result;
            }
        }
    }
}