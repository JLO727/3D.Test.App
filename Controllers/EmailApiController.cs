using _3D.Test.App.Data.Interfaces;
using _3D.Test.App.Data.Models.Requests;
using _3D.Test.App.Data.Models.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace _3D.Test.App.Controllers
{
    [Route("api/emails")]
    [ApiController]
    public class EmailApiController : BaseApiController
    {

        private IMessageService _service;
        public EmailApiController(IMessageService service,
            ILogger<EmailApiController> logger) : base(logger)
        {

            _service = service;

        }
        [AllowAnonymous]
        [HttpPost("send")]
        public ActionResult<SuccessResponse> AddMessage(MessageAddRequest model)
        {
            int code = 200;
            BaseResponse response = null;

            try
            {
                _service.AddMessage(model);

                response = new SuccessResponse();
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);

        }
    }
}
