using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuevSued.V1.IT.FE.MasterDataModule.API
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
                    result = 10;

                return result;
            }
        }
    }
}
