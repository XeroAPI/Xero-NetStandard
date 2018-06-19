using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IFilesEndpoint : IXeroUpdateEndpoint<FilesEndpoint, Model.File, FilesRequest, FilesResponse>
    {
        Task<Model.File> RenameAsync(Guid id, string name);
        Task<Model.File> MoveAsync(Guid id, Guid newFolder);
        Task<Model.File> AddAsync(Guid folderId, Model.File file, byte[] data);
        Task<Model.File> RemoveAsync(Guid fileid);
        Task<byte[]> GetContentAsync(Guid id, string contentType);
    }
    
    public class FilesEndpoint : XeroUpdateEndpoint<FilesEndpoint, Model.File, FilesRequest, FilesResponse>, IFilesEndpoint, IPageableEndpoint<IFilesEndpoint>
    {

        internal FilesEndpoint(XeroHttpClient client)
            : base(client, "files.xro/1.0/Files")
        {
            AddParameter("page", 1, false);
        }

        public IFilesEndpoint Page(int page)
        {
            return AddParameter("page", page);
        }

        public override async Task<IEnumerable<Model.File>> FindAsync()
        {
            var response = await Client.GetAsync("files.xro/1.0/Files", QueryString).ConfigureAwait(false);

            var result = await HandleFilesResponseAsync(response).ConfigureAwait(false);

            return result.Items;
        }

        public override async Task<Model.File> FindAsync(Guid fileId)
        {
            var response = await Client.GetAsync("files.xro/1.0/Files", "").ConfigureAwait(false);
            var result = await HandleFilesResponseAsync(response).ConfigureAwait(false);

            return result.Items.SingleOrDefault(i => i.Id == fileId);
        }

        public async Task<Model.File> RenameAsync(Guid id, string name)
        {
            var file = new Model.File
            {
                Name = name
            };

            var response = await Client.PutAsync("files.xro/1.0/Files/" + id, file, true).ConfigureAwait(false);
            return await HandleFileResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<Model.File> MoveAsync(Guid id, Guid newFolder)
        {
            var file = new Model.File
            {
                FolderId = newFolder
            };

            var response = await Client.PutAsync("files.xro/1.0/Files/" + id, file, true).ConfigureAwait(false); 
            return await HandleFileResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<Model.File> AddAsync(Guid folderId, Model.File file, byte[] data)
        {
            var response = await Client.PostMultipartFormAsync("files.xro/1.0/Files/" + folderId, file.Mimetype, file.Name, file.FileName, data).ConfigureAwait(false);
            return await HandleFileResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<Model.File> RemoveAsync(Guid fileid)
        {
            var response = await Client.DeleteAsync("files.xro/1.0/Files/" + fileid).ConfigureAwait(false);
            return await HandleFileResponseAsync(response).ConfigureAwait(false);
        }

        public async Task<byte[]> GetContentAsync(Guid id, string contentType)
        {
            var response = await Client.GetRawAsync("files.xro/1.0/Files/" + id + "/Content", contentType).ConfigureAwait(false);

            return await response.Content.ReadAsByteArrayAsync().ConfigureAwait(false);

        }

        private async Task<Model.File> HandleFileResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<Model.File>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }

        private async Task<FilesResponse> HandleFilesResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                var body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                var result = Client.JsonMapper.From<FilesResponse>(body);
                return result;
            }

            await Client.HandleErrorsAsync(response).ConfigureAwait(false);

            return null;
        }
    }
}