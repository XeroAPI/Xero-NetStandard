using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Xero.Api.Infrastructure.ThirdParty.Dust
{
    public class RsaSha1
    {
        private readonly X509Certificate2 _certificate;

        public RsaSha1(X509Certificate2 certificate)
        {
            _certificate = certificate;
        }

        public string Sign(string signatureBaseString)
        {
            using (var sha1 = SHA1.Create())
            {
                var bytes = Encoding.ASCII.GetBytes(signatureBaseString);

                var hash = sha1.ComputeHash(bytes);

                var sig = _certificate.GetRSAPrivateKey().SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);

                return Convert.ToBase64String(sig);
            }
        }
    }
}