using System;

namespace SampleClientApp.MyService
{
    public partial class MyServiceClient : IDisposable
    {
		private bool _isDisposed;

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. </summary>
        public void Dispose()
        {
	        ServiceClientUtilities.Dispose(this, ref _isDisposed);
        }
        
        /// <summary>Finalizer. </summary>
        ~MyServiceClient()
        {
            Dispose();
        }
    }
}