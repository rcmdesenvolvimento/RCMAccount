namespace AccountAPI.Models.Error
{
    public class CustomValidatonFailure
    {
        public CustomValidatonFailure(string propertyName, string errorMessage)
        {
            PropertyName = propertyName;
            ErrorMessage = errorMessage;    
        }

        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
