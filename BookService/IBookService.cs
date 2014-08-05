using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Books.Library.Models;

namespace BookService
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [WebGet(ResponseFormat=WebMessageFormat.Json)]
        List<Book> GetBooksList();

        [OperationContract]
        [WebGet(UriTemplate = "Book/{id}", ResponseFormat=WebMessageFormat.Json)]
        Book GetBookById(string id);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "AddBook/{name}")]
        void AddBook(string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateBook/{id}/{name}")]
        void UpdateBook(string id, string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteBook/{id}")]
        void DeleteBook(string id);
    }
}
