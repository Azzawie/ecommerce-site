using System.Threading.Tasks;

namespace CS412Final_Azzawie.BLL.Interfaces
{
    public interface INotificationsBLL
    {
        Task SendEmail(string to, string subject, string body, string replyTo = "");
    }
}