//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using TheGalleryCafe.Class; // For ApplicationDbContext
//using TheGalleryCafe.Models; // For ApplicationRole
//using System.Linq;
//using System.Threading.Tasks;
//using System.Web.Mvc;

//namespace TheGalleryCafe.Controllers
//{
//    public class RoleController : Controller
//    {
//        //private readonly ApplicationRoleManager _roleManager;

//        // Constructor for RoleController
//        //public RoleController()
//        //{
//        //    // Create an instance of ApplicationRoleManager using the ApplicationDbContext
//        //    _roleManager = new ApplicationRoleManager(new RoleStore<ApplicationRole>(new ApplicationDbContext()));
//        //}

//        // GET: Role/Index
//        public ActionResult Index()
//        {
//            var roles = _roleManager.Roles.ToList(); // Get list of roles
//            return View(roles); // Pass roles to the view
//        }

//        // GET: Role/Create
//        public ActionResult Create()
//        {
//            return View(); // Return the Create view for creating a new role
//        }

//        //// POST: Role/Create
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<ActionResult> Create(ApplicationRole model)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        var role = new ApplicationRole { Name = model.Name }; // Create new role
//        //        var result = await _roleManager.CreateAsync(role); // Create role asynchronously

//        //        if (result.Succeeded)
//        //        {
//        //            return RedirectToAction("Index"); // Redirect to Index view if successful
//        //        }
//        //        else
//        //        {
//        //            // Add errors to ModelState if creation failed
//        //            foreach (var error in result.Errors)
//        //            {
//        //                ModelState.AddModelError("", error);
//        //            }
//        //        }
//        //    }
//        //    return View(model); // Return view with errors if model is not valid
//        //}

//        // GET: Role/Delete/5
//        public async Task<ActionResult> Delete(string id)
//        {
//            var role = await _roleManager.FindByIdAsync(id); // Find role by ID
//            if (role == null)
//            {
//                return HttpNotFound(); // Return 404 if role is not found
//            }
//            return View(role); // Return Delete view with role data
//        }

//        // POST: Role/Delete/5
//        [HttpPost, ActionName("Delete")]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> DeleteConfirmed(string id)
//        {
//            var role = await _roleManager.FindByIdAsync(id); // Find role by ID
//            if (role != null)
//            {
//                var result = await _roleManager.DeleteAsync(role); // Delete role asynchronously
//                if (result.Succeeded)
//                {
//                    return RedirectToAction("Index"); // Redirect to Index view if deletion was successful
//                }
//            }
//            return HttpNotFound(); // Return 404 if role is not found or deletion failed
//        }
//    }
//}
