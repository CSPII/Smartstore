using Smartstore.Core.Stores;
using Smartstore.Web.Models.Common;

namespace Smartstore.Web.Components
{
    public class CspiHeaderViewComponent : SmartViewComponent
    {
        public CspiHeaderViewComponent(){}

        public IViewComponentResult Invoke()
        {
            return View(new CspiHeaderModel
            {
                Stores = Services.StoreContext.GetAllStores().ToList()
            });
        }
    }
}
