using System;
using Saigon.EntityAssigner;
using Saigon.EntityAssigner.Tests.Converters;

namespace Saigon.EntityAssigner.Tests.Entities
{
	public class E5
	{
		[Assign(PropertyName = "Prop2", Converter = typeof(StringToIntConverter))]
		public int Prop1 { get; set; }
		public string Prop2 { get; set; }
	}
}
