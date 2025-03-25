using plecak;

namespace Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void run_Click(object sender, EventArgs e)
        {
            try { 
                int n = int.Parse(numberOfItems.Text);
                int Seed = int.Parse(seed.Text);
                int Capacity = int.Parse(capacity.Text);
                Problem problem = new Problem(n, Seed, Capacity);
                itemsBox.Text = problem.ToString();
                Result problemSolution = problem.Solve();
                result.Text = problemSolution.ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message);
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
