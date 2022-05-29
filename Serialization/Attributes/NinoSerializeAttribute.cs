﻿using System;
namespace Nino.Serialization.Attributes
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false)]
	public class NinoSerializeAttribute : Attribute
	{
		/// <summary>
        /// A struct or class to be serialized and deserialized
        /// 一个结构体或一个类型的会被序列化以及反序列化
        /// </summary>
		public NinoSerializeAttribute()
		{

		}
	}
}

