/*
 * Created by SharpDevelop.
 * User: TEJ
 * Date: 2/2/2013
 * Time: 12:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Linq;
using FluentNHibernate.Mapping;
using NHibernate.Linq;
using NJournals.Common.DataEntities;

namespace NJournals.Common.DataMappers
{
	/// <summary>
	/// Description of RefillTransactionTypeDataMap.
	/// </summary>
	public class RefillTransactionTypeDataMap : ClassMap<RefillTransactionTypeDataEntity>
	{
		public RefillTransactionTypeDataMap()
		{
			Id(x => x.TransactionTypeID);
			Map(x => x.Name);
			Table("RefillTransactionType");
		}
	}
}
