using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace SmartInventory.Client
{
	static class Tools
	{
		public static void OpenModule<T>(this TabbedView tabbedView, string caption) where T : UserControl, new()
		{
			var document = tabbedView.Documents.FirstOrDefault(x => x.Control is T);
			if (document != null)
			{
				tabbedView.Controller.Activate(document);
			}
			else
			{
				T control = new() { Name = typeof(T).Name};
				var newdoc = tabbedView.AddDocument(control);
				newdoc.Caption = caption;
				tabbedView.Controller.Activate(newdoc);

			}
		}

		public class HttpHelper()
		{
			private static readonly HttpClient _httpClient = new()
			{
				BaseAddress = new Uri("http://localhost:5016"),
				Timeout = TimeSpan.FromSeconds(30)
			};

			public static string AccessToken { get; set; }

			private static void EnsureHeader()
			{
				_httpClient.DefaultRequestHeaders.Authorization =
					!string.IsNullOrEmpty(AccessToken)
					? new AuthenticationHeaderValue("Bearer", AccessToken)
					: null;
			}

			public static async Task<T> GetAsync<T>(string url)
			{
				EnsureHeader();
				return await _httpClient.GetFromJsonAsync<T>(url);
			}

			public static async Task<HttpResponseMessage> PostAsync<T>(string url, T data)
			{
				EnsureHeader();
				return await _httpClient.PostAsJsonAsync(url, data);
			}

			public static async Task<HttpResponseMessage> PutAsync<T>(string url, T data)
			{
				EnsureHeader();
				return await _httpClient.PutAsJsonAsync(url, data);
			}

			public static async Task<HttpResponseMessage> DeleteAsync(string url)
			{
				EnsureHeader();
				return await _httpClient.DeleteAsync(url);
			}
		}
	
	}

	
}
