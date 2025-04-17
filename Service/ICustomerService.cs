using CoreApi.Helper;
using CoreApi.Modal;
using CoreApi.Repos.Models;

namespace CoreApi.Service
{
    public interface ICustomerService
    {
        Task<List<Customermodal>> Getall();
        Task<Customermodal> Getbycode(string code);
        Task<APIResponse> Remove(string code);
        Task<APIResponse> Create(Customermodal data);

        Task<APIResponse> Update(Customermodal data,string code);
    }
}
