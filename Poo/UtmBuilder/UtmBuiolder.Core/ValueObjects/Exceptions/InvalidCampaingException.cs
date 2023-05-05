namespace UtmBuiolder.Core.ValueObjects.Exceptions
{
    public class InvalidCampaingException : Exception
    {
        private const string DefaultErrorMessage = "Invalid UTM parameters";

        public InvalidCampaingException(
            string message = DefaultErrorMessage) : base(message)
        {
        }

        public static void ThrowIfNull(
            string? item,
            string message = DefaultErrorMessage)
        {
            if (string.IsNullOrEmpty(item))
                throw new InvalidCampaingException(message);
        }
    }
}
