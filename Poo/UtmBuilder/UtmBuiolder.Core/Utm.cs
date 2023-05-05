using UtmBuiolder.Core.Extensions;
using UtmBuiolder.Core.ValueObjects;

namespace UtmBuiolder.Core
{
    public class Utm
    {
        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;
        }
        /// <summary>
        /// URL (Website Link)
        /// </summary>
        public Url Url { get; private set; }
        /// <summary>
        /// Campaign Details
        /// </summary>
        public Campaign Campaign { get;private set; }
        public override string ToString()
        {
            var segments = new List<string>();
            segments.AddIfNotNull("utm_source", Campaign.Soruce);
            segments.AddIfNotNull("utm_medium", Campaign.Medium);
            segments.AddIfNotNull("utm_campaign", Campaign.Name);
            segments.AddIfNotNull("utm_id", Campaign.Id);
            segments.AddIfNotNull("utm_term", Campaign.Term);
            segments.AddIfNotNull("utm_content", Campaign.Content);
            return $"{Url.Address}?{string.Join("&", segments)}";
        }
    }
}
// Dica Validacao : https://github.com/andrebaltieri/Flunt