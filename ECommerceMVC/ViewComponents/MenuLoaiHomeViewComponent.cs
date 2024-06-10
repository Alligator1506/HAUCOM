using ECommerceMVC.Data;
using ECommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceMVC.ViewComponents
{
    public class MenuLoaiHomeViewComponent : ViewComponent
    {
        private readonly Hshop2023Context db;

        public MenuLoaiHomeViewComponent(Hshop2023Context context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Loais.Select(lo => new MenuLoaiHomeVM
            {
                MaLoai = lo.MaLoai,
                TenLoai = lo.TenLoai,
            }).OrderBy(p => p.TenLoai);

            return View(data); // Default.cshtml
                               //return View("Default", data);
        }
    }
}
