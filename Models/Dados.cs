using System.Collections.Generic;
using System;
using System.Data;
using MySqlConnector;

namespace ATV3
{
    public class Dados
    {
        public static Adm Add = new Adm();
        public static Produtos prr = new Produtos();
        public static Servicos svc = new Servicos();
        public static Noticias ntc = new Noticias();

            private const string DadosConex = "Server=MYSQL8002.site4now.net;Database=db_a88e1f_webcoff;Uid=a88e1f_webcoff;Pwd=Mmonitorp#12;";
        public bool validaLogin(string senha){
            MySqlConnection Conex  = new MySqlConnection(DadosConex);
            Conex.Open();

            String Query = "SELECT * FROM Usuario WHERE  Senha=@Senha";
            MySqlCommand comando = new MySqlCommand(Query, Conex); 
            comando.Parameters.AddWithValue("@Senha", senha);

            MySqlDataReader reader = comando.ExecuteReader();

            bool trr = false;
            if(reader.Read()){
                if(reader.GetString("senha")==senha)
                trr = true;

            }
            
            return trr;
        }
    }
}