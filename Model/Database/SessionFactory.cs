using NHibernate;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using NHibernate.AdoNet;

namespace Mensalidades.Model.Database
{
    public static class SessionFactory
    {
        private static ISessionFactory sessionFactory;
        public static ISessionFactory AcessoSessionFactory { get { return sessionFactory; } }

        public static void Inicializar(ConnectionDB connection)
        {
            var mapper = new ModelMapper();

            mapper.AddMappings(Assembly.GetExecutingAssembly().GetExportedTypes());

            HbmMapping mapDominio = mapper.CompileMappingForAllExplicitlyAddedEntities();
            mapDominio.autoimport = false;

            var config = new Configuration();
            config.DataBaseIntegration(x =>
            {
                x.Driver<NpgsqlDriver>();
                x.ConnectionString = connection.strConn;

                x.Dialect<PostgreSQL82Dialect>();
                x.Batcher<NonBatchingBatcherFactory>();
                x.BatchSize = short.MaxValue;

                x.LogFormattedSql = true;
                x.LogSqlInConsole = false;
            });

            config.AddMapping(mapDominio);

            sessionFactory = config.BuildSessionFactory();
        }
    }
}
