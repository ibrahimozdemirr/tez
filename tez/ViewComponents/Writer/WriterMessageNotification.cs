using Microsoft.AspNetCore.Mvc;

namespace tez.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

         
            return View();

        }
    }
}
