using System;
using NUnit.Framework;
using Saigon.EntityAssigner.Tests.Entities;

namespace Saigon.EntityAssigner.Tests
{
	[TestFixture]
	public class EntityAssignerTest
	{
		[Test(Description="Sprawdzenie czy EntityAssigner przepisze tylko oznaczony atrybutem Propert")]
		public void EntityAssigner_Assign_Prop1Assigned()
		{
			E1 e1 = new E1 { Prop1 = "P1" };
			E1 e2 = new E1();
			
			e2.AssignFrom(e1);
			
			Assert.AreEqual("P1", e2.Prop1);
		}
	}
}
