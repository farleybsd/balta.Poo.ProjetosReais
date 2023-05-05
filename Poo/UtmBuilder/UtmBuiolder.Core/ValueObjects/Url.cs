using System.Text.RegularExpressions;
using UtmBuiolder.Core.ValueObjects.Exceptions;

namespace UtmBuiolder.Core.ValueObjects
{
    public class Url : ValueObject
    {
       
        /// <summary>
        /// Address of URL (Web Site Link)
        /// </summary>
        public string Address { get; private set; }

        /// <summary>
        /// Create New Url
        /// </summary>
        /// <param name="address">Address of URL (Web Site Link)</param>
        public Url(string address)
        {
            Address = address;
           InvalidUrlException.ThowIfInvalidUrl(Address);
        }
    }
}
