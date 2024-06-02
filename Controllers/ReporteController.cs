using Microsoft.AspNetCore.Mvc;
using SeaCare.Data;
using SeaCare.DTOs;
using SeaCare.Models;

namespace SeaCare.Controllers
{
    public class ReporteController : Controller
    {
        private readonly DataContext _dataContext;

        public ReporteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EfetuarReporte(ReporteDTO request)
        {
            try
            {
                Usuario newUser = new Usuario
                {
                    Nome = request.Nome ?? ""
                };

                _dataContext.Usuarios.Add(newUser);
                _dataContext.SaveChanges();

                Localizacao newLocalizacao = new Localizacao
                {
                    UF = request.Uf,
                    Cidade = request.Cidade,
                    Locality = request.Localidade,
                };

                _dataContext.Localizacoes.Add(newLocalizacao);
                _dataContext.SaveChanges();

                Artefato newArtefato = new Artefato
                {
                    Nome = request.Artefato,
                    Descricao = request.Descricao
                };

                _dataContext.Artefatos.Add(newArtefato);
                _dataContext.SaveChanges();

                Reporte newReporte = new Reporte
                {
                    Usuario = newUser,
                    Localizacao = newLocalizacao,
                    Artefato = newArtefato,
                    ReporteData = DateTime.Now,
                };

                _dataContext.Reportes.Add(newReporte);
                _dataContext.SaveChanges();

            }
            catch (Exception ex)
            {
                TempData["Erro"] = "Ocorreu um erro ao processar o relatório: " + ex.Message;
                return RedirectToAction("Index", "Home");
            }

            TempData["Sucesso"] = "O relatório foi concluído com sucesso.";
            return RedirectToAction("Index", "Home");
        }
    }
}
