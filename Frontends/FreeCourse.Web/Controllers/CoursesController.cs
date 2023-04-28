using FreeCourse.Shared.Services;
using FreeCourse.Web.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace FreeCourse.Web.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        private readonly ICatalogService _catalogService;
        private readonly IShareIdentityService _sharedIdentityService;

        public CoursesController(ICatalogService catalogService, IShareIdentityService sharedIdentityService)
        {
            _catalogService = catalogService;
            _sharedIdentityService = sharedIdentityService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _catalogService.GetAllCourseByUserIdAsync(_sharedIdentityService.GetUserId));
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories  =  await _catalogService.GetAllCategoryAsync();

            ViewBag.categoryList = new SelectList(categories,"Id", "Name");

            return View();
        }
    }
}
