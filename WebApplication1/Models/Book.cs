namespace WebApplication1.Models
{
    public class Book
    {
        private int id;
        private string title;
        private string author;
        private string cover;
        
        public Book() { }

        public Book(int id, string title, string author, string cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.cover = cover;
        }

        public int Id => id;

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Cover
        {
            get => cover;
            set => cover = value;
        }
    }
    
}