using snapshotsOfLife.Models;

namespace snapshotsOfLife.Controllers {
    public class HomeController {
private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
    }

}