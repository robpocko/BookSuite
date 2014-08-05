using System.Collections.Generic;
using System.ServiceModel;
using Books.Library.Models;

namespace BookService
{
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        List<Book> GetBooksList();

        [OperationContract]
        Book GetBookById(int id);

        [OperationContract]
        void AddBook(string name);

        [OperationContract]
        void UpdateBook(int id, string name);

        [OperationContract]
        void DeleteBook(int id);

        [OperationContract]
        string TestMe();
    }
}
