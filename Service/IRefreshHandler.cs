namespace CoreApi.Service
{
    public interface IRefreshHandler
    {
       Task<string> GenerateToken(string username);
    }
}
