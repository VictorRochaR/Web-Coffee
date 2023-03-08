using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;

namespace ATV3
{
    public class Produtos
    {
        public Produtos(){

        }
         public static string pre1 = "1,50";
        public static string pre2 = "2,00";
        public static string pre3 = "3,00";
        public static string pre4 = "2,50";

        public static string pre5 = "5,00";


         public static HtmlString Html(){
            var des = new StringBuilder();
                des.Append("<h3>Nosso menu da cafeteria é:</h3><p>Café ............... R$"+pre1+"</br>Água .............. R$"+pre2+"</br>Chá mate ........ R$"+pre3+"</br>Pão de queijo .. R$"+pre4+"</br>Pão na chapa ... R$"+pre5+"</br></p>");
            return new HtmlString(des.ToString());
         }

         public void MudaPreco(string a, string b, string c, string d, string e){
                pre1 = a;
                pre2 = b;
                pre3 = c;
                pre4 = d;
                pre5 = e;
        }
    }
}