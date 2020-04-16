using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using SistemaVendas.Uteis;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;

namespace SistemaVendas.Models
{
    public class LoginModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        [Required(ErrorMessage ="Digite seu email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O email informado é invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; }


        public bool ValidarLogin()
        {
            string sql = $"SELECT ID, NOME FROM VENDEDOR WHERE EMAIL=@email AND SENHA=@senha";
            MySqlCommand Command = new MySqlCommand();
            Command.CommandText = sql;
            Command.Parameters.AddWithValue("@email", Email);
            Command.Parameters.AddWithValue("@senha", Senha);

            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(Command);
            if (dt.Rows.Count == 1)
            {
                Id = dt.Rows[0]["ID"].ToString();
                Nome = dt.Rows[0]["NOME"].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
    
    }
}
