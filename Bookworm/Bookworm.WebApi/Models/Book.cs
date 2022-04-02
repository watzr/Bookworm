using Bookworm.WebApi.Enums;

namespace Bookworm.WebApi.Models
{
    public class Book
    {
        public int BookId { get; set; }

        /**
         * For Paperback, and Hard cover, it is ISBN10.
         * Kindle will have ASIN. None for Audio books.
        **/
        public string Isbn10OrAsin { get; set; }

        public string Isbn13 { get; set; }

        public string Title { get; set; }

        public Name AuthorName { get; set; }

        public BookFormatType? Format { get; set; }

        /**
         * For Paperback, Hard cover, and Kindle, length is the number of pages.
         * For audio books, it is the number of minutes.
        **/
        public int? Length { get; set; }

        public DateTime? PublishedDate { get; set; }
    }
}
