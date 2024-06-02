using Microsoft.AspNetCore.Mvc;
using SeaCare.Data;

namespace SeaCare.Controllers
{
    public class EstatisticaController : Controller
    {
        private readonly DataContext _dataContext;

        public EstatisticaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index() 
        {
            var ufs = GetUfsReportadas();
            var reportes = ReportesPorUf(ufs);
            var artefatos = GetArtefatosReportados();
            var quantidadeArtefatos = MaioresArtefatos(artefatos);
            var totalCasos = TotalCasos();

            ViewBag.ArtefatosReportados = artefatos;
            ViewBag.QuantidadeArtefatos = quantidadeArtefatos;
            ViewBag.UfsReportadas = ufs;
            ViewBag.ReportesPorUf = reportes;
            ViewBag.TotalCasos = totalCasos;

            return View();
        }

        private List<string> GetUfsReportadas()
        {
            var ufs = _dataContext.Reportes
                      .GroupBy(r => r.Localizacao.UF)
                      .OrderByDescending(g => g.Count())
                      .Select(g => g.Key)
                      .Take(5)
                      .ToList();

            return ufs;
        }

        private List<int> ReportesPorUf(List<string> ufs)
        {
            var reportes = new List<int>();

            foreach (var uf in ufs)
            {
                var count = _dataContext.Reportes.Count(r => r.Localizacao.UF == uf);
                reportes.Add(count);
            }

            return reportes;
        }

        private List<string> GetArtefatosReportados()
        {
            var artefatos = _dataContext.Reportes
                      .GroupBy(r => r.Artefato.Nome)
                      .OrderByDescending(g => g.Count())
                      .Take(5)
                      .Select(g => g.Key)
                      .ToList();

            return artefatos;
        }

        private List<int> MaioresArtefatos(List<string> artefatos)
        {
            var casosArtefatos = _dataContext.Reportes
                             .Where(r => artefatos.Contains(r.Artefato.Nome))
                             .GroupBy(r => r.Artefato.Nome)
                             .Select(g => new { Artefato = g.Key, QuantidadeCasos = g.Count() })
                             .OrderByDescending(g => g.QuantidadeCasos)
                             .Take(5)
                             .Select(g => g.QuantidadeCasos)
                             .ToList();

            return casosArtefatos;
        }

        private int TotalCasos()
        {
            var total = _dataContext.Reportes.Count();

            return total;
        }
    }
}
