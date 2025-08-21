// See https://aka.ms/new-console-template for more information
using LibraryManagementApp.Models;

Console.WriteLine("Hello, World!");
Book newBook = new Book(1, "C# in Depth", "C# in Depth", "Jon Skeet");
Console.WriteLine($"Title: {newBook.Title}, Author: {newBook.Author}, Description: {newBook.Description}, Available: {newBook.IsAvailable}");
newBook.BorrowBook();
Console.WriteLine($"After borrowing: Available= {newBook.IsAvailable}");
newBook.ReturnBook();
Console.WriteLine($"After returning: Available={newBook.IsAvailable}");
