using cGisDashBoard.Helpers.Data;
using cGisDashBoard.Helpers.Ultis;
using cGisDashBoard.Models.DTOs.IndicadoresDadosTecnicos;
using cGisDashBoard.Models.DTOs.IndicadoresPerda;
using cGisDashBoard.Models.Entities;
using cGisDashBoard.Workers.Interfaces;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.IO;

namespace cGisDashBoard.Workers
{
    public class IndicadoresWorkerService: IIndicadoresWorkerService
    {

        private readonly string origem = "Server=35.184.1.215;Database=cGIS;Uid=cgisos;Pwd=Celtica2015;Pooling=False;";
       

        //private readonly string destino = "Server=130.211.178.58;Database=cGISDashboard;Uid=cgis;Pwd=Celtica2014;";
        private readonly string destino = "Server=35.184.1.215;Database=cGISDashboard;Uid=cgisos;Pwd=Celtica2015;Pooling=False;";

        public async Task<Usuario> ProcessaIndicadores()
        {
            Usuario user = new Usuario();

            List<NosEsgoto> nosEsgoto= new List<NosEsgoto>();

            

            string strCommand = "";

            SqlConnection conn = new SqlConnection(origem);
            SqlConnection connDestino = new SqlConnection(destino);

            SqlDataReader rdr = null;
            SqlDataReader dataReader = null;

            try
            {
                conn.Open();

               
                SqlCommand cmd;

                List<ExtensaoPorDiametro> extensaoPorDiametro = GetExtensaoPorDiametro(conn);

   
                user.Username = extensaoPorDiametro[1].Extensao.ToString();
            




                /*
                 * EXTENSAO POR MATERIAL
                 * 
                 */


                List<ExtensaoPorMaterial> extensaoPorMaterial = GetExtensaoPorMaterial(conn);

                //user.Username = extensaoPorMaterial[5].Material;


                /*
                 * EXTENSAO POR TIPO
                 */

                List<ExtensaoPorTipo> extensaoPorTipo = GetExtensaoPorTipo(conn);
                //user.Username = extensaoPorTipo[0].Extensao.ToString();

                /*
                 * CONSUMO MEDIO CLIENTE
                 */

                List<ConsumoMedioCliente> consumoMedioCliente = GetConsumosMedioCliente(conn);

                //if(consumoMedioCliente.Count > 0) //tem que ver esta zica ai pq antes tava trazendo ne
                //    user.Username = consumoMedioCliente[0].ConsumoMedio.ToString();

                /*
                 * TipoEconomia
                 * ta bugando - ficar por ultimo
                 */

               List<TipoEconomia> tipoEconomia = GetTiposEconomia(conn, user);

                // user.Username ="Economia Domiciliar" + tipoEconomia[0].Domiciliar.ToString();

                connDestino.Open();
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
                                       $"values({Format.CommaToDot(extensaoPorDiametro[0].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorDiametro[1].Extensao)}," +
                                              $"{Format.CommaToDot(extensaoPorDiametro[2].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorDiametro[3].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorDiametro[4].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorDiametro[5].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorDiametro[6].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorDiametro[7].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorMaterial[0].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorMaterial[1].Extensao)}," +
                                              $"{Format.CommaToDot(extensaoPorMaterial[2].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorMaterial[3].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorMaterial[4].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorMaterial[5].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorTipo[0].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorTipo[1].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorTipo[2].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorTipo[3].Extensao)}, " +
                                              $"{Format.CommaToDot(extensaoPorTipo[4].Extensao)}, " +
                                              $"{Format.CommaToDot(consumoMedioCliente[0].ConsumoMedio)}, " +
                                              $"{Format.CommaToDot(consumoMedioCliente[1].ConsumoMedio)}, " +
                                              $"{Format.CommaToDot(consumoMedioCliente[2].ConsumoMedio)}, " +
                                              $"{Format.CommaToDot(consumoMedioCliente[3].ConsumoMedio)} " +
                                              /*
                                              $"{tipoEconomia[0].Domiciliar}," +
                                              $"{tipoEconomia[0].Comercial}, " +
                                              $"{tipoEconomia[0].Industrial}, " +
                                              $"{tipoEconomia[0].Publica}*/  ");";

                cmd = new SqlCommand(strCommand, connDestino);


                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {

            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if(dataReader != null)
                {
                    dataReader.Close();
                }

                if (conn != null)
                {
                    conn.Close();


                }

                if (connDestino != null)
                {
                    connDestino.Close();
                }
            }
            /*
            using (SqlConnection connection = new SqlConnection(""))
            {
                SqlCommand command = new SqlCommand("SELECT * from IndicadoresPerdas", connection);

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            */

            

            return user;
            
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
            catch(Exception ex)
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
            catch(Exception ex)
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
            catch(Exception ex)
            {

            }
            finally
            {
                if(dataReader != null)
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
            catch(Exception ex)
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
        public List<TipoEconomia> GetTiposEconomia(SqlConnection conOrigem, Usuario user)
        {
            List<TipoEconomia> tipoEconomia = new List<TipoEconomia>();
            string strCommand = "select Sum(EconomiaDomiciliar) as EconomiaDomiciliar, Sum(EconomiaComercial) as EconomiaComercial, Sum(EconomiaIndustrial) as EconomiaIndustrial, Sum(EconomiaPublica) as EconomiaPublica from Cliente;";

            SqlCommand cmd = new SqlCommand(strCommand, conOrigem);
            SqlDataReader dataReader = null;

            try
            {
                
                dataReader = cmd.ExecuteReader();

                while(dataReader.Read())
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
            catch(Exception ex)
            {
                // user.Username = ex.Message;
                
                StreamWriter sw = new StreamWriter("C:\\logs/cGisDashboard/cgis-dashboard.txt");
                
                sw.WriteLine(ex.Message);

                sw.Close();
            }
            finally
            {
                if(dataReader !=null)
                {
                    dataReader.Close();
                }
            }
            return tipoEconomia;

        }
        private static void CreateCommand(string queryString,
    string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
