using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaVendas.Uteis;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class VendedorModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage ="Informe o nome do vendedor")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do vendedor")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="O e-mail informado é invalido")]
        public string Email { get; set; }
        public string Senha { get; set; }


        public List<VendedorModel> ListaTodosVendedores()
        {
            List<VendedorModel> lista = new List<VendedorModel>();
            VendedorModel item;
            DAL objDAL = new DAL();
            string sql = "SELECT id, nome, email, senha from vendedor order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new VendedorModel
                {
                    Id = dt.Rows[i]["Id"].ToString(),
                    Nome = dt.Rows[i]["Nome"].ToString(),
                    Email = dt.Rows[i]["Email"].ToString(),
                    Senha = dt.Rows[i]["Senha"].ToString(),
                };
                lista.Add(item);
            }
            return lista;
        }

        public VendedorModel RetornarVendedor(int? id)
        {

            VendedorModel item;
            DAL objDAL = new DAL();
            string sql = $"SELECT id, nome, email, senha from vendedor where id= '{id}' order by nome asc";
            DataTable dt = objDAL.RetDataTable(sql);

           
                item = new VendedorModel
                {
                    Id = dt.Rows[0]["Id"].ToString(),
                    Nome = dt.Rows[0]["Nome"].ToString(),
                    Email = dt.Rows[0]["Email"].ToString(),
                    Senha = dt.Rows[0]["Senha"].ToString(),
                };
                 return item;
        }


        //insert ou update
        public void Gravar()
        {
            DAL objDAL = new DAL();
            string sql = string.Empty;

            if (Id != null)
            {
                sql = $"UPDATE VENDEDOR SET NOME = '{Nome}', EMAIL = '{Email}' WHERE ID = '{Id}'";
            }
            else
            {
                sql = $"INSERT INTO VENDEDOR(NOME, EMAIL, SENHA) VALUES('{Nome}','{Email}','123456')";

            }

            objDAL.ExecutarComandoSQL(sql);


        }
        public void Excluir(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"DELETE  FROM VENDEDOR WHERE ID = '{id}'";
            objDAL.ExecutarComandoSQL(sql);
        }
    }
}
