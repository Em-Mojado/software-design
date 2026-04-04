namespace lab2
{
    public partial class btnCalculateSum : Form
    {
        public btnCalculateSum()
        {
            InitializeComponent();
        }
        public int RecursiveFactorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * RecursiveFactorial(n - 1);
        }

        private void btnCalculateFactorial_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            int result = RecursiveFactorial(number);
            lblResult.Text = $"Factorial: {result}";
        }

        public int RecursiveSum(int[] numbers, int n)
        {
            if (n == 0)
                return numbers[0];
            else
                return numbers[n] + RecursiveSum(numbers, n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = txtArrayInput.Text.Split(',').Select(int.Parse).ToArray();
            int result = RecursiveSum(numbers, numbers.Length - 1);
            lblSumResult.Text = $"Sum: {result}";
        }

        public long RecursiveFibonacci(int n)
        {
            if (n <= 0)
                return 0;

            if (n == 1)
                return 1;

            else
                return RecursiveFibonacci(n - 1) + RecursiveFibonacci(n - 2);
        }

        private void btnCalculateFibonacci_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFibonacciInput.Text, out int n))
            {
                long result = RecursiveFibonacci(n);
                lblFibonacciResult.Text = $"Fibonacci number {n}: {result}";
            }
        }
        public double RecursivePower(double nbase, int nexponent)
        {
            if (nexponent == 0) return 1;
            return nbase * RecursivePower(nbase, nexponent - 1);
        }

        private void brnCalculatePower_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBaseInput.Text, out double nbase) && int.TryParse(txtExponentInput.Text, out int nexponent))
            {
                double result = RecursivePower(nbase, nexponent);
                lblPowerResult.Text = $"Result of {nbase}^{nexponent}: {result}";
            }
        }
    }
}

