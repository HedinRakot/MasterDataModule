using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.Entities.MasterDataModule.Common
{
    public class OrgAccountingArea : IHasId<int>, IRemovable
    {
        public int Id { get; set; }
        public string AccountingArea { get; set; }

        public DateTime? DeleteDate { get; set; }

        public class Fields
        {
            /// <summary>
            /// 
            /// </summary>
            public static readonly string Id = "ID";
            /// <summary>
            /// 
            /// </summary>
            public static readonly string AccountingArea = "ACCOUNTING_AREA";

            /// <summary>
            /// 
            /// </summary>
            public static readonly string DeleteDate = "DELETE_DATE";
        }
    }
}
