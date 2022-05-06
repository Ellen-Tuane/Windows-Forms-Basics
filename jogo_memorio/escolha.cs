namespace Memoria
{
    public partial class escolha : Form
    {
        public escolha()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            string getText = comboBox2.SelectedItem.ToString();

            if (string.IsNullOrEmpty(getText))
            {
                MessageBox.Show("getText is empty");
            }
            else
            {
                switch (getText)
                {
                    case "2x2":
                        Form janela1 = new Form();
                        janela1.Show();
                        this.Hide();
                        break;

                    case "3x3":
                        Form janela2 = new Form();
                        janela2.Show();
                        this.Hide();
                        break;
                }
            }
        }
    }
}
