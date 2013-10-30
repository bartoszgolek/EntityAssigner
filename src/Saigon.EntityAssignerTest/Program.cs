using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saigon.EntityAssigner;

namespace Saigon.EntityAssignerTest
{
	class Program
	{
		static void Main(string[] args)
		{
			E1 source = new E1 { Prop1 = "P1" };

			E1 target = new E1();
			target.AssignFrom(source);

			E2 target2 = new E2();
			target2.AssignFrom(source);

			source.Prop1 = null;
			source.Prop2 = "p2";
			E3 target3 = new E3();
			target3.AssignFrom(source);


			E4 source4 = new E4 { Prop2 = "P2" };
			E4 target4 = new E4();
			target4.AssignFrom(source4);

			E5 source5 = new E5 { Prop2 = "2" };
			E5 target5 = new E5();
			target5.AssignFrom(source5);
		}
	}
}
