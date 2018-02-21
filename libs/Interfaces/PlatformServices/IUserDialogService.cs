using System;
using System.Threading;
using System.Threading.Tasks;

namespace Interfaces.PlatformServices
{
    public interface IUserDialogService
    {
        Task AlertAsync(string message, string title = null, string okText = null, CancellationToken? cancelToken = null);

        Task<bool> ConfirmAsync(string message, string title = null, string okText = null, string cancelText = null, CancellationToken? cancelToken = null);

        IDisposable Progress(CancellationTokenSource tokenSource, string title);

        IDisposable Progress(string title);
    }
}