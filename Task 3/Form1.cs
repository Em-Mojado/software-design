namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";

            }
        }

        public class TextBook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Subject: {Subject}";
            }
        }


        public class AudioBook : Book
        {
            public double Duration { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Duration: {Duration} hours";
            }
        }

        private void btnShowAudioBooks_Click(object sender, EventArgs e)
        {
            Book[] audiobooks = new Book[]
            {
                new AudioBook { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Duration = 5.5 },
                new AudioBook { Title = "To Kill a Mockingbird", Author = "Harper Lee", Duration = 6.0 },
                new AudioBook { Title = "1984", Author = "George Orwell", Duration = 8.0 }
            };

            txtListBox.Items.Clear();

            foreach (var book in audiobooks)
            {
                txtListBox.Items.Add(book.GetInfo());
            }   
        }

        private void btnShowTextBooks_Click(object sender, EventArgs e)
        {
            Book[] textbooks = new Book[]
            {
                new TextBook { Title = "Physics for Scientists and Engineers", Author = "Raymond A. Serway", Subject = "Physics" },
                new TextBook { Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Subject = "Computer Science" },
                new TextBook { Title = "Organic Chemistry", Author = "Paula Yurkanis Bruice", Subject = "Chemistry" }
            };  

            txtListBox.Items.Clear();

            foreach (var book in textbooks)
            {
                txtListBox.Items.Add(book.GetInfo());
            }
        }
    }
}
