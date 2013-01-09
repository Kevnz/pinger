using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;

namespace Pinger
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Get News Data");
				var url = "http://newsaggr.apphb.com/feed/json";
				try
				{
					var client = new RestClient("http://newsaggr.apphb.com");
					var request = new RestRequest("feed/json", Method.GET);

					var response = client.Execute(request);
					var content = response.Content;
					Console.WriteLine(content);
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
				}

				Thread.Sleep(90000);
			}


		}
	}
}
