using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Xero.Api.Common;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public interface IFoldersEndpoint : IXeroUpdateEndpoint<FoldersEndpoint, Model.Folder, FolderRequest, FolderResponse>
    {
        FoldersResponse[] Folders { get; }
        FilePageResponse Add(string folderName);
        void Remove(Guid id);
        FoldersResponse Rename(Guid id, string name);
    }

    public class FoldersEndpoint : XeroUpdateEndpoint<FoldersEndpoint, Model.Folder, FolderRequest, FolderResponse>, IFoldersEndpoint
  {
    internal FoldersEndpoint(XeroHttpClient client)
        : base(client, "files.xro/1.0/Folders")
    {

    }

    public FoldersResponse[] Folders
    {
      get
      {
        var endpoint = string.Format("files.xro/1.0/Folders");

        var folder = HandleFoldersResponse(Client
            .Get(endpoint, null));

        return folder;
      }
    }

    public FilePageResponse Add(string folderName)
    {
      var endpoint = string.Format("files.xro/1.0/Folders");

      var result = HandleFolderResponse(Client
          .Post(endpoint, Client.JsonMapper.To(new Folder() { Name = folderName }), true));

      return result;
    }

    public IList<Model.Folder> Find()
    {
      var response = HandleFoldersResponse(Client
          .Get("files.xro/1.0/Folders", ""));


      var resultingFolders = from i in response
                             select new Folder() { Id = i.Id, Name = i.Name, IsInbox = i.IsInbox, FileCount = i.FileCount };

      return resultingFolders.ToList();
    }

    public void Remove(Guid id)
    {
      var response = HandleFolderResponse(Client
          .Delete("files.xro/1.0/Folders/" + id.ToString()));
    }

    public FoldersResponse Rename(Guid id, string name)
    {
      var response = HandleFoldersResponse(Client.Put("files.xro/1.0/Folders/" + id, "{\"Name\":\"" + name + "\"}", true));
      return (response != null) ? response[0] : null;
    }

    private FilePageResponse HandleFolderResponse(HttpResponseMessage response)
    {
      if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
      {
        var body = response.Content.ReadAsStringAsync().Result;

        var result = Client.JsonMapper.From<FilePageResponse>(body);

        return result;
      }

      Client.HandleErrors(response);

      return null;
    }

    private FoldersResponse[] HandleFoldersResponse(HttpResponseMessage response)
    {
      if (response.StatusCode == HttpStatusCode.OK)
      {
        var body = response.Content.ReadAsStringAsync().Result;

        var result = Client.JsonMapper.From<FoldersResponse[]>(body);

        return result;
      }

      Client.HandleErrors(response);

      return null;
    }
  }

  public class FolderResponse : XeroResponse<Model.Folder>
  {
    public override IList<Folder> Values
    {
      get { throw new System.NotImplementedException(); }
    }
  }

  public class FolderRequest : XeroRequest<Model.Folder>
  {
  }
}