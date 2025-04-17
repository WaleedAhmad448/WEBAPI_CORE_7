using CoreApi.Modal;

namespace CoreApi.Service
{
    public interface IEmailService
    {
        Task SendEmail(Mailrequest mailrequest);
    }
}
