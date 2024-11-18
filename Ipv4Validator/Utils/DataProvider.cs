using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ipv4Validator.Utils
{
	public static class DataProvider
	{
		public static string[] GetIpSamples()
		{
			string[] samples = 
			[
				"192.168.0.1",
				"10.0.0.1",
				"172.16.0.1",
				"255.255.255.255",
				"0.0.0.0",
				"127.0.0.1",
				"1.2.3.4",
				"192.168.1.256",
				"192.168.01.1",
				"192.168.1.1.1",
				"192.168.1",
				"192.168.1.",
				".192.168.1.1",
				"192.168.1.1.",
				"192.168.256.1",
				"192.168.1.a",
				"192.168.1.1a",
				"300.168.1.1",
				"192..168.1.1",
				" 192.168.1.1 ",
				"192.168.1.1 ",
				" 192.168.1.1",
				"8.8.8.8",
				"169.254.0.1",
				"224.0.0.1",
				"255.255.255.0",
				"192.0.2.1",
				"::1",
				"0177.0.0.1",
				"0x8.0x8.0x8.0x8",
				"192.168.1.1e0",
				"192.168.1.1/24",
				"192.168.1",
				"1.1.1.01",
				"256.0.0.1",
				"192.168.0.0.1",
				"192.168.0,1",
				"192.168.0.-1",
				"192.168.0.+1",
				"192.168.000.001",
				"192.168. 1 . 1",
				"192.168.1.1\n",
				"192.168.1.1\t",
				"192.168.1.1\r",
				"500.400.300.200",
				"192.168.1.1:8080",
				"999.999.999.999",
				"192.168.1.1.",
				".192.168.1.1",
				"0xFF.0xFF.0xFF.0xFF",
				"255...255"
			];

			return samples;
		}

		public static string[] GetValidIpSamples()
		{
			string[] samples =
			[
				"192.168.0.1",
				"10.0.0.1",
				"172.16.0.1",
				"255.255.255.255",
				"0.0.0.0",
				"127.0.0.1",
				"1.2.3.4"
			];

			return samples;
		}

		public static string[] GetInvalidIpSamples()
		{
			string[] samples =
			[
				"192.168.1.256",
				"192.168.01.1",
				"192.168.1.1.1",
				"192.168.1",
				"192.168.1.",
				".192.168.1.1",
				"192.168.1.1.",
				"192.168.256.1",
				"192.168.1.a",
				"192.168.1.1a",
				"300.168.1.1",
				"192..168.1.1",
				" 192.168.1.1 ",
				"192.168.1.1 ",
				" 192.168.1.1",
				"192.168.1.1e0"
			];

			return samples;
		}


	}
}