using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ipv4Validator.Helpers
{
	public static class DataValidate
	{
		public static void ValidateIp(string ipAdress)
		{
			if (IsDotsValid(ipAdress))
			{
				Console.WriteLine($"{ipAdress} é válido");
			}
			else
			{
				Console.WriteLine($"{ipAdress} é inválido");
			}
		}
		
		private static bool IsDotsValid(string ipAddress)
		{
						
			var isValid = ipAddress.Count(c => c == '.').Equals(3);
			
			if (isValid) return IsOctetsLengthValid(ipAddress.Split('.'));
			
			return false;
		}
		
		
		private static bool IsOctetsLengthValid(string[] octets)
		{
			
			var isValid = octets.All(octet => octet.Length > 0 && octet.Length < 4);
			
			if (isValid) return IsOctetsContentsValid(octets);
			
			return false;
		}
		
		private static bool IsOctetsContentsValid(string[] octets)
		{
						
			var isValid = octets.SelectMany(o => o.ToArray()).All(e => int.TryParse(e.ToString(), out _));
			
			if (isValid) return IsOctetStartValid(octets);
			
			return false;
		}
		
		private static bool IsOctetStartValid(string[] octets)
		{
						
			var isValid = octets.Where(o => o.Length > 1).Count(e => e.StartsWith("0")).Equals(0);
			
			if (isValid) return IsOctetRangeValid(octets);
			
			
			return false;
		}
		
		private static bool IsOctetRangeValid(string[] octets)
		{
			
			var isValid = octets.All(o => byte.TryParse(o, out _));
			
			if (isValid) return true;
			
			return false;
		}
		
		
	}
}
