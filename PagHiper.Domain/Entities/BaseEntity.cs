﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PagHiper.Domain.Entities
{
	public abstract class BaseEntity
	{
		[Key]
		public Guid Id { get; set; }
	}
}
