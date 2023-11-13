namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateTip_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(txtAmount.Text);
            decimal tax = decimal.Parse(txtPercentage.Text) / 100.00M;

            lblResult.Text = $"The tip amount is {(amount * tax):c}";
        }
    }
}