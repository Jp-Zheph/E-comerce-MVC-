using System;
using System.Security.Cryptography;
using System.Text;

namespace FN.Store.Domain.Helpers
{
	public static class StringHelpers
	{

		public static string Encrypt(this string senha)
		{
			var salt = "|716A9420-492F-4A83-857F-4A6D4E3A3E6720CF5156 - 298B - 4389 - 9891 - 775B10724A00";

			var arrayBites = Encoding.UTF8.GetBytes(senha + salt);

			byte[] hashBytes;
			using (var sha = SHA512.Create())
			{
				hashBytes = sha.ComputeHash(arrayBites);
			}

			return Convert.ToBase64String(hashBytes);
		}



	}
}
