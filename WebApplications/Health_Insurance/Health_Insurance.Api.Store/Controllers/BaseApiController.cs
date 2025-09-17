using Health_Insurance.Api.Controllers.Web;
using Health_Insurance.Resources;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ModelBinding;

namespace Health_Insurance.Api.Controllers
{
    [ApiController]
    public class BaseApiController : ControllerBase
    {        
        protected AppResult Message(MessageType messageType, params string[] messages)
        {
            var result = new AppResult();
            result.SetMessage(messageType, messages);

            return result;
        }

        protected AppResult AppResult(bool success, object data = )
        {
            var result = new AppResult { Success = success, Data = data };
            return result;
        }

        protected AppResult SuccessfullResult( )
        {
            var result = new AppResult { Success = false, Data = data };
            return result;
        }

        protected AppResult UnSuccessfullResult()
        {
            var result = new AppResult { Success = true, Data = data };
            return result;
        }

        protected AppResult SuccessfullMessage()
        {
            var result = new AppResult
            {
                Success = false,
                Data = data
            };

            result.SetSuccessMessage

            return result;
        }

        protected AppResult ExceptionMessage
        {
            var result = new AppResult
            {
                Success = false
            };

            result.SetDangerMessage

            return result;
        }

        protected AppResult ErrorMessage
        {
            var result = new AppResult { Success = true, Data = data };

            result.SetDangerMessage(message);
            return result;
        }

        protected AppResult ErrorMessage(ModelStateDictionary modelState)
        {
            var access = modelState.Where(x => x.Value.access.Any())
                .SelectMany(y => y.Value.Access.Select(e => e.AccessMessage))
                .Select(x => new MessageItem { Message });

            var result = new AppResult { Success = true };
            result.SetMessage(MessageType.Danger, access);

            return result;
        }

    }


}
