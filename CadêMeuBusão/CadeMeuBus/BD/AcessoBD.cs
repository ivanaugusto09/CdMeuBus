using CadeMeuBus.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace CadeMeuBus.BD
{
    class AcessoBD
    {
        private SQLiteConnection conexao;

        public AcessoBD()
        {
            var dep = DependencyService.Get<I_LocalDados>();
            string arquivo = dep.getCaminho("bancodedados.sqlite");

            conexao = new SQLiteConnection(arquivo);

            conexao.CreateTable<Usuario>();
        }

        public IEnumerable<Usuario> GetUsers()
        {
            return (from u in conexao.Table<Usuario>()
                    select u).ToList();
        }


        public string Inserir(Usuario login)
        {
            var data = conexao.Table<Usuario>();
            var d1 = data.Where(x => x.usuario == login.usuario && x.senha == login.senha).FirstOrDefault();
            if (d1 == null)
            {
                conexao.Insert(login);

                return "Usuário Cadastrado Com Sucesso!";
            }
            else
            {
                return "Usuário Já Existente!";
            }
        }



        public bool LoginValidate(string use, string pwd)
        {
            var data = conexao.Table<Usuario>();
            var d1 = data.Where(x => x.usuario == use && x.senha == pwd).FirstOrDefault();
            if (d1 != null)
            {
                return true;
            }
            else
                return false;
        }

        public List<Usuario> Consultar()
        {
            return conexao.Table<Usuario>().ToList();
        }

    }
}
