using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saigon.EntityAssigner
{
	/// <summary>
	/// Extension for object to easily assigning from source.
	/// </summary>
	public static class EntityAssignerExtensions
	{
		/// <summary>
		/// Assign mapped properties from source object.
		/// </summary>
		/// <param name="target">Target object</param>
		/// <param name="source">Source object</param>
		public static void AssignFrom(this object target, object source)
		{
			new EntityAssigner(source, target).Assign();
		}

		internal static IEnumerable<Type> GetInheritanceHierarchy(this Type type)
		{
			for (var current = type; current != null; current = current.BaseType)
				yield return current;
		}
	}
}
