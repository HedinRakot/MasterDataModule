using System;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models.CommonMasterData
{
    internal class OrgAccountingAreaModel : IHasId<int>
    {
        public int Id { get; set; }
        public string AccountingArea { get; set; }

        public DateTime? DeleteDate { get; set; }
    }
}