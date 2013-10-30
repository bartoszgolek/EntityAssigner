﻿using System;
using Saigon.EntityAssigner;

namespace Saigon.EntityAssignerTest
{
	public class E3
	{
		[Assign(SourceType = typeof(E1), PropertyName = "Prop2")]
		public string Prop1 { get; set; }
		
		public string Prop2 { get; set; }
	}
}
