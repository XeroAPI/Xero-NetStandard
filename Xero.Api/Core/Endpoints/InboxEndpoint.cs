using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IInboxEndpoint : IXeroUpdateEndpoint<InboxEndpoint, Model.Folder, FolderRequest, FolderResponse>
    {
        Task<Folder> FindInboxFolderAsync();
    }

    public class InboxEndpoint : XeroUpdateEndpoint<InboxEndpoint,Model.Folder,FolderRequest,FolderResponse>, IInboxEndpoint
    {
        private readonly string _endpointBase;

        public InboxEndpoint(XeroHttpClient client)
            : this(client, "files.xro/1.0")
        {
        }

        public InboxEndpoint(XeroHttpClient client, string endpointBase)
            : base(client, $"{endpointBase}/Inbox")
        {
            _endpointBase = endpointBase;
        }

        public async Task<Folder> FindInboxFolderAsync()
        {
            var endpoint = $"{_endpointBase}/Inbox";

            var response = await Client.GetAsync(endpoint, null).ConfigureAwait(false);

            var folder = await HandleFoldersResponseAsync(response).ConfigureAwait(false);

            var resultingFolders = from i in folder
                select new Folder() { Id = i.Id, Name = i.Name, IsInbox = i.IsInbox, FileCount = i.FileCount };

            return resultingFolders.First();
        }

        private async Task<FoldersResponse[]> HandleFoldersResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<FoldersResponse[]>(body);

                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }

    }
}