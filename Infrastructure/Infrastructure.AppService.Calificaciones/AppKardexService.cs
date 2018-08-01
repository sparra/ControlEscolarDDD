using Domain.Kardex;
using System;

namespace Infrastructure.AppService.Calificaciones
{
    public class AppKardexService
    {
        private TemporalDomainService _historiaAService;
        public AppKardexService(TemporalDomainService historia)
        {
            this._historiaAService = historia;
        }

        public string SaludoEstudiante()
        {
            var estudiante = _historiaAService.GetNombreEstudiante();
            return $"Hola {estudiante.ToUpper()}, saluditos";
        }
    }
}
