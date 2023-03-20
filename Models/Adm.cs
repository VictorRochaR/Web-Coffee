using System.Text;
using ATV3.Controllers;
using Microsoft.AspNetCore.Html;

namespace ATV3
{
    public class Adm
    {
        public Adm(){

        }
        public int menu = 1;



        public HtmlString Padrao(){
            var des = new StringBuilder();
                if (HomeController.ss){
                    des.Append("<br/><nav><a href='../Home/NoticiAdm'>Noticias</a> | <a href='../Home/NoticiApg'>Apagar noticias</a> | <a href='../Home/Produt'>Produtos</a> | <a href='../Home/Servic'>Servicos</a> | <a href='../Home/Saii'>Sair</a></nav>");
                    if(menu == 1){
                        des.Append("<div class='form-group'><form method='Post' action='CriaNtc'><label for='nome'>Nome:</label><input type='text' class='form-control' name='nome'><label for='autor'>Autor:</label><input type='text' class='form-control' name='autor'><label for='corpo'>Corpo:</label><input type='text' class='form-control' name='corpo'><input type='submit' class='btn btn-primary' value='Enviar'></form>");
                    } else if(menu == 2){
                        des.Append("<div class='form-group'><h4>Mudar os preços dos Produtos</h4><br/><form method='Post' action='MudaPreco'><p>Os preços devem ser colocados assim: XX,xx(com a vírgula e sem o R$)</p><br/><label for='pre1'>Preço 1</label><input type='text' class='form-control' name='pre1'><br/><label for='pre2'>Preço 2</label> <input type='text' class='form-control' name='pre2'><br/><label for='pre3'>Preço 3</label><input type='text' class='form-control' name='pre3'><br/><label for='pre4'>Preço 4</label> <input type='text' class='form-control' name='pre4'><br/><label for='pre5'>Preço 5</label><input type='text' class='form-control' name='pre5'><br/><input type='submit' class='btn btn-primary' value='Enviar'></form></div>");
                    }
                    else if(menu == 3){
                        des.Append("<div class='form-group'><h4>Mudar os preços dos Serviços</h4><br/><form method='Post' action='MudaPreco2'><p>Os preços devem ser colocados assim: XX,xx(com a vírgula e sem o R$)</p><br/><label for='pre1'>Preço 1</label><input type='text' class='form-control' name='pre1'><br/><label for='pre2'>Preço 2</label> <input type='text' class='form-control' name='pre2'><br/><label for='pre3'>Preço 3</label><input type='text' class='form-control' name='pre3'><br/><label for='pre4'>Preço 4</label> <input type='text' class='form-control' name='pre4'><br/><label for='pre5'>Preço 5</label><input type='text' class='form-control' name='pre5'><br/><input type='submit' class='btn btn-primary' value='Enviar'></form></div>");
                    } else if(menu == 4){
                        des.Append("<div class='form-group'><h4>Qual o nome da notícia que você quer apagar?</h4>");
                        des.Append("<form method='post' action='EliNtc'><input type='text' class='form-control' name='nome'><input type='submit' class='btn btn-primary' value='Enviar'></form></div>");
                    }
                   
                }else{
                des.Append("<h4>Coloque a senha:</h4> <br/>");
                des.Append("<form method='Post' class='form-group' action='/Home/Senha'><label for='senha'>Senha:</label><input type=text class='form-control' name='senha'> <br/><input type='submit' class='btn btn-primary' value='Entrar' /></form>");
                }
            return new HtmlString(des.ToString());
        }
    }
}