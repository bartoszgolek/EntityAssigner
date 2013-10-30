using System;
using Saigon.EntityAssigner;

namespace Saigon.EntityAssignerTest
{
	public class E2
	{
		[Assign(SourceType = typeof(E1))]
		public string Prop1 { get; set; }
		
		public string Prop2 { get; set; }
	}
}
