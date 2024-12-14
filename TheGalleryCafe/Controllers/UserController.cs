using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Web.Mvc;
using TheGalleryCafe.Class;

public class UserController : Controller
{
    private ApplicationDbContext _context;

    public UserController()
    {
        _context = new ApplicationDbContext();
    }

    // Get roles for a user
    ////public ActionResult GetUserRoles(string userId)
    ////{
    ////    var userRoles = from userRole in _context.Set<IdentityUserRole>()
    ////                    join role in _context.Roles on userRole.RoleId equals role.Id
    ////                    where userRole.UserId == userId
    ////                    select new { role.Name, role.Id };

    ////    var roleList = userRoles.ToList();

    ////    return View(roleList);
    ////}

    // Get all roles in the system
    public ActionResult GetAllRoles()
    {
        var allRoles = _context.Roles.ToList();
        var allRoleNames = allRoles.Select(role => new { role.Id, role.Name }).ToList();

        return View(allRoleNames);
    }

    // Get roles for a specific user

}
