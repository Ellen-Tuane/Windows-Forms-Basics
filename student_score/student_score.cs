namespace student_score
{
    public partial class student_score : Form
    {
        public student_score()
        {
            InitializeComponent();
        }

        private void student_score_Load(object sender, EventArgs e)
        {

        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntMedia_Click(object sender, EventArgs e)
        {
            student student = new student();
            student.Matricula = Convert.ToInt32(txtMatricula.Text);
            student.Nome = Convert.ToString(txtNome.Text);
            student.NotaProva1 = Convert.ToDouble(txtProva1.Text);
            student.NotaProva2 = Convert.ToDouble(txtProva2.Text);
            student.NotaTrabalho = Convert.ToDouble(txtTrabalho.Text);

            student.Score = student.Media(student.NotaProva1, student.NotaProva2, student.NotaTrabalho);

            lstMedia.Items.Add(student.Score);
        }

        private void bntCleanBox_Click(object sender, EventArgs e)
        {

        }

        private void bntCleanList_Click(object sender, EventArgs e)
        {
            lstMedia.Items.Clear();
            txtMatricula.Clear();
            txtNome.Clear();
            txtProva1.Clear();
            txtProva2.Clear();
            txtTrabalho.Clear();

        }
    }
}