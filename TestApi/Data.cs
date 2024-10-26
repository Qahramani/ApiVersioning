using TestApi.Models;

namespace TestApi;

public static class Data
{
    public static List<Student> students;
    public static List<Book> books;
    static Data()
    {
        students = [
          new Student{
              Id = 1,
              Name = "Fatima",
              Grade = 100
          },
         new Student{
              Id = 2,
              Name = "Asiman",
              Grade = 92
          },
         new Student{
              Id = 1,
              Name = "Samira",
              Grade = 57
          },
         new Student{
              Id = 1,
              Name = "Sinara",
              Grade = 89
          }
        ];

        books = [
            new Book{
                id = 1,
                Name = "The way of Integrity",
                Author = "Martha Beck"
            },
            new Book{
                id = 2,
                Name = "The Kite Runner",
                Author = "Khaled Hosseini"
            },
            new Book{
                id = 3,
                Name = "Notes From Undergrounds",
                Author = "Fyodor Dostoyevsky"
            },
            ];
    }
       
}
