using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Html;

namespace ATV3
{
    public class Servicos
    {
        public static string pre1 = "1,50";
        public static string pre2 = "2,00";
        public static string pre3 = "3,50";
        public static string pre4 = "5,00";

        public static string pre5 = "0,75";


         public static HtmlString Html(){
            var des = new StringBuilder();
                des.Append("<h3>O preço dos nossos computadores é:</h3><p>até 1 hora --------------------- R$" +pre1+"</br>de 1 hora até 2 horas -------- R$" +pre2+"</br>de 2 horas até 4 horas ------- R$" +pre3+"</br>de 4 horas até 6 horas ------- R$" +pre4+"</br>a partir de 6 horas ----------- R$" +pre5+"(cada hora adicional)</br></p>");
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