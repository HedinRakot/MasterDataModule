using System.ComponentModel.DataAnnotations;

namespace TuevSued.V1.IT.FE.MasterDataModule.API.Validation
{
    public class RequiredAttribute: System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var result = base.IsValid(value, validationContext);
            
            if(result != null)
                result.ErrorMessage = "required";

            return result;
        }
    }
}
