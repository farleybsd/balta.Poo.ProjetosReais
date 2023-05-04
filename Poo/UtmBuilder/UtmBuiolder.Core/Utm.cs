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
    }
}
//Aqui: https://balta.io/player/assistir/dfa3752e-4bd5-4101-bafb-ff3afcf39930/5a8bbb99-bb2f-42e0-aaa3-843857bfcb3c