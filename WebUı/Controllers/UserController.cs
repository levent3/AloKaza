
using DataLayer.Abstract;
using DataLayer.Concreate;
using EntitiesLayer;
using Microsoft.AspNetCore.Mvc;

namespace WebUı.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository userRepository;

        public UserController( IUserRepository userRepository)
  
        {
            this.userRepository = userRepository;
        }
        public IActionResult Index()
        {

            //var users= userRepository.GetAll();
            var users2= userRepository.GetAllUser();

            return View(users2);
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            userRepository.Add(user);

            return RedirectToAction("Index");
        }



        [HttpGet]
        public  IActionResult Edit(int Id)
        {
            var kullanıcı=userRepository.GetById(Id);

            User user=new User()
            {

                Id=kullanıcı.Id,
                Name=kullanıcı.Name,
                Age=kullanıcı.Age

            };
            return View (kullanıcı);

        }


        [HttpPost]
        public IActionResult Edit(User user) {
        
          userRepository.Update(user);

          return RedirectToAction("Index");

        }
    }
}
