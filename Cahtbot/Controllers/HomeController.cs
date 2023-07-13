using Cahtbot.Models;
using Chatbot.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace Cahtbot.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ChatbotController _chatController;

        public HomeController(ILogger<HomeController> logger,ChatbotController chatbotController)
        {
            _logger = logger;
            _chatController = chatbotController;
        }
        static HttpClient client = new HttpClient();




        static async Task Main(string[] args)
        {
            string apiUrl = "http://<عنوان API الخاص بك>";

            try
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // قم بتخزين البيانات في قاعدة البيانات هنا
                    // يمكنك استخدام ORM مثل Entity Framework أو أي طريقة أخرى
                }
                else
                {
                    Console.WriteLine("حدث خطأ أثناء استدعاء الAPI. الرمز الناتج: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("حدث خطأ أثناء استدعاء الAPI: " + ex.Message);
            }
        }
 
        public IActionResult Index(string input)
        {

            //IEnumerable<PackageViewModel> PackageModel = new List<PackageViewModel>();




            //PackageViewModel _package = new PackageViewModel()
            //{
            //    MailBoxItem = obj.mailBoxItem,
            //    BuyerMobile = obj.BuyerMobile,
            //    TrackingNumber = obj.trackingNumber,
            //    LogisticsOrderCode = obj.logisticsOrderCode,
            //    BuyerAddress = obj.BuyerAddress,
            //    BuyerName = obj.sender.identity.id,
            //    BuyerEmail = obj.BuyerEmail,
            //    BuyerPhone = obj.BuyerPhone,
            //    RecieverName = obj.receiver.name,
            //    RecieverAddress = obj.receiver.address.detailAddress,
            //    RecieverZipCode = obj.receiver.zipCode,

            //};
            //PackageModel.Append(_package);
           var c= _chatController.GetChatbotResponse(input);

            ViewBag.Message = c;
            return View();
        }

        public IActionResult Privacy()
        { 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}