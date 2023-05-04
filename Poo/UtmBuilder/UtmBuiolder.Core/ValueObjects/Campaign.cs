namespace UtmBuiolder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {
        /// <summary>
        /// Generate a new campaign for a URL
        /// </summary>
        /// <param name="Soruce">The referrer (e.g. google, newsletter)</param>
        /// <param name="Medium">Marketing medium (e.g. cpc, banner, email)</param>
        /// <param name="Name">Product, promo code, or slogan (e.g. spring_sale) One of campaign name or campaign id are required.</param>
        /// <param name="Id">The ads campaign id.</param>
        /// <param name="Term">Identify the paid keywords</param>
        /// <param name="Content">Use to differentiate ads</param>
        /// 
        /// 
        /// <summary>
        /// The referrer (e.g. google, newsletter)
        /// </summary>
        public string Soruce { get; private set; }
        /// <summary>
        /// Marketing medium (e.g. cpc, banner, email)
        /// </summary>
        public string Medium { get; private set; }
        /// <summary>
        /// Product, promo code, or slogan (e.g. spring_sale) One of campaign name or campaign id are required.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The ads campaign id.
        /// </summary>
        public string? Id { get; private set; }
        /// <summary>
        /// Identify the paid keywords
        /// </summary>
        public string? Term { get; private set; }
        /// <summary>
        /// Use to differentiate ads
        /// </summary>
        public string? Content { get; private set; }
        public Campaign(string soruce, string medium, string name, string? id = null, string? term = null, string? content = null)
        {
            Soruce = soruce;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
        }

    }
}
