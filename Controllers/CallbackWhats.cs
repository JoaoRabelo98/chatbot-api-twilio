using ApiTwilio.Domain;
using ApiTwilio.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio.AspNet.Common;
using Twilio.TwiML;

namespace ApiTwilio.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CallbackWhatsController : Controller
  {
    [HttpPost]
    [Route("verifyStatus")]
    public string VerifyStatus()
    {
      return "Hello World";
    }

    [HttpPost]
    [Route("message")]
    public string Index([FromForm] RequestTwilio request)
    {
      var response = new MessagingResponse();

      return InitialService.Start(request.Body);
    }
  }
}
