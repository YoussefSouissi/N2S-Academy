using Java.Interop;
using Javax.Net.Ssl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Android.Net;
using Object = Java.Lang.Object;

namespace LMSTUDY
{
   public partial class HttpClientService
    {
        
    
        public partial HttpMessageHandler GetPlatformSpecificHttpMessageHandler()
        {
            var androidHttpHandler = new LocalHostAndroidMessageHandler
            {
                ServerCertificateCustomValidationCallback = (httpRequestMessage, certificate, chain, sslPolicyErrors) =>
                {
                    if (certificate?.Issuer == "CN=localhost" || sslPolicyErrors == SslPolicyErrors.None)
                    return true;
                return false;
                }

            };
            return androidHttpHandler;
        }
        class LocalHostAndroidMessageHandler : AndroidMessageHandler
        {
            protected override IHostnameVerifier GetSSLHostnameVerifier(HttpsURLConnection connection) => new LocalhostHostNameVerifier();
            
        }

        class LocalhostHostNameVerifier : Object, IHostnameVerifier
        {
            public bool Verify(string hostname, ISSLSession session)
            {
               
               if (HttpsURLConnection.DefaultHostnameVerifier.Verify(hostname, session) || hostname == "10.0.2.2")
                {
                    return true;
                }
                return false;
            }
        }
    }
}
