using System.Data;

namespace notetakingapp {
    public partial class Form1 : Form {

        DataTable table;
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

            table = new DataTable();
            table.Columns.Add("Título", typeof(string));
            table.Columns.Add("Mensagem", typeof(string));
            dgvCaixa.DataSource = table;
            dgvCaixa.Columns["Mensagem"].Visible = false;
            dgvCaixa.Columns["Título"].Width = 300;

        }

        private void btnNovo_Click(object sender, EventArgs e) {

            txtTitulo.Clear();
            txtMensagem.Clear();

        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            table.Rows.Add(txtTitulo.Text, txtMensagem.Text);
            btnNovo.PerformClick();
        }

        private void btnLer_Click(object sender, EventArgs e) {

            int index = dgvCaixa.CurrentCell.RowIndex;
            if (index > -1) {
                txtTitulo.Text = table.Rows[index].ItemArray[0].ToString();
                txtMensagem.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDEL_Click(object sender, EventArgs e) 
            {
            
            int index = dgvCaixa.CurrentCell.RowIndex;
            table.Rows[index].Delete();

        }
    }
}
