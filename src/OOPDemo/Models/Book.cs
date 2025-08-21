namespace LibraryManagementApp.Models
{
    public class Book
    {
        private string _id;
        private string _title;
        private string _description;
        private string _author;
        private bool _isAvailable;
        public int Id { get; set; }
        public string Title { 
            get { return _title; }
            set {
                if (!string.IsNullOrWhiteSpace(value))
                    _title = value;
                else
                    throw new ArgumentException("Title cannot be empty");
            }
        }
        public string Description {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _description = value;
                else
                    throw new ArgumentException("Description cannot be empty");
            }
        }
        public string Author {
            get { return _author; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _author = value;
                else
                    throw new ArgumentException("Author cannot be empty");
            }
        }
        public bool IsAvailable {
            get { return _isAvailable; }
            private set { _isAvailable = value; }
        }
        public Book(int id, string title, string description, string author)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            IsAvailable = true;
        }

        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
            }
            else
            {
                throw new InvalidOperationException("Book already borrowed!");
            }

        }
        public void ReturnBook()
        {
            IsAvailable = true;
        }
    }
}