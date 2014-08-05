using System.Runtime.Serialization;

namespace Books.Library.Models
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string BookTitle { get; set; }
    }
}
