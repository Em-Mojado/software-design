using System.Net;

namespace lab4
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
                return $"Title: {Title}, Author: {Author}";
            }
        }
		public class Magazine : Book
		{
			public int IssueNumber { get; set; }

			public override string GetInfo()
			{
				return $"Title: {Title}, Author: {Author}, Issue Number: {IssueNumber}";
            }

        }
        public void TestBookCreation()
        {
            Book book = new Book { Title = "C# Programming", Author = "Jhon Smith" };
            Assert.AreEqual("C# Programming", book.Title);
			Assert.AreEqual("Jhon Smith", book.Author);
        }

        public void TextMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Tech Today", IssueNumber = 42 };
            Assert.AreEqual("Tech Today", magazine.Title);
            Assert.AreEqual(42, magazine.IssueNumber);
        }


    }
}
