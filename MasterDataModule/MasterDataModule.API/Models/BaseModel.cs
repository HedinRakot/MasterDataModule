using System.Runtime.Serialization;
using MasterDataModule.Contracts;

namespace MasterDataModule.API.Models
{
    [DataContract]
    public class BaseModel: IHasId<int>
    {
        [DataMember]		
        public int Id { get; set; }
    }
}
