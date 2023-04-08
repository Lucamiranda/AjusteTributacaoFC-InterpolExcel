using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AjusteProdutos.Modelos;
using FirebirdSql.Data.FirebirdClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace AjusteProdutos
{

    public partial class Form : System.Windows.Forms.Form
    {


        private string _Grupo;
        private Modelo Modelo = new Modelo();
        private ClFiscal fiscal = new ClFiscal();
        AjusteDAO AjusteDAO = new AjusteDAO();
        CarregarGrid grid = new CarregarGrid();
        public Form()
        {
            InitializeComponent();
        }
        private void LimparLabel()
        {
            toolStripStatusLabel1.Text = "";
            toolStripStatusLabel2.Text = "";
            toolStripStatusLabel3.Text = "";
        }
        public void Setor()
        {
            if (rbRevenda.Checked || rbRevendaNCM.Checked || rbRevSubNCM.Checked)
            {
                LimparLabel();
                _Grupo = "= 'R'";
                toolStripStatusLabel1.Text = "R - REVENDA ";
            }
            if (rbDrogaria.Checked || rbDrogariaNCM.Checked || rbDroSubNMC.Checked)
            {
                LimparLabel();
                _Grupo = "= 'D'";
                toolStripStatusLabel2.Text = "D - DROGARIA ";
            }
            if (rbAmbos.Checked || rbAmbosNCM.Checked || rbSubAmbos.Checked)
            {
                LimparLabel();
                _Grupo = "IN ('R', 'D')";
                toolStripStatusLabel1.Text = "R - REVENDA ";
                toolStripStatusLabel2.Text = "D - DROGARIA ";
            }
        }
        public void ProgressBar(Int32 valorMaximo)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = valorMaximo;
            Int32 contagem = valorMaximo;
            for (Int32 i = 0; i <= contagem; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void btn_Pesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Setor();
                List<Modelo> lista = AjusteDAO.ListarTodosArray(_Grupo);
                dgConsultaProd.DataSource = lista;
                grid.CarregaGridProdutos(dgConsultaProd);



                Int32 contagem = int.Parse(lista.Count.ToString());
                toolStripStatusLabel3.Text = "TOTAL DE PRODUTOS: " + contagem.ToString();
                ProgressBar(contagem);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não foi Possivel Conectar ao banco de Dados, verifique o arquivo Alterdb.ini");
            }
            catch (FbException)
            {
                MessageBox.Show("Selecione o grupo de Produto", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_LocalizarPlanilha_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoImport.Text = open.FileName;
                var arquivo = txtCaminhoImport.Text;
                var planilha = "Select * from [CST-PIS-COFINS$]";
                var strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + arquivo + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"";
                try
                {
                    var dt = new DataTable();
                    using (OleDbConnection con = new OleDbConnection(strCon))
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(planilha, con))
                        {
                            da.Fill(dt);
                            dgConsultaProd.DataSource = dt;
                            grid.CarregaGridProdutos(dgConsultaProd);
                            ProgressBar(dgConsultaProd.Rows.Count);
                            toolStripStatusLabel1.Text = "R - REVENDA";
                            toolStripStatusLabel2.Text = "D - DROGARIA";
                            toolStripStatusLabel3.Text = "TOTAL DE PRODUTOS: " + dt.Rows.Count;

                        }
                    }
                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("Para realizar a importação Microsoft Office Excel deve estar instalado no computador", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Importação falhou, verifique se o arquivo esta correto", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void btnImportar_Click_1(object sender, EventArgs e)
        {
            if (dgConsultaProd.Rows.Count == 0) return;
            try
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = dgConsultaProd.Rows.Count;
                for (int i = 0; i <= dgConsultaProd.Rows.Count - 1; i++)
                {
                    Modelo.codigoProduto = dgConsultaProd.Rows[i].Cells[0].Value.ToString();
                    Modelo.descricaoProduto = dgConsultaProd.Rows[i].Cells[1].Value.ToString();
                    Modelo.grupoProduto = dgConsultaProd.Rows[i].Cells[2].Value.ToString();
                    Modelo.CST = (dgConsultaProd.Rows[i].Cells[3].Value.ToString());
                    Modelo.aliquotaICMS = dgConsultaProd.Rows[i].Cells[4].Value.ToString();
                    Modelo.codigoPIS = dgConsultaProd.Rows[i].Cells[5].Value.ToString();
                    Modelo.aliquotaPIS = dgConsultaProd.Rows[i].Cells[6].Value.ToString();
                    Modelo.codigoCOFINS = dgConsultaProd.Rows[i].Cells[7].Value.ToString();
                    Modelo.aliquotaCOFINS = dgConsultaProd.Rows[i].Cells[8].Value.ToString();
                    Modelo.codigoIPI = dgConsultaProd.Rows[i].Cells[9].Value.ToString();
                    Modelo.aliquotaIPI = dgConsultaProd.Rows[i].Cells[10].Value.ToString();
                    Modelo.NCM = dgConsultaProd.Rows[i].Cells[11].Value.ToString();
                    Modelo.CFOP = "";
                    Modelo.listaPisCofins = dgConsultaProd.Rows[i].Cells[13].Value.ToString().ToLower();
                    AjusteDAO.Atualizar(Modelo);
                    progressBar1.Value = i + 1;
                }
                MessageBox.Show("Importação Realizada com sucesso", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Informe a planilha antes de importa-lá", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnExportar_Click_1(object sender, EventArgs e)
        {
            ExportarExcel ex = new ExportarExcel();
            ex.ExportarParaExcel(dgConsultaProd);
        }

        private void btnBuscarNCM_Click(object sender, EventArgs e)
        {
            try
            {
                Setor();
                List<ClFiscal> lista = AjusteDAO.ListarTodosNCM(_Grupo);
                dgConsultaNCM.DataSource = lista;
                grid.CarregaGridNCM(dgConsultaNCM);


                Int32 contagem = int.Parse(lista.Count.ToString());
                toolStripStatusLabel3.Text = "TOTAL DE NCM: " + contagem.ToString();
                ProgressBar(contagem);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não foi Possivel Conectar ao banco de Dados, verifique o arquivo Alterdb.ini");
            }
            catch (FbException)
            {
                MessageBox.Show("Selecione o grupo de Produto", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExportarNCM_Click(object sender, EventArgs e)
        {
            ExportarExcel ex = new ExportarExcel();
            ex.ExportarParaExcel(dgConsultaNCM);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            _Grupo = null;
            rbRevenda.Checked = false;
            rbDrogaria.Checked = false;
            rbAmbos.Checked = false;
            rbRevendaNCM.Checked = false;
            rbDrogariaNCM.Checked = false;
            rbAmbosNCM.Checked = false;
            rbRevSubNCM.Checked = false;
            rbSubAmbos.Checked = false;
            rbDroSubNMC.Checked = false;
            dgConsultaProd.DataSource = null;
            dgConsultaNCM.DataSource = null;
            dgAlteraNCM.DataSource = null;
            txtAntigo.Text = "";
            txtCaminhoImport.Text = "";
            txtNovo.Text = "";
            LimparLabel();
            progressBar1.Value = 0;
        }

        private void btnImportarNCM_Click(object sender, EventArgs e)
        {

            if (dgConsultaNCM.Rows.Count == 0) return;
            try
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = dgConsultaNCM.Rows.Count;
                for (int i = 0; i <= dgConsultaNCM.Rows.Count - 1; i++)
                {
                    fiscal.NCM = dgConsultaNCM.Rows[i].Cells[0].Value.ToString();
                    fiscal.CST = (dgConsultaNCM.Rows[i].Cells[1].Value.ToString());
                    fiscal.aliquotaICMS = dgConsultaNCM.Rows[i].Cells[2].Value.ToString().Replace(",", ".");
                    fiscal.codigoPIS = dgConsultaNCM.Rows[i].Cells[3].Value.ToString();
                    fiscal.aliquotaPIS = dgConsultaNCM.Rows[i].Cells[4].Value.ToString().Replace(",", ".");
                    fiscal.codigoCOFINS = dgConsultaNCM.Rows[i].Cells[5].Value.ToString();
                    fiscal.aliquotaCOFINS = dgConsultaNCM.Rows[i].Cells[6].Value.ToString().Replace(",", ".");
                    fiscal.codigoIPI = dgConsultaNCM.Rows[i].Cells[7].Value.ToString();
                    fiscal.aliquotaIPI = dgConsultaNCM.Rows[i].Cells[8].Value.ToString().Replace(",", ".");
                    fiscal.CFOP = "";
                    fiscal.listaPisCofins = dgConsultaNCM.Rows[i].Cells[10].Value.ToString().ToLower();


                    switch (dgConsultaNCM.Rows[i].Cells[11].Value.ToString().ToLower())
                    {
                        case "drogaria":
                            _Grupo = "D";
                            break;
                        case "revenda":
                            _Grupo = "R";
                            break;
                        default:
                            break;
                    }
                    AjusteDAO.AtualizarNCM(fiscal, _Grupo);
                    progressBar1.Value = i + 1;
                }
                MessageBox.Show("Importação Realizada com sucesso", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Informe a planilha antes de importa-lá", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCarregarPlanNCM_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtCaminhoImport.Text = open.FileName;
                var arquivo = txtCaminhoImport.Text;
                var planilha = "Select * from [NCM-CST-PIS-COFINS$]";
                var strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + arquivo + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=0\"";
                try
                {
                    var dt = new DataTable();
                    using (OleDbConnection con = new OleDbConnection(strCon))
                    {
                        using (OleDbDataAdapter da = new OleDbDataAdapter(planilha, con))
                        {
                            da.Fill(dt);
                            dgConsultaNCM.DataSource = dt;
                            grid.CarregaGridNCM(dgConsultaNCM);
                            ProgressBar(dgConsultaNCM.Rows.Count);
                            toolStripStatusLabel1.Text = "R - REVENDA";
                            toolStripStatusLabel2.Text = "D - DROGARIA";
                            toolStripStatusLabel3.Text = "TOTAL DE PRODUTOS: " + dt.Rows.Count;
                        }
                    }
                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("Para realizar a importação Microsoft Office Excel deve estar instalado no computador", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (OleDbException)
                {
                    MessageBox.Show("Importação falhou, verifique se o arquivo esta correto", "Importação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnProdNcm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAntigo.Text.Trim() != "")
                {
                    Setor();
                    List<Modelo> lista = AjusteDAO.ListarTodosArray(_Grupo, txtAntigo.Text);
                    dgAlteraNCM.DataSource = lista;
                    grid.CarregaGridProdutos(dgAlteraNCM);


                    Int32 contagem = int.Parse(lista.Count.ToString());
                    toolStripStatusLabel3.Text = "TOTAL DE PRODUTOS: " + contagem.ToString();
                    ProgressBar(contagem);
                }

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Não foi Possivel Conectar ao banco de Dados, verifique o arquivo Alterdb.ini");
            }
            catch (FbException)
            {
                MessageBox.Show("Selecione o grupo de Produto", "Pesquisar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAlterarNCM_Click(object sender, EventArgs e)
        {
            if (dgAlteraNCM.Rows.Count == 0 || txtAntigo.Text == "" || txtNovo.Text == "") return;
            try
            {
                progressBar1.Value = 0;
                progressBar1.Maximum = dgAlteraNCM.Rows.Count;
                for (int i = 0; i <= dgAlteraNCM.Rows.Count - 1; i++)
                {
                    fiscal.NCM = txtNovo.Text;

                    AjusteDAO.AlteraNCM(fiscal, _Grupo, txtAntigo.Text);
                    progressBar1.Value = i + 1;
                }
                MessageBox.Show("Alteração Realizada com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgAlteraNCM.DataSource = null;
                LimparLabel();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha na Alteração", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

    }
}
