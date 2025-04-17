using CoreApi.Helper;
using CoreApi.Modal;
using CoreApi.Repos.Models;

namespace CoreApi.Service
{
    public interface IUserRoleServicecs
    {
        Task<APIResponse> AssignRolePermission(List<TblRolepermission> _data);
        Task<List<TblRole>> GetAllRoles();
        Task<List<TblMenu>> GetAllMenus();
        Task<List<Appmenu>> GetAllMenubyrole(string userrole);
        Task<Menupermission> GetMenupermissionbyrole(string userrole,string menucode);
    }
}
