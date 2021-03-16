using System;
using System.IO;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;

namespace UnityDebug
{
	public static class Log
	{
		public static bool Debug { get; set; }

		static string FormatMessage(string message)
		{
			var time = DateTime.Now.ToString ("HH:mm:ss.ffffff");
			return $"{time}: {message}\n";
		}

		public static void DebugWrite(string message)
		{
			if (Debug)
				Write (message);
		}

		public static void LogError(string message, Exception ex)
		{
			Write(message + (ex != null ? Environment.NewLine + ex : string.Empty));
		}

		public static void Write(string message)
		{
			var formattedMessage = FormatMessage (message);
			Console.Error.Write(formattedMessage);
		}
	}
}

