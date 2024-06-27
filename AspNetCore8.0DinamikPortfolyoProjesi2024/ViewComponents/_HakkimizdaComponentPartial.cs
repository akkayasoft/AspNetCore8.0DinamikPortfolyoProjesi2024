using Microsoft.AspNetCore.Mvc;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.ViewComponents
{
    public class _HakkimizdaComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
