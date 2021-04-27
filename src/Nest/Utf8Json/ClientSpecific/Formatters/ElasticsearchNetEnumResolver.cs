/*
 * Licensed to Elasticsearch B.V. under one or more contributor
 * license agreements. See the NOTICE file distributed with
 * this work for additional information regarding copyright
 * ownership. Elasticsearch B.V. licenses this file to you under
 * the Apache License, Version 2.0 (the "License"); you may
 * not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *    http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Reflection;
using Elasticsearch.Net;

namespace Nest.Utf8Json
{
	internal sealed class ElasticsearchNetEnumResolver : IJsonFormatterResolver
	{
		public static readonly IJsonFormatterResolver Instance = new ElasticsearchNetEnumResolver();

		private ElasticsearchNetEnumResolver() { }

		public IJsonFormatter<T> GetFormatter<T>() => FormatterCache<T>.Formatter;

		private static class FormatterCache<T>
		{
			public static readonly IJsonFormatter<T> Formatter;

			static FormatterCache()
			{
				var type = typeof(T);

				if (ReflectionExtensions.IsNullable(type))
				{
					// build underlying type and use wrapped formatter.
					type = type.GenericTypeArguments[0];
					if (!type.IsEnum) return;

					var innerFormatter = Instance.GetFormatterDynamic(type);
					if (innerFormatter == null) return;

					Formatter = (IJsonFormatter<T>)Activator.CreateInstance(typeof(StaticNullableFormatter<>).MakeGenericType(type), innerFormatter);
				}
				else if (type.IsEnum)
				{
					var stringEnumAttribute = typeof(T).GetCustomAttribute<StringEnumAttribute>();
					Formatter = stringEnumAttribute != null
						? new EnumFormatter<T>(true)
						: new EnumFormatter<T>(false);
				}
			}
		}
	}
}