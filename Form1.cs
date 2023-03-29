namespace _0206_полічити_кількість_слів
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            int res = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                {
                    res++;
                }
            }
            if (x.Length == 0)
            {
                label3.Text = "Ви не ввели жодного слова.";
            }
            else
            {
                res++;
                label3.Text = $"слів - {res}";
            }
            
        }
    }
}