using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TuevSued.V1.IT.FE.CoreBase.Json
{
	public class JsonRawValue
	{
		public JsonRawValue(string value)
		{
			Value = value;
		}

		public string Value
		{
			get;
			set;
		}
	}
}