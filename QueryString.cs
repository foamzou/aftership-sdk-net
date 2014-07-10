﻿using System;
using System.Web;
using System.Collections.Generic;
using Aftership.Enums;

namespace Aftership
{

	/// <summary>
	/// Creates a url friendly String
	/// </summary>
	public class QueryString
	{
		private String query = "";

		//careful, this constructor creates the first element with &
		public QueryString(){}

		public QueryString(String name, String value) {
			encode(name, value);
		}
			

		public void add(String name, List<String> list) {
			query += "&";
			String test = String.Join (",", list);

			String value =String.Join(",",list);
			encode(name, value);
		}

		public void add(String name, String value) {
			query += "&";
			encode(name, value);
		}

		private void encode(String name, String value) {
			query +=  HttpUtility.UrlEncode(name);
			query += "=";
			query +=  HttpUtility.UrlEncode(value);
		}

		public String getQuery() {
			return query;
		}

		public String ToString() {
			return getQuery();
		}
	}
}

