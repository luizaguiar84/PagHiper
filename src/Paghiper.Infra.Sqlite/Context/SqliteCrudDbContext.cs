﻿using System.Reflection;
using Microsoft.EntityFrameworkCore;
using PagHiper.Infra;
using PagHiper.Infra.Context;

namespace Paghiper.Infra.Sqlite.Context
{
	public class SqliteCrudDbContext : CrudDbContext
	{
		public SqliteCrudDbContext(DbContextOptions options) 
			: base(options) { }
	}
}
