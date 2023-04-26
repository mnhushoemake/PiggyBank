using Microsoft.AspNetCore.Mvc;
using PiggyBank.Models;

namespace PiggyBank.Controllers
{
    public class RequestController : Controller
    {
        public IActionResult Index()
        {
            List<RequestModel> requests = new List<RequestModel>();
            UserModel requestOwner = new UserModel{FirstName = "Mike", LastName = "Shoemake", Password = "4321", UserId = 1};

            requests.Add(new RequestModel{RequestId = 1, RequestOwner = requestOwner, Status = RequestModel.RequestStatus.New, Title = "First Request" });
            requests.Add(new RequestModel{ RequestId = 3, RequestOwner = requestOwner, Status = RequestModel.RequestStatus.Waiting, Title = "Second Request" });
            requests.Add(new RequestModel{ RequestId = 2, RequestOwner = requestOwner, Status = RequestModel.RequestStatus.Closed, Title = "Third Request" });

            return View(requests);
        }

        
        public IActionResult Create()
        {
            UserModel requestOwner = new UserModel { FirstName = "Mike", LastName = "Shoemake", Password = "4321", UserId = 1 };
            RequestModel request = new RequestModel { RequestId = 1, RequestOwner = requestOwner, Status = RequestModel.RequestStatus.New, Title = "First Request" };

            return View(request);
        }
        
        public IActionResult Edit()
        {
            UserModel requestOwner = new UserModel { FirstName = "Mike", LastName = "Shoemake", Password = "4321", UserId = 1 };
            RequestModel request = new RequestModel { RequestId = 1, RequestOwner = requestOwner, Status = RequestModel.RequestStatus.New, Title = "First Request" };
            return View(request);
        }

    }
}
