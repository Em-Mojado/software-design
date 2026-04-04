using System.Security.Cryptography.X509Certificates;

namespace CustomDescendingOrder_Task5_
{
    public partial class Form1 : Form
    {
        public class DescendingComparer<T> : IComparer<T>
        {
            public int Compare(T x, T y)
            {
                return Comparer<T>.Default.Compare(y, x);
            }
        }

        public class ArrangeDescending
        {
            public static List<int> Main()
            {
                List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6 };
                numbers.Sort(new DescendingComparer<int>());

                return numbers;
            }
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void btnD_Click(object sender, EventArgs e)
        {
           listBoxResults.DataSource = ArrangeDescending.Main();
        }
    }
}
