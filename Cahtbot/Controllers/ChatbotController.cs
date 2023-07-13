using Azure.Core;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System;
using WebAPI;
//using WebAPI.Data.Packages.Interfaces;
using Newtonsoft.Json;
using Chatbot.Models;
using Chatbot;
using Chatbot.Data.Packages.Interfaces;

namespace Cahtbot.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ChatbotController : ControllerBase
    {
        
        private readonly HttpClient _httpClient;

        public ChatbotController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> GetChatbotResponse(string userMessage)
        {
            
            // Call the Python chatbot API
            var pythonApiUrl = "http://127.0.0.1:8000/polls";
            var response = await _httpClient.GetAsync($"{pythonApiUrl}?userMessage={userMessage}");

            if (response.IsSuccessStatusCode)
            {
                var chatbotResponse = await response.Content.ReadAsStringAsync();
                return Ok(chatbotResponse);

            }

            return BadRequest("Failed to get a response from the chatbot.");
        }
    }


    //[Route("api/[controller]")]
    //[ApiController]
    //public class ChatBotController : ControllerBase
    //{
    //    private readonly IPackages _package;
    //    private IWebHostEnvironment _webHostingEnvironment;
    //    public ChatBotController(IWebHostEnvironment webHost,IPackages package)
    //    {
    //        _webHostingEnvironment = webHost;
    //        _package = package;
    //    }
    //    [ActionName("ChatBot")]
    //    [Route("ChatBot")]
    //    [Consumes("application/x-www-form-urlencoded")]
    //    [HttpPost]
    //    public Chatbot.Models.Response ChatBot([FromForm] PackageModel data)
    //    {
    //        var responseObj = new Chatbot.Models.Response();
    //        try
    //        {
    //            if (data != null)
    //            {
    //                //string obj = data;
    //                //var allData = JsonConvert.DeserializeObject<dynamic>(obj);
    //                //string logistics_interface = allData.logistics_interface; 
    //                //var data_digest = allData.data_digest;
    //                //var partner_code = allData.partner_code;
    //                //var from_code = allData.from_code;
    //                //var msg_type = allData.msg_type;
    //                //var msg_id = allData.msg_id;

    //                //var packages = JsonConvert.DeserializeObject<dynamic>(logistics_interface);

    //                Package package = new Package()
    //                {
    //                    DataDigest = data.data_digest,
    //                    LogisticsInterface = data.logistics_interface,
    //                    PartnerCode = data.partner_code,
    //                    FromCode = data.from_code,
    //                    MsgType = data.msg_type,
    //                    MsgId = data.msg_id,
    //                };
    //                _package.CreatePackage(package);
    //                //var userid = _userManager.GetUserId(HttpContext.User);
    //                //IdentityUser user = _userManager.FindByIdAsync(userid).Result;
    //                var logistics_interface_obj = JsonConvert.DeserializeObject<string>(data.logistics_interface);

    //                //lastMileObj.lastMileOrderCode = "";
    //                //if (logistics_interface_obj != null && package.PartnerCode == "DISTRIBUTOR_31124794" && package.FromCode == "CNGFC" && package.MsgType == "CAINIAO_GLOBAL_LASTMILE_ASN" && package.MsgId == "1686275894489")
    //                //{

    //            }
    //            else
    //            {
    //                responseObj = new Chatbot.Models.Response { success = "false", errorCode = "", errorMsg = "" };
    //                return responseObj;
    //            }


    //        }
    //        catch (Exception ex)
    //        {
    //            responseObj = new Chatbot.Models.Response { success = "false", errorCode = "S06", errorMsg = "server request Time out" };

    //            return responseObj;
    //        }
    //        responseObj = new Chatbot.Models.Response { success = "true", errorCode = "", errorMsg = "" };
    //        return responseObj;



    //        //}
    //    }
    //}
}

