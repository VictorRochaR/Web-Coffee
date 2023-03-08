using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;
using MySqlConnector;

namespace ATV3
{
    public class Noticias
    {
        
        public Noticias(){

        }
        private const string DadosConex = "Server=MYSQL8002.site4now.net;Database=db_a88e1f_webcoff;Uid=a88e1f_webcoff;Pwd=Mmonitorp#12;";
        MySqlConnection Conex  = new MySqlConnection(DadosConex);
        public void PublicarNoticia(string nome, string autor, string corpo){
            Conex.Open();

            String Query ="INSERT INTO Noticias(nome, autor, corpo) VALUES(@Nome, @Autor, @Corpo)";
            MySqlCommand comando = new MySqlCommand(Query, Conex); 

            comando.Parameters.AddWithValue("@Nome",nome);
            comando.Parameters.AddWithValue("@Autor",autor);
            comando.Parameters.AddWithValue("@Corpo",corpo);

            comando.ExecuteNonQuery();

            Conex.Close();

        }

        public void EliminarNoticia(string nome){
            Conex.Open();

            String Query ="DELETE FROM Noticias WHERE nome = @Nome";
            MySqlCommand comando = new MySqlCommand(Query, Conex);
            Console.WriteLine(nome);
            
            comando.Parameters.AddWithValue("@Nome",nome);
            comando.ExecuteNonQuery();
 
            Conex.Close();
        }

        public List<Noticia> noticiass(){
            Conex.Open();

            List<Noticia> ListaInterna = new List<Noticia>();
                String Query = "SELECT * FROM Noticias";
                MySqlCommand comando = new MySqlCommand(Query, Conex);
                MySqlDataReader reader = comando.ExecuteReader();

            while(reader.Read()){
                Noticia Noticia = new Noticia();
                 if(!reader.IsDBNull(reader.GetOrdinal("nome"))){
                    Noticia.nome = reader.GetString("nome");
                    }
                     if(!reader.IsDBNull(reader.GetOrdinal("autor"))){
                    Noticia.autor = reader.GetString("autor");
                    }

                     if(!reader.IsDBNull(reader.GetOrdinal("corpo"))){
                    Noticia.corpo = reader.GetString("corpo");
                    }


                    ListaInterna.Add(Noticia);
            }
            Conex.Close();

        return ListaInterna;
        }

        //***public string Ntce(){
           /// var des = new StringBuilder();
           // for(int i = 0; i < Nts.Count; i++){
              //  des.Append("<h6>Nº "+ i+"</h6>");
             //   des.Append(Nts[i].NNoticia());
           //     
         //   }
          //  return des.ToString();
       // }
       /// public static HtmlString Ntcs(){
        //    var des = new StringBuilder();
      //      for(int i = 0; i < Nts.Count; i++){
         ///       des.Append(Nts[i].NNoticia());
      ///          
   ///         }
///
          //  return new HtmlString(des.ToString());
        //}

    }
}