using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Usuarios
    {

        public List<Usuario> ListarPorEstado(bool estado)
        {
            List<Usuario> lista = new List<Usuario>();
            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand cmd = new SqlCommand("sp_ListarUsuariosPorEstado", oConexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Estado", estado);
                    oConexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                idUsuario = Convert.ToInt32(dr["idUsuario"]),
                                nombreUsuario = dr["nombreUsuario"].ToString(),
                                contrasena = dr["contrasena"].ToString(),
                                estado = Convert.ToBoolean(dr["estado"]),
                                oPersona = new Persona()
                                {
                                    idPersona = dr["idPersona"] != DBNull.Value ? Convert.ToInt32(dr["idPersona"]) : 0,
                                    nombreCompleto = dr["nombreCompleto"]?.ToString(),
                                    nroDocumento = dr["nroDocumento"]?.ToString(),
                                    email = dr["email"]?.ToString(),
                                    telefono = dr["telefono"]?.ToString(),
                                    direccion = dr["direccion"]?.ToString(),
                                    estado = dr["estadoPersona"] != DBNull.Value && Convert.ToBoolean(dr["estadoPersona"])
                                }
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lista = new List<Usuario>();
                Console.WriteLine("Error: " + ex.Message);
            }
            return lista;
        }

    }
}
