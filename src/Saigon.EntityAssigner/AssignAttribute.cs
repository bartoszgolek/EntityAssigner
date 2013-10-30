using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saigon.EntityAssigner
{
	/// <summary>
	/// Attribute to map properties in class.
	/// </summary>
	public class AssignAttribute : System.Attribute
	{
		/// <summary>
		/// Type of source class.
		/// </summary>
		/// <remarks>
		/// If source object is not of defined type, attribute is not used.
		/// </remarks>
		public Type SourceType { get; set; }
		/// <summary>
		/// Name of source property for assign.
		/// </summary>
		/// <remarks>
		/// If <c>null</c> property with same name will be used.
		/// </remarks>
		public String PropertyName { get; set; }
		/// <summary>
		/// Type of converter class
		/// </summary>
		/// <remarks>
		/// If <c>null</c> target properties should be assignable without explicit cast from source.
		/// </remarks>
		public Type Converter { get; set; }
	}
}
