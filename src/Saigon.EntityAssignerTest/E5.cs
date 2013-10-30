using System;
using Saigon.EntityAssigner;

namespace Saigon.EntityAssignerTest
{
	public class E5
	{
		[Assign(PropertyName = "Prop2", Converter = typeof(StringToIntConverter))]
		public int Prop1 { get; set; }
		public string Prop2 { get; set; }
	}
}
