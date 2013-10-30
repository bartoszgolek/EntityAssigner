using System;
using Saigon.EntityAssigner;

namespace Saigon.EntityAssignerTest
{
	public class E4
	{
		[Assign(PropertyName = "Prop2")]
		public string Prop1 { get; set; }
		public string Prop2 { get; set; }
	}
}
