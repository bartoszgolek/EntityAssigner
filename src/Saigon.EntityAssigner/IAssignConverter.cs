using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saigon.EntityAssigner
{
	/// <summary>
	/// Interface for converting value types when assigning values from source to destination property
	/// </summary>
	/// <remarks>
	/// Implementation of this class have to be parameter less
	/// </remarks>
	public interface IAssignConverter
	{
		/// <summary>
		/// Convert source value.
		/// </summary>
		/// <param name="value">Source property value</param>
		/// <returns>Destination property value</returns>
		object Convert(object value);
	}
}
