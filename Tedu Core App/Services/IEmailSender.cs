using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tedu_Core_App.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
