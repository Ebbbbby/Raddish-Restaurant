using Raddish.Webs.Models;
using System;
using System.Threading.Tasks;

namespace Raddish.Webs.Services.IServices
{
    public interface IBaseService:IDisposable
    {
        ResponseDto responseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequests apiRequests);

    }
}
