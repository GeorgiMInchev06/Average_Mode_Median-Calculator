namespace CalculatorAverageModeMedian
{
    public partial class Calculator : Form
    {
        private Calculating calculating;
        public Calculator()
        {
            InitializeComponent();
            calculating = new Calculating();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string[] numbersArray = input.Split(' ');
            double[] numbers = Array.ConvertAll(numbersArray, double.Parse);

            if (numbers.Length == 0)
            {
                MessageBox.Show("Please enter some numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double average = numbers.Average();

            double mode = calculating.CalculateMode(numbers);

            double median = calculating.CalculateMedian(numbers);

            txtAverage.Text = $"{average:F1}";
            txtMode.Text = $"{mode:F1}";
            txtMedian.Text = $"{median:F1}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtAverage.Text = string.Empty;
            txtMode.Text = string.Empty;
            txtMedian.Text = string.Empty;
        }
    }
}