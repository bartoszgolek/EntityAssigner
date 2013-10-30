using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Saigon.EntityAssigner
{
	/// <summary>
	/// Assign mapped properties from source to target object.
	/// </summary>
	public class EntityAssigner
	{
		/// <summary>
		/// Initializes a new instance of the EntityAssigner class.
		/// </summary>
		/// <param name="target">Target object</param>
		/// <param name="source">Source object</param>
		public EntityAssigner(object source, object target)
		{
			this.source = source;
			this.target = target;

			sourceType = source.GetType();
			targetType = target.GetType();
		}

		/// <summary>
		/// Assigns properties from source to terget object.
		/// </summary>
		public void Assign()
		{
			foreach (PropertyInfo targetProperty in targetType.GetProperties())
			{
				SetCurrentTargetProperty(targetProperty);
				GetProperAttribute();
				AssignIfPossible();
			}
		}

		private void AssignIfPossible()
		{
			if (!IsAssignPossible())
				return;

			DoAssign();
		}

		private void DoAssign()
		{
			GetCurrentSourceProperty();
			GetCurrentSourceValue();
			GetCurrentConverter();
			ConvertSourceValue();
			SetTargetPropertyValue();
		}

		private void GetCurrentConverter()
		{
			if (currentAttribute.Converter != null)
				currentConverter = (IAssignConverter)Activator.CreateInstance(currentAttribute.Converter);
		}

		private void SetTargetPropertyValue()
		{
			currentTargetProperty.SetValue(target, currentConvertedSourceValue);
		}

		private void ConvertSourceValue()
		{
			currentConvertedSourceValue
				= currentAttribute.Converter != null
					? currentConverter.Convert(currentSourceValue)
					: currentSourceValue;
		}

		private void GetCurrentSourceProperty()
		{
			currentSourcePropertyName = currentAttribute.PropertyName ?? currentTargetProperty.Name;
			currentSourceProperty = sourceType.GetProperty(currentSourcePropertyName);
		}

		private void GetCurrentSourceValue()
		{
			currentSourceValue = currentSourceProperty.GetValue(source);
		}

		private bool IsAssignPossible()
		{
			return currentAttribute != null;
		}

		private void GetProperAttribute()
		{
			foreach (Type t in sourceType.GetInheritanceHierarchy())
			{
				currentAttribute = currentTargetProperty
							.GetCustomAttributes(typeof(AssignAttribute), true)
							.Cast<AssignAttribute>()
							.SingleOrDefault(attr => (attr.SourceType ?? targetType) == t);

				if (currentAttribute != null)
					return;
			}
		}

		private void SetCurrentTargetProperty(PropertyInfo targetProperty)
		{
			currentTargetProperty = targetProperty;
		}

		private object source;
		private object target;

		private Type sourceType;
		private Type targetType;

		private PropertyInfo currentTargetProperty;
		private AssignAttribute currentAttribute;

		private string currentSourcePropertyName;
		private PropertyInfo currentSourceProperty;

		private IAssignConverter currentConverter;

		private object currentSourceValue;
		private object currentConvertedSourceValue;
	}
}
