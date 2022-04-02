using Bookworm.WebApi.Enums;
using Bookworm.WebApi.Models;

namespace Bookworm.WebApi.Data
{
    public class BookMockData
    {
        public static IList<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book
                {
                    BookId = 1,
                    Isbn10OrAsin = "125030170X",
                    Isbn13 = "978-1250301703",
                    Title = "The Silent Patient",
                    AuthorName = new Name
                    {
                        FirstName = "Alex",
                        LastName = "Michaelides"
                    },
                    Format = BookFormatType.Paperback,
                    Length = 368,
                    PublishedDate = new DateTime(2021, 5, 4)
                },
                new Book
                {
                    BookId = 2,
                    Title = "The Girl on the Train",
                    AuthorName = new Name
                    {
                        FirstName = "Paula",
                        LastName = "Hawkins"
                    },
                    Format = BookFormatType.Audio,
                    PublishedDate = new DateTime(2015, 1, 13)
                },
                new Book
                {
                    BookId = 3,
                    Isbn10OrAsin = "1501107976",
                    Isbn13 = "978-1501107979",
                    Title = "All the Missing Girls",
                    AuthorName = new Name
                    {
                        FirstName = "Megan",
                        LastName = "Miranda"
                    },
                    Format = BookFormatType.Paperback,
                    Length = 400,
                    PublishedDate = new DateTime(2017, 1, 31)
                },
                new Book
                {
                    BookId = 4,
                    Isbn10OrAsin = "B004J4WKTW",
                    Title = "The Night Circus",
                    AuthorName = new Name
                    {
                        FirstName = "Erin",
                        LastName = "Morgenstern"
                    },
                    Format = BookFormatType.Kindle,
                    Length = 401,
                    PublishedDate = new DateTime(2011, 9, 13)
                },
                new Book
                {
                    BookId = 5,
                    Isbn10OrAsin = "848304014X",
                    Isbn13 = "9788483040140",
                    Title = "Junie B. Jones and the Stupid Smelly Bus",
                    AuthorName = new Name
                    {
                        FirstName = "Barbara",
                        LastName = "Park"
                    },
                    Format = BookFormatType.Hardback,
                    Length = 89,
                    PublishedDate = new DateTime(2017, 1, 8)
                },
                new Book
                {
                    BookId = 6,
                    Isbn10OrAsin = "B00F3HG7TS",
                    Title = "Naruto, Vol. 1: Uzumaki Naruto",
                    AuthorName = new Name
                    {
                        FirstName = "Masashi",
                        LastName = "Kishimoto"
                    },
                    Format = BookFormatType.Kindle,
                    Length = 192,
                    PublishedDate = new DateTime(2010, 11, 2)
                }
            };
        }
    }
}
