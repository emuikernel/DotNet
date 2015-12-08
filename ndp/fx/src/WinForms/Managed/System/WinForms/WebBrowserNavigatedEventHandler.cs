//------------------------------------------------------------------------------
// <copyright file="WebBrowserNavigatedEventHandler.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------


using System.Net;

namespace System.Windows.Forms {

    /// <include file='doc\WebBrowserNavigatedEventHandler.uex' path='docs/doc[@for="WebBrowserNavigatedEventHandler"]/*' />
    /// <devdoc>
    ///     <para>
    /// Delegate to the WebBrowser Navigated event.
    ///     </para>
    /// </devdoc>
    public delegate void WebBrowserNavigatedEventHandler(object sender, WebBrowserNavigatedEventArgs e);

    /// <include file='doc\WebBrowserNavigatedEventHandler.uex' path='docs/doc[@for="WebBrowserNavigatedEventArgs"]/*' />
    /// <devdoc>
    ///    <para>
    /// Provides data for the <see cref='System.Windows.Forms.WebBrowser.OnNavigated'/> event.
    ///    </para>
    /// </devdoc>
    public class WebBrowserNavigatedEventArgs : EventArgs {
        private Uri url;

        /// <include file='doc\WebBrowserNavigatedEventHandler.uex' path='docs/doc[@for="WebBrowserNavigatedEventArgs.WebBrowserNavigatedEventArgs"]/*' />
        /// <devdoc>
        ///    <para>
        /// Creates an instance of the <see cref='System.Windows.Forms.WebBrowserNavigatedEventArgs'/> class.
        ///    </para>
        /// </devdoc>
        public WebBrowserNavigatedEventArgs(Uri url) {
            this.url = url;
        }
        
        /// <include file='doc\WebBrowserNavigatedEventHandler.uex' path='docs/doc[@for="WebBrowserNavigatedEventArgs.Url"]/*' />
        /// <devdoc>
        ///    <para>
        /// Url the browser navigated to.
        ///    </para>
        /// </devdoc>
        public Uri Url {
            get {
                WebBrowser.EnsureUrlConnectPermission(url);
                return this.url;
            }
        }
    }

}

