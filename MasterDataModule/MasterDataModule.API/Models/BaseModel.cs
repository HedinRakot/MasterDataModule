using System;
using System.Runtime.Serialization;
using TuevSued.V1.IT.CoreBase.Entities.MasterDataModule;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Models
{
    [DataContract]
    public class BaseModel: IHasId<int>
    {
        [DataMember]		
        public int Id { get; set; }

        [DataMember]
        public DateTime ChangeDate { get; set; }
    }
}
