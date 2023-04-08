using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;
using AjusteProdutos.Modelos;

namespace AjusteProdutos
{
    internal class AjusteDAO
    {
        private static FbDataReader _FbDataReader;
        private static FbCommand _FbCommand;

        private DataTable _Parametros;
        private static FbDataAdapter _Adaptador;

        private Conexao conexao = new Conexao();

        public AjusteDAO()
        {
            Parametros();
        }
        public void Atualizar(Modelo produto)
        {
            _FbCommand = new FbCommand();
            _FbCommand.Connection = conexao.ObterConexao();

            _FbCommand.CommandText = "update FC03000" +
             " set STRIB = @STRIB," +
             " CDICM = @CDICM," +
             " CDSITPIS = @CDSITPIS," +
             " CDPIS = @CDPIS," +
             " CDSITCOFINS = @CDSITCOFINS," +
             " CDCOFINS = @CDCOFINS," +
             " CDSITIPI = @CDSITIPI," +
             " CDIPI = @CDIPI," +
             " CLFISC = @CLFISC," +
             " INDCIP = @INDCIP" +
            " where CDPRO = @CDPRO";

            //Se o codigo do produto for vazio, excecução pula essa linha
            if (produto.codigoProduto.Trim() == "") { return; }
            _FbCommand.Parameters.Add("@CDPRO", SqlDbType.Int).Value = produto.codigoProduto;
            _FbCommand.Parameters.Add("@CLFISC", SqlDbType.VarChar).Value = produto.NCM;


            switch (produto.listaPisCofins.ToLower())
            {
                case "normal":
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "N";
                    break;
                case "negativa":
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "S";
                    break;
                case "isenta":
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "I";
                    break;
                default:
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "";
                    break;
            }

            //Se o campo da planilha for vazio, irá gravar no banco como vazio. Caso não tenha o parametro cadastrado não terá nenhuma reação no update.
            try
            {
                if (produto.CST.Trim() == "") { _FbCommand.Parameters.Add("@STRIB", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@STRIB", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'STRIB' and PARAMETRO=" + produto.CST)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaICMS.Trim() == "") { _FbCommand.Parameters.Add("@CDICM", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDICM", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CICMS' and PARAMETRO='" + produto.aliquotaICMS + "'")[0].ItemArray[1].ToString().Trim(); }

            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.codigoPIS.Trim() == "") { _FbCommand.Parameters.Add("@CDSITPIS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDSITPIS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'SITTRIBPIS' and SUBARGUM=" + produto.codigoPIS)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaPIS.Trim() == "") { _FbCommand.Parameters.Add("@CDPIS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDPIS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CDPIS' and PARAMETRO='" + produto.aliquotaPIS + "'")[0].ItemArray[1].ToString().Trim(); }

            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.codigoCOFINS.Trim() == "") { _FbCommand.Parameters.Add("@CDSITCOFINS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDSITCOFINS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'SITTRIBCOFINS' and SUBARGUM=" + produto.codigoCOFINS)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaCOFINS.Trim() == "") { _FbCommand.Parameters.Add("@CDCOFINS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDCOFINS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CDCOFINS' and PARAMETRO='" + produto.aliquotaCOFINS + "'")[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.codigoIPI.Trim() == "") { _FbCommand.Parameters.Add("@CDSITIPI", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDSITIPI", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'SITTRIBIPI' and SUBARGUM=" + produto.codigoIPI)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaIPI.Trim() == "") { _FbCommand.Parameters.Add("@CDIPI", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDIPI", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CDIPI' and PARAMETRO='" + produto.aliquotaIPI + "'")[0].ItemArray[1].ToString().Trim(); }

            }
            catch (IndexOutOfRangeException) { }


            try
            {
                _FbCommand.ExecuteNonQuery();
            }
            catch (FbException) { }


            conexao.CloseConnection();
        }
        public List<Modelo> ListarTodosArray(string setor, string NCM ="")
        {
            List<Modelo> listaProduto = new List<Modelo>();
            Modelo produtos;
            conexao.ObterConexao();
            _FbCommand = new FbCommand();
            _FbCommand.Connection = conexao.ObterConexao();

            if(NCM.ToString().Trim() != "")
            {

                _FbCommand.CommandText = "Select CDPRO, DESCR, STRIB, CDICM, CDSITPIS, CDPIS, CDSITCOFINS, CDCOFINS, CDSITIPI, CDIPI, CLFISC, INDCIP, CDCEST, GRUPO " +
                "FROM FC03000 where Grupo " + setor + "AND CLFISC ='" + NCM +"'";
            }
            else
            {
                _FbCommand.CommandText = "Select CDPRO, DESCR, STRIB, CDICM, CDSITPIS, CDPIS, CDSITCOFINS, CDCOFINS, CDSITIPI, CDIPI, CLFISC, INDCIP, CDCEST, GRUPO " +
                "FROM FC03000 where Grupo " + setor + "ORDER BY Grupo";
            }

            _FbDataReader = _FbCommand.ExecuteReader();

            while (_FbDataReader.Read())
            {
                produtos = new Modelo();
                produtos.codigoProduto = _FbDataReader["CDPRO"].ToString();
                produtos.descricaoProduto = _FbDataReader["DESCR"].ToString();
                produtos.grupoProduto = _FbDataReader["GRUPO"].ToString();
                produtos.codigoPIS = _FbDataReader["CDSITPIS"].ToString();
                produtos.codigoCOFINS = _FbDataReader["CDSITCOFINS"].ToString();
                produtos.codigoIPI = _FbDataReader["CDSITIPI"].ToString();
                produtos.NCM = _FbDataReader["CLFISC"].ToString().Trim();


                //Parametros não encontrados devem retornar uma consulta conforme o registro do banco
                if (_FbDataReader["STRIB"].ToString().Trim() == "")
                {
                    produtos.CST = _FbDataReader["STRIB"].ToString();
                }
                else
                {
                    try { produtos.CST = _Parametros.Select("ARGUMENTO = 'STRIB' and SUBARGUM='" + _FbDataReader["STRIB"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { produtos.CST = _FbDataReader["STRIB"].ToString(); }
                }

                if (_FbDataReader["CDICM"].ToString().Trim() == "")
                {
                    produtos.aliquotaICMS = _FbDataReader["CDICM"].ToString();
                }
                else
                {
                    try { produtos.aliquotaICMS = _Parametros.Select("ARGUMENTO = 'CICMS' and SUBARGUM='" + _FbDataReader["CDICM"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { produtos.aliquotaICMS = _FbDataReader["CDICM"].ToString(); }
                }

                if (_FbDataReader["CDPIS"].ToString().Trim() == "")
                {
                    produtos.aliquotaCOFINS = _FbDataReader["CDPIS"].ToString();
                }
                else
                {
                    try { produtos.aliquotaPIS = _Parametros.Select("ARGUMENTO = 'CDPIS' and SUBARGUM='" + _FbDataReader["CDPIS"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { produtos.aliquotaCOFINS = _FbDataReader["CDPIS"].ToString(); }
                }

                if (_FbDataReader["CDCOFINS"].ToString().Trim() == "")
                {
                    produtos.aliquotaCOFINS = _FbDataReader["CDCOFINS"].ToString();
                }
                else
                {
                    try { produtos.aliquotaCOFINS = _Parametros.Select("ARGUMENTO = 'CDCOFINS' and SUBARGUM='" + _FbDataReader["CDCOFINS"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { produtos.aliquotaCOFINS = _FbDataReader["CDCOFINS"].ToString(); }
                }

                if (_FbDataReader["CDIPI"].ToString().Trim() == "")
                {
                    produtos.aliquotaIPI = _FbDataReader["CDIPI"].ToString();
                }
                else
                {
                    try { produtos.aliquotaIPI = _Parametros.Select("ARGUMENTO = 'CDIPI' AND SUBARGUM='" + _FbDataReader["CDIPI"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { produtos.aliquotaIPI = _FbDataReader["CDIPI"].ToString(); }
                }

                switch (_FbDataReader["INDCIP"].ToString().ToLower())
                {
                    case "n":
                        produtos.listaPisCofins = "Normal";
                        break;
                    case "s":
                        produtos.listaPisCofins = "Negativa";
                        break;
                    case "i":
                        produtos.listaPisCofins = "Isenta";
                        break;
                    default:
                        produtos.listaPisCofins = _FbDataReader["INDCIP"].ToString();
                        break;
                }

                listaProduto.Add(produtos);
            }
            _FbDataReader.Close();
            conexao.CloseConnection();
            return listaProduto;
        }


        public List<ClFiscal> ListarTodosNCM(string setor)
        {
            List<ClFiscal> listaNCM = new List<ClFiscal>();
            ClFiscal ncm;
            conexao.ObterConexao();
            _FbCommand = new FbCommand();
            _FbCommand.Connection = conexao.ObterConexao();

            _FbCommand.CommandText = "SELECT DISTINCT CLFISC, GRUPO, STRIB, CDICM, CDSITPIS, CDPIS,  CDSITCOFINS, CDCOFINS, CDSITIPI, CDIPI, INDCIP FROM FC03000 " +
                "WHERE CLFISC != ' ' AND FC03000.GRUPO " + setor + "ORDER BY Grupo";


            _FbDataReader = _FbCommand.ExecuteReader();

            while (_FbDataReader.Read())
            {
                ncm = new ClFiscal();

                ncm.NCM = _FbDataReader["CLFISC"].ToString().Trim();
                ncm.CST = _FbDataReader["STRIB"].ToString().Trim();
                ncm.codigoPIS = _FbDataReader["CDSITPIS"].ToString();
                ncm.codigoCOFINS = _FbDataReader["CDSITCOFINS"].ToString();
                ncm.codigoIPI = _FbDataReader["CDSITIPI"].ToString();


                //Parametros não encontrados devem retornar uma consulta conforme o registro do banco
                if (_FbDataReader["STRIB"].ToString().Trim() == "")
                {
                    ncm.CST = _FbDataReader["STRIB"].ToString();
                }
                else
                {
                    try { ncm.CST = _Parametros.Select("ARGUMENTO = 'STRIB' and SUBARGUM='" + _FbDataReader["STRIB"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { ncm.CST = _FbDataReader["STRIB"].ToString(); }
                }

                if (_FbDataReader["CDICM"].ToString().Trim() == "")
                {
                    ncm.aliquotaICMS = _FbDataReader["CDICM"].ToString();
                }
                else
                {
                    try { ncm.aliquotaICMS = _Parametros.Select("ARGUMENTO = 'CICMS' and SUBARGUM='" + _FbDataReader["CDICM"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { ncm.aliquotaICMS = _FbDataReader["CDICM"].ToString(); }
                }

                if (_FbDataReader["CDPIS"].ToString().Trim() == "")
                {
                    ncm.aliquotaCOFINS = _FbDataReader["CDPIS"].ToString();
                }
                else
                {
                    try { ncm.aliquotaPIS = _Parametros.Select("ARGUMENTO = 'CDPIS' and SUBARGUM='" + _FbDataReader["CDPIS"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { ncm.aliquotaCOFINS = _FbDataReader["CDPIS"].ToString(); }
                }

                if (_FbDataReader["CDCOFINS"].ToString().Trim() == "")
                {
                    ncm.aliquotaCOFINS = _FbDataReader["CDCOFINS"].ToString();
                }
                else
                {
                    try { ncm.aliquotaCOFINS = _Parametros.Select("ARGUMENTO = 'CDCOFINS' and SUBARGUM='" + _FbDataReader["CDCOFINS"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { ncm.aliquotaCOFINS = _FbDataReader["CDCOFINS"].ToString(); }
                }

                if (_FbDataReader["CDIPI"].ToString().Trim() == "")
                {
                    ncm.aliquotaIPI = _FbDataReader["CDIPI"].ToString();
                }
                else
                {
                    try { ncm.aliquotaIPI = _Parametros.Select("ARGUMENTO = 'CDIPI' AND SUBARGUM='" + _FbDataReader["CDIPI"] + "'")[0].ItemArray[2].ToString(); }
                    catch (IndexOutOfRangeException) { ncm.aliquotaIPI = _FbDataReader["CDIPI"].ToString(); }
                }

                switch (_FbDataReader["GRUPO"].ToString().ToLower())
                {
                    case "r":
                        ncm.grupoProduto = "Revenda";
                        break;
                    case "d":
                        ncm.grupoProduto = "Drogaria";
                        break;
                    default:
                        ncm.grupoProduto = _FbDataReader["GRUPO"].ToString();
                        break;
                }

                switch (_FbDataReader["INDCIP"].ToString().ToLower())
                {
                    case "n":
                        ncm.listaPisCofins = "Normal";
                        break;
                    case "s":
                        ncm.listaPisCofins = "Negativa";
                        break;
                    case "i":
                        ncm.listaPisCofins = "Isenta";
                        break;
                    default:
                        ncm.listaPisCofins = _FbDataReader["INDCIP"].ToString();
                        break;
                }

                listaNCM.Add(ncm);
            }
            _FbDataReader.Close();
            conexao.CloseConnection();
            return listaNCM;
        }


        public void AtualizarNCM(ClFiscal produto, string grupo)
        {
            _FbCommand = new FbCommand();
            _FbCommand.Connection = conexao.ObterConexao();

            _FbCommand.CommandText = "update FC03000" +
             " set STRIB = @STRIB," +
             " CDICM = @CDICM," +
             " CDSITPIS = @CDSITPIS," +
             " CDPIS = @CDPIS," +
             " CDSITCOFINS = @CDSITCOFINS," +
             " CDCOFINS = @CDCOFINS," +
             " CDSITIPI = @CDSITIPI," +
             " CDIPI = @CDIPI," +
             " INDCIP = @INDCIP" +
            " where CLFISC = @CLFISC AND GRUPO='" + grupo+ "'";

            //Se o codigo do NCM for vazio, excecução pula essa linha
            if (produto.NCM.Trim() == "") { return; }
            _FbCommand.Parameters.Add("@CLFISC", SqlDbType.VarChar).Value = produto.NCM;


            //Se o campo da planilha for vazio, irá gravar no banco como vazio. Caso não tenha o parametro cadastrado não terá nenhuma ação no update.
            try
            {
                if (produto.CST.Trim() == "") { _FbCommand.Parameters.Add("@STRIB", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@STRIB", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'STRIB' and PARAMETRO=" + produto.CST)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaICMS.Trim() == "") { _FbCommand.Parameters.Add("@CDICM", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDICM", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CICMS' and PARAMETRO='" + produto.aliquotaICMS + "'")[0].ItemArray[1].ToString().Trim(); }

            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.codigoPIS.Trim() == "") { _FbCommand.Parameters.Add("@CDSITPIS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDSITPIS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'SITTRIBPIS' and SUBARGUM=" + produto.codigoPIS)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaPIS.Trim() == "") { _FbCommand.Parameters.Add("@CDPIS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDPIS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CDPIS' and PARAMETRO='" + produto.aliquotaPIS + "'")[0].ItemArray[1].ToString().Trim(); }

            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.codigoCOFINS.Trim() == "") { _FbCommand.Parameters.Add("@CDSITCOFINS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDSITCOFINS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'SITTRIBCOFINS' and SUBARGUM=" + produto.codigoCOFINS)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaCOFINS.Trim() == "") { _FbCommand.Parameters.Add("@CDCOFINS", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDCOFINS", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CDCOFINS' and PARAMETRO='" + produto.aliquotaCOFINS + "'")[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.codigoIPI.Trim() == "") { _FbCommand.Parameters.Add("@CDSITIPI", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDSITIPI", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'SITTRIBIPI' and SUBARGUM=" + produto.codigoIPI)[0].ItemArray[1].ToString().Trim(); }
            }
            catch (IndexOutOfRangeException) { }

            try
            {
                if (produto.aliquotaIPI.Trim() == "") { _FbCommand.Parameters.Add("@CDIPI", SqlDbType.VarChar).Value = ""; }
                else { _FbCommand.Parameters.Add("@CDIPI", SqlDbType.VarChar).Value = _Parametros.Select("ARGUMENTO = 'CDIPI' and PARAMETRO='" + produto.aliquotaIPI + "'")[0].ItemArray[1].ToString().Trim(); }

            }
            catch (IndexOutOfRangeException) { }

            switch (produto.listaPisCofins.ToLower())
            {
                case "normal":
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "N";
                    break;
                case "negativa":
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "S";
                    break;
                case "isenta":
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = "I";
                    break;
                default:
                    _FbCommand.Parameters.Add("@INDCIP", SqlDbType.VarChar).Value = string.Empty.Trim();
                    break;
            }

            try
            {
                _FbCommand.ExecuteNonQuery();
            }
            catch (FbException) { }


            conexao.CloseConnection();
        }


        public void AlteraNCM(ClFiscal novoNCM, string grupo, string antigoNCM)
        {
            _FbCommand = new FbCommand();
            _FbCommand.Connection = conexao.ObterConexao();

            _FbCommand.CommandText = "update FC03000" +
             " set CLFISC = @CLFISC" +
            " where CLFISC ='" + antigoNCM + "' AND GRUPO " + grupo;

            if (novoNCM.NCM.Trim() == "") { return; }
            _FbCommand.Parameters.Add("@CLFISC", SqlDbType.VarChar).Value = novoNCM.NCM;

            try
            {
                _FbCommand.ExecuteNonQuery();
            }
            catch (FbException) { }


            conexao.CloseConnection();
        }
        //Carrega os Parametros do banco de dados.
        public DataTable Parametros()
        {
            try
            {
                _FbCommand = new FbCommand();
                _FbCommand.Connection = conexao.ObterConexao();

                _FbCommand.CommandText = "SELECT FC99999.ARGUMENTO, FC99999.SUBARGUM, FC99999.PARAMETRO FROM FC99999 WHERE FC99999.ARGUMENTO IN ('STRIB', 'SITTRIBIPI', 'SITTRIBPIS', 'SITTRIBCOFINS', 'CICMS', 'CDPIS', 'CDCOFINS', 'CDIPI')";

                _Parametros = new DataTable();
                _Adaptador = new FbDataAdapter(_FbCommand);
                _Adaptador.Fill(_Parametros);
                conexao.CloseConnection();
                return _Parametros;
            }
            catch (Exception)
            {
                MessageBox.Show("Base de dados não disponível", "Falha!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

        }
    }
}
