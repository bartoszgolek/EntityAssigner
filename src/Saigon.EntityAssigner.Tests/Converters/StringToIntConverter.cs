﻿using Saigon.EntityAssigner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saigon.EntityAssigner.Tests.Converters
{
	public class StringToIntConverter : IAssignConverter
	{
		public object Convert(object value)
		{
			return int.Parse((string)value);
		}
	}
}
