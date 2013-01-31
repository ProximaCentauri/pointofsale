/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 1/19/2013
 * Time: 9:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using MySql.Data;

using System.Collections.Generic;
using System.Linq;
using NJournals.Common.DataEntities;
using System.Configuration;
namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of NHibernateHelper.
	/// </summary>
	public class NHibernateHelper
	{
		private static ISessionFactory _sessionFactory;
        
		private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            try
            {            	
            	_sessionFactory = Fluently.Configure()
                    .Database(MySQLConfiguration.Standard                    
                    .ConnectionString(ConfigurationManager.AppSettings["mysqlConnString"])
                    .Driver<NHibernate.Driver.MySqlDataDriver>()
                    .ShowSql()
                    )
                	.Mappings(m => m.FluentMappings
            		          .AddFromAssemblyOf<ItemCategoryDataEntity>()
            		          .AddFromAssemblyOf<ItemGenericDataEntity>()
            		          .AddFromAssemblyOf<ItemDataEntity>())
                    .ExposeConfiguration(c => c.Properties.Add("hbm2ddl.keywords", "none"))
                    .BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
      
	}
}
