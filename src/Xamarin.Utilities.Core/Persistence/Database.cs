namespace Xamarin.Utilities.Core
{
	using System;
	using SQLite.Net;

	public class Database
	{
		private static readonly Lazy<Database> instance = new Lazy<Database>(() => new Database());

		private Database ()
		{
		}

		public static Database Instance 
		{
			get 
			{
				return instance.Value;
			}	
		}

		public SQLiteConnection SqlConnection { get; private set; }
	}
}
