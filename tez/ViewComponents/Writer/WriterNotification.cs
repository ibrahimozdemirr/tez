using Microsoft.AspNetCore.Mvc;

namespace tez.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {


            return View();

        }

    }
}
