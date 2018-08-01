using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Domain.Curso;
using Domain.Kardex;

namespace Infrastructure.AppService.Calificaciones
{
    public class CalificacionesModule : Module
    {
        //IOC Inversion of Control Container Load
        protected override void Load(ContainerBuilder builder)
        {
            var historiaAcademicaDomainService = new HistoriaAcademicaSimpleDomainService();

            //Domain Services
            builder.RegisterInstance<TemporalDomainService>(historiaAcademicaDomainService)
                .AsSelf();

            builder.RegisterInstance<CursoDomainService>(new CursoDomainService())
                .AsSelf();

            builder.RegisterInstance<HistoriaAcademica>(new HistoriaAcademica())
                .AsSelf();
            builder.RegisterInstance<AppKardexService>(new AppKardexService(historiaAcademicaDomainService))
                .AsSelf();
        }
    }
}
