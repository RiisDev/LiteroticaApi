using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;

namespace LiteroticaApi.AuthClientData
{
	internal static class CookieHelper
	{
		internal static List<Cookie> GetAllCookies(this CookieContainer cookieContainer)
		{
			List<Cookie> allCookies = [];

			Hashtable table = (Hashtable)cookieContainer
				.GetType()
				.InvokeMember(
					"m_domainTable",
					BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance,
					null,
					cookieContainer,
					[]
				);

			allCookies.AddRange(from object pathList in table.Values
				select (SortedList)pathList.GetType()
					.InvokeMember(
						"m_list", 
						BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance, 
						null, 
						pathList, 
						[]
					)
				into cookieList
				from CookieCollection col in cookieList.Values
				from Cookie cookie in col
				select cookie);

			return allCookies;
		}
	}
}
