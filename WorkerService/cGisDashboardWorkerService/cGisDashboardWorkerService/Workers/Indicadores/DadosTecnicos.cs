using cGisDashboardWorkerService.Helpers.Debug;
using cGisDashboardWorkerService.Helpers.Utils;
using cGisDashboardWorkerService.Models.DTOs.Indicadores.DadosTecnicos;
using cGisDashboardWorkerService.Workers.Indicadores.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace cGisDashboardWorkerService.Workers.Indicadores
{
    public class DadosTecnicos : IDadosTecnicos
    {
        private readonly string origem = "Server=35.184.1.215;Database=cGIS;Uid=cgisos;Pwd=Celtica2015;Pooling=False;";

        //produção
        //private readonly string destino = "Server=130.211.178.58;Database=cGISDashboard;Uid=cgis;Pwd=Celtica2014;";
        
        //testes
        private readonly string destino = "Server=35.184.1.215;Database=cGISDashboard;Uid=cgisos;Pwd=Celtica2015;Pooling=False;";

        public async Task<DebugInfoResult> ProcessaDadosTecnicos()
        {
            DebugInfoResult result = new DebugInfoResult();

            string strCommand = "";

            SqlConnection conOrigem = new SqlConnection(origem);
            SqlConnection conDestino = new SqlConnection(destino);

            result.Dados = "hello world!";

            try
            {
                conOrigem.Open();


                SqlCommand cmd;

                List<ExtensaoPorDiametro> extensaoPorDiametro = GetExtensaoPorDiametro(conOrigem);


                result.Dados = extensaoPorDiametro[1].Extensao.ToString();





                /*
                 * EXTENSAO POR MATERIAL
                 * 
                 */


                List<ExtensaoPorMaterial> extensaoPorMaterial = GetExtensaoPorMaterial(conOrigem);

                //user.Username = extensaoPorMaterial[5].Material;


                /*
                 * EXTENSAO POR TIPO
                 */

                List<ExtensaoPorTipo> extensaoPorTipo = GetExtensaoPorTipo(conOrigem);
                //user.Username = extensaoPorTipo[0].Extensao.ToString();

                /*
                 * CONSUMO MEDIO CLIENTE
                 */

                List<ConsumoMedioCliente> consumoMedioCliente = GetConsumosMedioCliente(conOrigem);

                /*
                 * TipoEconomia
                 * ta bugando - ficar por ultimo
                 */

                List<TipoEconomia> tipoEconomia = GetTiposEconomia(conOrigem);

                // user.Username ="Economia Domiciliar" + tipoEconomia[0].Domiciliar.ToString();

                decimal consumoDomiciliar = GetConsumoMedioDomiciliar(conOrigem);

                //result.Dados = "consumo domiciliar:" + consumoDomiciliar.ToString();

                conDestino.Open();
                //cmd = new SqlCommand($"INSERT INTO  Teste(Inteiro, Texto) VALUES({nosEsgoto[0].Quantidade}, '{nosEsgoto[0].Tipo}')", connDestino);

                strCommand = $"INSERT INTO IndicadoresDadosTecnicos(ExtensaoRDAPorDiametroNull," +
                                            $"ExtensaoRDAPorDiametro20, " +
                                            $"ExtensaoRDAPorDiametro25, " +
                                            $"ExtensaoRDAPorDiametro32," +
                                            $"ExtensaoRDAPorDiametro40, " +
                                            $"ExtensaoRDAPorDiametro50, " +
                                            $"ExtensaoRDAPorDiametro60, " +
                                            $"ExtensaoRDAPorDiametro75," +
                                            $"ExtensaoPorMaterialCA, " +
                                            $"ExtensaoPorMaterialDEFO, " +
                                            $"ExtensaoPorMaterialFA, " +
                                            $"ExtensaoPorMaterialFC, " +
                                            $"ExtensaoPorMaterialFG, " +
                                            $"ExtensaoPorMaterialPVC, " +
                                            $"ExtensaoPorTipoAAB, " +
                                            $"ExtensaoPorTipoAAT, " +
                                            $"ExtensaoPorTipoALI," +
                                            $"ExtensaoPorTipoDSC," +
                                            $"ExtensaoPorTipoRDA," +
                                            $"ConsumoMedioClienteA," +
                                            $"ConsumoMedioClienteD," +
                                            $"ConsumoMedioClienteP," +
                                            $"ConsumoMedioClienteC" +
                                            /*
                                            $"EconomiaDomiciliar, " +
                                            $"EconomiaComercial, " +
                                            $"EconomiaIndustrial, " +
                                            $"EconomiaPublica*/  ") " +
                                       $"values({cGISFormat.CommaToDot(extensaoPorDiametro[0].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[1].Extensao)}," +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[2].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[3].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[4].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[5].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[6].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorDiametro[7].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorMaterial[0].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorMaterial[1].Extensao)}," +
                                              $"{cGISFormat.CommaToDot(extensaoPorMaterial[2].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorMaterial[3].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorMaterial[4].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorMaterial[5].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorTipo[0].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorTipo[1].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorTipo[2].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorTipo[3].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(extensaoPorTipo[4].Extensao)}, " +
                                              $"{cGISFormat.CommaToDot(consumoMedioCliente[0].ConsumoMedio)}, " +
                                              $"{cGISFormat.CommaToDot(consumoMedioCliente[1].ConsumoMedio)}, " +
                                              $"{cGISFormat.CommaToDot(consumoMedioCliente[2].ConsumoMedio)}, " +
                                              $"{cGISFormat.CommaToDot(consumoMedioCliente[3].ConsumoMedio)} " +
                                              /*
                                              $"{tipoEconomia[0].Domiciliar}," +
                                              $"{tipoEconomia[0].Comercial}, " +
                                              $"{tipoEconomia[0].Industrial}, " +
                                              $"{tipoEconomia[0].Publica}*/  ");";

                cmd = new SqlCommand(strCommand, conDestino);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                result.Dados = ex.Message;
            }
            finally
            {



                if (conOrigem != null)
                {
                    conOrigem.Close();


                }

                if (conDestino != null)
                {
                    conDestino.Close();
                }
            }

            return result;
        }


        public List<ExtensaoPorDiametro> GetExtensaoPorDiametro(SqlConnection conOrigem)
        {
            List<ExtensaoPorDiametro> list = new List<ExtensaoPorDiametro>();

            string strCommand = "SELECT SUM(Extensao)/1000 as Extensao, Diametro From TrechosRedeAgua GROUP BY Diametro order by Diametro;";
            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);

            SqlDataReader dataReader = null;

            try
            {

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    ExtensaoPorDiametro item = new ExtensaoPorDiametro()
                    {
                        Extensao = (double)dataReader["Extensao"],
                        //Diametro = (int)rdr["Diametro"] == null? 0:(int)rdr["Diametro"]
                    };


                    list.Add(item);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                dataReader.Close();
            }

            return list;
        }

        public List<ExtensaoPorMaterial> GetExtensaoPorMaterial(SqlConnection conOrigem)
        {
            List<ExtensaoPorMaterial> list = new List<ExtensaoPorMaterial>();

            string strCommand = "SELECT SUM(Extensao)/1000 as Extensao, Material From TrechosRedeAgua GROUP BY Material order by Material;";
            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);

            SqlDataReader dataReader = null;
            try
            {



                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ExtensaoPorMaterial item = new ExtensaoPorMaterial()
                    {
                        Extensao = (double)dataReader["Extensao"],
                        Material = (string)dataReader["Material"]
                    };

                    list.Add(item);
                }

                dataReader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return list;
        }

        public List<ExtensaoPorTipo> GetExtensaoPorTipo(SqlConnection conOrigem)
        {
            List<ExtensaoPorTipo> list = new List<ExtensaoPorTipo>();

            string strCommand = "SELECT SUM(Extensao)/1000 as Extensao, Tipo From TrechosRedeAgua GROUP BY Tipo order by Tipo;";
            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);

            SqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ExtensaoPorTipo item = new ExtensaoPorTipo()
                    {
                        Extensao = (double)dataReader["Extensao"],
                        Tipo = (string)dataReader["Tipo"]
                    };

                    list.Add(item);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return list;
        }

        public List<ConsumoMedioCliente> GetConsumosMedioCliente(SqlConnection conOrigem)
        {
            List<ConsumoMedioCliente> consumoMedioCliente = new List<ConsumoMedioCliente>();

            string strCommand = "Select AVG(ConsumoMedio) as ConsumoMedio, Situacao from Cliente group by Situacao;";
            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);

            SqlDataReader dataReader = null;

            try
            {

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ConsumoMedioCliente item = new ConsumoMedioCliente()
                    {
                        ConsumoMedio = (decimal)dataReader["ConsumoMedio"],
                        Situacao = (String)dataReader["Situacao"]
                    };

                    consumoMedioCliente.Add(item);
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return consumoMedioCliente;
        }
        public List<TipoEconomia> GetTiposEconomia(SqlConnection conOrigem)
        {
            List<TipoEconomia> tipoEconomia = new List<TipoEconomia>();
            string strCommand = "select Sum(EconomiaDomiciliar) as EconomiaDomiciliar, Sum(EconomiaComercial) as EconomiaComercial, Sum(EconomiaIndustrial) as EconomiaIndustrial, Sum(EconomiaPublica) as EconomiaPublica from Cliente;";

            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);
            SqlDataReader dataReader = null;

            try
            {

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    TipoEconomia item = new TipoEconomia()
                    {
                        Domiciliar = (int)dataReader["EconomiaDomiciliar"],
                        Comercial = (int)dataReader["EconomiaComercial"],
                        Industrial = (int)dataReader["EconomiaIndustrial"],
                        Publica = (int)dataReader["EconomiaPublica"]
                    };

                    tipoEconomia.Add(item);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }
            return tipoEconomia;

        }

        public decimal GetConsumoMedioDomiciliar(SqlConnection conOrigem)
        {
            decimal result;
            List<decimal> list = new List<decimal>();
            string strCommand = "select AVG(ConsumoMedio) as consumo From Cliente where EconomiaDomiciliar > 0;";

            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);
            SqlDataReader dataReader = null;

            try
            {
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    result = (decimal)dataReader["consumo"];
                    list.Add(result);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (dataReader != null)
                {
                    dataReader.Close();
                }
            }

            return list[0];
        }
    }
}
