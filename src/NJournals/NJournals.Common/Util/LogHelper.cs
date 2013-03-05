/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 8/13/2012
 * Time: 9:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of LogHelper.
	/// </summary>
	public class LogHelper
	{

		public static void Log(string data, LogType type, bool writeToConsole)
		{
			
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NJournals\\logs";
			DirectoryInfo di = new DirectoryInfo(path);
			if (!di.Exists) {
				di.Create();
			}
	
			if (writeToConsole) {
				Console.WriteLine(data);
			}
	
			using (StreamWriter sw = new StreamWriter(path + "\\NJournals" + DateTime.Now.ToString("MM-dd-yy") + ".log", true)) {		
					
				sw.WriteLine("[" + type.ToString() + "] " + data);
				
				/*if (type != LogType.INFO && 
					type != LogType.WARNING &&
					type != LogType.ERR){
					sw.WriteLine("[" + type.ToString() + "] " + data);
				} else {
					sw.WriteLine(data);
				}*/
			}
		}
	}
	
	public enum LogType
	{
		INFO = 1,
		WARNING = 2,
		ERROR = 3
	}
}
