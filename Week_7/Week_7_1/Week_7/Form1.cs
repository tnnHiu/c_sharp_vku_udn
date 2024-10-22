namespace Week_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            try
            {
                a = Convert.ToDouble(tbNum1.Text);
                b = Convert.ToDouble(tbNum2.Text);
            }
            catch (Exception exc)
            {

                MessageBox.Show($"Lỗi số {exc.Message}");
            }

            double tong = a + b;
            tbSum.Text = tong.ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tbNum1.Text = "";
            tbNum2.Text = "";
            tbSum.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
