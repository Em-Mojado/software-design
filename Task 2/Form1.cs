namespace Task_2
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

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string Format { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} - Format: {Format}";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            Book[] library = new Book[]
            {
                new Book { Title = "The Great Gatsby", Author = "F. Scott Fitzgerald" },
                new Magazine { Title = "National Geographic", Author = "Various", IssueNumber = 202 },
                new Ebook { Title = "1984", Author = "George Orwell", Format = "PDF" }
            };

            txtList.Items.Clear();  

            foreach (var item in library)
            {
               txtList.Items.Add(item.GetInfo());
            }

        }

    }
}
