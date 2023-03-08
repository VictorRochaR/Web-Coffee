using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;

namespace ATV3.Controllers
{
    public class HomeController : Controller
    {
        public static bool ss = false;
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FaleConosco()
        {
            return View();
        }

        public IActionResult Noticias()
        {
            Noticias DU = new Noticias();
            List<Noticia> Lista = DU.noticiass();
            return View(Lista);
        }

        public IActionResult Produtos()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        public IActionResult Adm()
        {
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                ss = false;
            }
            return View();
        }

        public ActionResult Form() {  
        return View();  
        }  

        [HttpPost]
        public IActionResult Form(string name,string email,string message){
             try {  
                if (ModelState.IsValid) {  
                var eu = new MailAddress("WebCoffeeAdm@gmail.com","ME");
                var password = "Password@12";
                var sub = name;
                var msg = "Cliente: " + name + ", com o email: " +email+ "\n" + message;
                var smtp = new SmtpClient {
                    Host = "smtp.gmail.com",
                        Port = 587,  
                        EnableSsl = true,  
                        DeliveryMethod = SmtpDeliveryMethod.Network,  
                        UseDefaultCredentials = false,  
                        Credentials = new NetworkCredential(eu.Address, password) 
                };
                using(var mess = new MailMessage(eu,eu){
                    Subject = sub,
                    Body = msg
                }) {
                    ViewBag.SuccessMsg = "Enviado com sucesso!";
                    smtp.Send(mess);
                }

            return View("FaleConosco");
            }  
            } catch (Exception) {  
             ViewBag.Error = "Algum erro ocorreu!";  
            }  
             return View("FaleConosco");
        }

        



        public IActionResult NoticiAdm()
        {
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{
            ss = true;
            Dados.Add.menu = 1;
            return View("Adm");}
        }
        public IActionResult NoticiApg()
        {
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{
            Dados.Add.menu = 4;
            return View("Adm");}
        }
        public IActionResult Produt()
        {
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                Dados.Add.menu = 0;
            }else{
            Dados.Add.menu = 2;}
            return View("Adm");
        }
        public IActionResult Servic()
        {
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                Dados.Add.menu = 0;
            }else{
            Dados.Add.menu = 3;}
            return View("Adm");
        }

        [HttpPost]
        public IActionResult MudaPreco(string pre1, string pre2, string pre3, string pre4, string pre5){
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{
            Dados.prr.MudaPreco(pre1, pre2, pre3, pre4, pre5);
            return View("Adm");}
        }
        [HttpPost]
        public IActionResult MudaPreco2(string pre1, string pre2, string pre3, string pre4, string pre5){
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{
            Dados.svc.MudaPreco(pre1, pre2, pre3, pre4, pre5);
            return View("Adm");}
        }

        [HttpPost]
        public IActionResult CriaNtc(string nome, string autor, string corpo){
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{
            Dados.ntc.PublicarNoticia(nome, autor, corpo);
            return View("Adm");}
        }

        [HttpPost]
        public IActionResult EliNtc(string nome){
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{
            Dados.ntc.EliminarNoticia(nome);
            return View("Adm");}
        }

        public IActionResult Saii(){
            if(HttpContext.Session.GetString("NomeUsuario") == null){
                return RedirectToAction("Adm");
            }else{

            ss = false;
            HttpContext.Session.Clear();
            return RedirectToAction("Index");}
        }
    

        [HttpPost]
        public IActionResult Senha(string senha)
        {
            Dados DU = new Dados();
            bool conf = DU.validaLogin(senha);
            if(conf == false){
            }else{
            HttpContext.Session.SetString("NomeUsuario","Adm");
            return RedirectToAction("NoticiAdm");
            }
            return RedirectToAction("Index");
        } 
    }
}
