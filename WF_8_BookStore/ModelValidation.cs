using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BookStore
{
    public class ModelValidator<TModel>
    {
        public ICollection<ValidationResult>? ValidationResults { get; private set; }

        public bool ValidateModel(TModel modelInstance)
        {
            ValidationResults = new List<ValidationResult>();

            if (modelInstance == null)
            {
                var nullModelError = new ValidationResult("The model instance is null.");

                ValidationResults.Add(nullModelError);

                return false;
            }

            var context = new ValidationContext(modelInstance);

            return Validator.TryValidateObject(modelInstance, context, ValidationResults, validateAllProperties: true);
        }

        public string GetFormattedValidationResults()
        {
            var sb = new StringBuilder();

            if (ValidationResults != null && ValidationResults.Any())
            {
                foreach (var result in ValidationResults)      

                    sb.AppendLine(result.ErrorMessage);        
            }

            return sb.ToString();
        }
    }
}
