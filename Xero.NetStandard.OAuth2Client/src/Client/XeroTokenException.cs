using System;
using System.Net;
using IdentityModel.Client;

namespace Xero.NetStandard.OAuth2.Client
{
    /// <summary>
    /// Thrown when a call to Xero's OAuth 2.0 token endpoint (token request, refresh, or revocation)
    /// fails. Unlike a bare <see cref="Exception"/>, it keeps the OAuth error code, description, and
    /// <see cref="ErrorType"/> as structured fields, and preserves the original transport/network
    /// exception (if any) as <see cref="Exception.InnerException"/> instead of discarding it.
    /// </summary>
    /// <remarks>
    /// <see cref="ErrorType"/> tells callers whether <see cref="Error"/> is safe to compare against
    /// spec-defined OAuth codes (e.g. "invalid_grant"): that's only true for
    /// <see cref="ResponseErrorType.Protocol"/>. For <see cref="ResponseErrorType.Http"/> or
    /// <see cref="ResponseErrorType.Exception"/>, <see cref="Error"/> is an HTTP reason phrase or a
    /// transport exception's message and can never equal a real OAuth code.
    ///
    /// <see cref="Exception.Message"/> is deliberately always just <see cref="Error"/> — never
    /// <see cref="Error"/> plus <see cref="ErrorDescription"/> concatenated — so consumers that
    /// classify failures by comparing <c>Message</c> against known OAuth codes keep working
    /// unchanged whether or not Xero happens to supply a description. Consumers that want the
    /// description should read <see cref="ErrorDescription"/> directly.
    /// </remarks>
    public class XeroTokenException : Exception
    {
        /// <summary>
        /// The OAuth error code (e.g. "invalid_grant") when <see cref="ErrorType"/> is
        /// <see cref="ResponseErrorType.Protocol"/>; otherwise an HTTP reason phrase or the underlying
        /// exception's message.
        /// </summary>
        public string Error { get; }

        /// <summary>
        /// The OAuth <c>error_description</c> supplied by the token endpoint, if any. Always null for
        /// token revocation failures (the revocation endpoint's response carries no description) and
        /// for non-protocol failures.
        /// </summary>
        public string ErrorDescription { get; }

        /// <summary>Distinguishes a genuine OAuth protocol error from an HTTP-level or transport-level failure.</summary>
        public ResponseErrorType ErrorType { get; }

        /// <summary>The HTTP status code of the failed response, or 0 if the failure never reached the HTTP layer.</summary>
        public HttpStatusCode HttpStatusCode { get; }

        public XeroTokenException(ProtocolResponse response, string errorDescription = null)
            : base(response?.Error, response?.Exception)
        {
            Error = response?.Error;
            ErrorDescription = errorDescription;
            ErrorType = response?.ErrorType ?? ResponseErrorType.None;
            HttpStatusCode = response?.HttpStatusCode ?? default;
        }
    }
}
