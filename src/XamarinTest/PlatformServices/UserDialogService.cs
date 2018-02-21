using System;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Interfaces.PlatformServices;
using Interfaces.Services;

namespace XamarinTest.PlatformServices
{
    public class UserDialogService : IUserDialogService
    {
        private IUserDialogs _userDialogs;
        private IUserDialogs UserDialogs
        {
            get
            {
                if (_userDialogs == null)
                {
                    _userDialogs = Acr.UserDialogs.UserDialogs.Instance;
                }
                return _userDialogs;
            }
        }

        public Task AlertAsync(string message, string title = null, string okText = null, CancellationToken? cancelToken = null)
        {
            return UserDialogs.AlertAsync(message, title, okText, cancelToken);
        }

        public Task<bool> ConfirmAsync(string message, string title = null, string okText = null, string cancelText = null,
            CancellationToken? cancelToken = null)
        {
            return UserDialogs.ConfirmAsync(message, title, okText, cancelText, cancelToken);
        }

        public IDisposable Progress(CancellationTokenSource tokenSource, string title)
        {
            var config = new ProgressDialogConfig().SetTitle(title)
                .SetIsDeterministic(false)
                .SetMaskType(MaskType.Black)
                .SetCancel(onCancel: tokenSource.Cancel);

            return UserDialogs.Progress(config);
        }

        public IDisposable Progress(string title)
        {
            var config = new ProgressDialogConfig().SetTitle(title)
                .SetIsDeterministic(false)
                .SetMaskType(MaskType.Black);

            return UserDialogs.Progress(config);
        }
    }
}