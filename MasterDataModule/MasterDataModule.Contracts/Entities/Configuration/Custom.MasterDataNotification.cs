using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDataModule.Contracts.Entities.Configuration
{
    public partial class MasterDataNotifications
    {
        public string Name
        {
            get
            {
                var result = "";
                switch(NotificationType)
                {
                    case 1:
                        result = "Email ";
                        break;
                }
                return String.Format("{0}{1}", result, 
                    !String.IsNullOrEmpty(Subject) ? " (" + Subject + ")" : String.Empty);
            }
        }
    }
}
