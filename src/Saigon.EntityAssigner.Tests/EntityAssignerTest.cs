using System;
using Xunit;
using Saigon.EntityAssigner.Tests.Entities;

namespace Saigon.EntityAssigner.Tests
{
	
	public class EntityAssignerTest
	{
		[Fact]
		public void EntityAssigner_Assign_E1Prop1Assigned()
		{
			E1 source = new E1 { Prop1 = "P1" };
			E1 target = new E1();
			
			target.AssignFrom(source);
			
			Assert.Equal("P1", target.Prop1);
		}

		[Fact]
		public void EntityAssigner_Assign_E2Prop1Assigned()
		{
			E1 source = new E1 { Prop1 = "P1" };
			E2 target = new E2();

			target.AssignFrom(source);

			Assert.Equal("P1", target.Prop1);
		}

		[Fact]
		public void EntityAssigner_Assign_E3Prop2Assigned()
		{
			E1 source = new E1 { Prop1 = "P1" };
			source.Prop1 = null;
			source.Prop2 = "P2";

			E3 target = new E3();

			target.AssignFrom(source);

			Assert.Equal("P2", target.Prop1);
		}

		[Fact]
		public void EntityAssigner_Assign_E4Prop1Assigned()
		{
			E4 source = new E4 { Prop2 = "P2" };
			E4 target = new E4();

			target.AssignFrom(source);

			Assert.Equal("P2", target.Prop1);
		}

		[Fact]
		public void EntityAssigner_Assign_E5Prop1ConvertedAssigned()
		{
			E5 source = new E5 { Prop2 = "2" };
			E5 target = new E5();

			target.AssignFrom(source);

			Assert.Equal(2, target.Prop1);
		}
	}
}
