using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IFilesEndpoint : IXeroUpdateEndpoint<FilesEndpoint, Model.File, FilesRequest, FilesResponse>
    {
        Model.File Rename(Guid id, string name);
        Model.File Move(Guid id, Guid newFolder);
        Model.File Add(Guid folderId, Model.File file, byte[] data);
        Model.File Remove(Guid fileid);
        byte[] GetContent(Guid id, string contentType);
        Model.File this[Guid id] { get; }
    }

    public class FilesEndpoint : XeroUpdateEndpoint<FilesEndpoint, Model.File, FilesRequest, FilesResponse>, IFilesEndpoint
    {

        internal FilesEndpoint(XeroHttpClient client)
            : base(client, "files.xro/1.0/Files")
        {

        }

        public Model.File this[Guid id]
        {
            get
            {
                var result = Find(id);
                return result;
            }
        }

        public override IEnumerable<Model.File> Find()
        {
            var response = HandleFilesResponse(Client
                .Get("files.xro/1.0/Files", ""));

            return response.Items;
        }

        public override Model.File Find(Guid fileId)
        {
            var response = HandleFilesResponse(Client
                .Get("files.xro/1.0/Files", ""));

            return response.Items.SingleOrDefault(i => i.Id == fileId);
        }

        public Model.File Rename(Guid id, string name)
        {
            var response = HandleFileResponse(Client
                .Put("files.xro/1.0/Files/" + id, "{\"Name\":\"" + name + "\"}", true));


            return response;
        }

        public Model.File Move(Guid id, Guid newFolder)
        {
            var response = HandleFileResponse(Client
                .Put("files.xro/1.0/Files/" + id, "{\"FolderId\":\"" + newFolder + "\"}", true));


            return response;
        }

        public Model.File Add(Guid folderId, Model.File file, byte[] data)
        {

            var response = HandleFileResponse(Client
                .PostMultipartForm("files.xro/1.0/Files/" + folderId, file.Mimetype, file.Name, file.FileName, data));

            return response;
        }

        public Model.File Remove(Guid fileid)
        {
            var response = HandleFileResponse(Client
                .Delete("files.xro/1.0/Files/" + fileid.ToString()));

            return response;
        }

        public byte[] GetContent(Guid id, string contentType)
        {
            var response = Client.GetRaw("files.xro/1.0/Files/" + id + "/Content", contentType);

            using (MemoryStream ms = new MemoryStream())
            {
                response.Content.ReadAsStreamAsync().Result.CopyTo(ms);

                return ms.ToArray();
            }

        }

        private Model.File HandleFileResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                var result = Client.JsonMapper.From<Model.File>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }

        private FilesResponse HandleFilesResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                var body = response.Content.ReadAsStringAsync().Result;

                var result = Client.JsonMapper.From<FilesResponse>(body);
                return result;
            }

            Client.HandleErrors(response);

            return null;
        }
    }
}