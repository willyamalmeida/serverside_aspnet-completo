using Microsoft.Extensions.Logging;
using serverside_servico.Dtos;
using serverside_servico.Interfaces.Servicos;

namespace serverside_aspnet.Controllers
{
    public class DepartamentoController : ControllerComCodigoNumerico<DtoDepartamento>
    {
        public DepartamentoController(ILogger<DepartamentoController> logger, IServicoDeDepartamento servico)
            : base(logger, servico)
        {
        }
    }
}
