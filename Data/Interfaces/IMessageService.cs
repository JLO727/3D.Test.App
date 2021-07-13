using _3D.Test.App.Data.Models.Requests;
using _3D.Test.App.Data.Models.Responses;
using Microsoft.AspNetCore.Mvc;

namespace _3D.Test.App.Data.Interfaces
{
    public interface IMessageService
    {
        int AddMessage(MessageAddRequest model);
    }
}