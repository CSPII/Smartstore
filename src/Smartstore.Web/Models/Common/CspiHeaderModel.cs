using Smartstore.Core.Stores;

namespace Smartstore.Web.Models.Common
{
    public partial class CspiHeaderModel : ModelBase
    {
        public List<Store> Stores { get; set; }
    }
}
