namespace GiaiThua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soNguyen;
            if (int.TryParse(textBox1.Text, out soNguyen) && soNguyen >= 0)
            {
                long giaiThua = TinhGiaiThua(soNguyen);
                textBox2.Text = $"Giai thừa của {soNguyen} là: {giaiThua}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên không âm!");
            }
        }
    }
}
