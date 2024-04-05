using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ToDoListPanelController : Controller
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IActionResult Index()
        {
            var values = toDoListManager.TGetList();
            return View(values);

        }
        [HttpGet]
        public IActionResult AddToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToDoList(ToDoList toDoList)
        {
            toDoListManager.TAdd(toDoList);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteToDoList(int id)
        {
            var values = toDoListManager.TGetByID(id);
            toDoListManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditToDoList(int id)
        {
            var values = toDoListManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditToDoList(ToDoList toDoList)
        {
            toDoListManager.TUpdate(toDoList);
            return RedirectToAction("Index");
        }
    }
}
