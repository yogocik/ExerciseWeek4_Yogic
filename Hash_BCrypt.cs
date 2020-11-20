using System;

namespace HASHING 
{
	public class hash
	{
		public static string hashYourPass(string password,string salt)
		{
			return BCrypt.Net.BCrypt.HashPassword(password,salt);
		}
		public static bool verifyYourPass(string password, string hashedPass)
		{
			return BCrypt.Net.BCrypt.Verify(password,hashedPass);
		}
	}
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to BCrypt Hashing");
			Console.WriteLine("Write Username Below");
			string userName  = Console.ReadLine();
			Console.WriteLine("Write Password Below");
			string passWord = Console.ReadLine();
			Console.WriteLine("Write your salt-length-works");
			int saltLength = Convert.ToInt32(Console.ReadLine());
			string mySalt = BCrypt.Net.BCrypt.GenerateSalt(saltLength);
			Console.WriteLine("My Generated Salt: {0}", mySalt);
			string hashPass = hash.hashYourPass(passWord,mySalt);
			Console.WriteLine("Hash Password with salt: {0}", hashPass);
			bool Match = hash.verifyYourPass(passWord,hashPass);
			if(Match){
			  Console.WriteLine("Hash-Password Verification Success");
			}else{
			  Console.WriteLine("Hash-Password Verification Failed");
			}
		}
	}
	
}
