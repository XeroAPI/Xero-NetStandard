using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IFoldersEndpoint : IXeroUpdateEndpoint<FoldersEndpoint, Folder, FolderRequest, FolderResponse>
    {
        new Task<IEnumerable<Folder>> FindAsync();
        Task<FilePageResponse> AddAsync(string folderName);
        Task RemoveAsync(Guid id);
        Task<FoldersResponse> RenameAsync(Guid id, string name);
    }

    public class FoldersEndpoint : XeroUpdateEndpoint<FoldersEndpoint, Folder, FolderRequest, FolderResponse>, IFoldersEndpoint
    {
        internal FoldersEndpoint(XeroHttpClient client)
            : base(client, "files.xro/1.0/Folders")
        {

        }

        public async Task<FilePageResponse> AddAsync(string folderName)
        {
            var endpoint = "files.xro/1.0/Folders";

            var response = await Client.PostAsync(endpoint, new Folder { Name = folderName }, true).ConfigureAwait(false);

            return await HandleFolderResponseAsync(response).ConfigureAwait(false);
        }

        public new async Task<IEnumerable<Folder>> FindAsync()
        {
            var response = await Client.GetAsync("files.xro/1.0/Folders", "").ConfigureAwait(false);
            var result = await HandleFoldersResponseAsync(response).ConfigureAwait(false);


            var resultingFolders = from i in result
                                   select new Folder { Id = i.Id, Name = i.Name, IsInbox = i.IsInbox, FileCount = i.FileCount };

            return resultingFolders.ToList();
        }

        public async Task RemoveAsync(Guid id)
        {
            var response = await Client.DeleteAsync("files.xro/1.0/Folders/" + id).ConfigureAwait(false);
            await HandleFolderResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<FoldersResponse> RenameAsync(Guid id, string name)
        {
            var folder = new Folder
            {
                Name = name
            };

            var response = await Client.PutAsync("files.xro/1.0/Folders/" + id, folder, true).ConfigureAwait(false);
            var result = await HandleFoldersResponseAsync(response).ConfigureAwait(false);
            return result?[0];
        }

        private async Task<FilePageResponse> HandleFolderResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<FilePageResponse>(body);

                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
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

    public class FolderResponse : XeroResponse<Folder>
    {
        public override IList<Folder> Values
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class FolderRequest : XeroRequest<Folder>
    {
    }
}