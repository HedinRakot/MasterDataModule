using System.ComponentModel.DataAnnotations.Schema;

namespace TuevSued.V1.IT.FE.CommonObjects.Entities
{
    partial class Term : ICustomizeChangeEmployee
    {
        [NotMapped]
        public int? CustomChangeEmployeeId { get; set; }
    }

    partial class ExamProduct  : ICustomizeChangeEmployee
    {
        [NotMapped]
        public int? CustomChangeEmployeeId { get; set; }
    }
}