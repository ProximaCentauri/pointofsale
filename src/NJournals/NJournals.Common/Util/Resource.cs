/*
 * Created by SharpDevelop.
 * User: mc185104
 * Date: 1/22/2013
 * Time: 1:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
namespace NJournals.Common.Util
{
	/// <summary>
	/// Description of Resource.
	/// </summary>
	public class Resource
	{		
		public static void setImage(Control control, string imagePath){
			if(File.Exists(imagePath)){
				control.BackgroundImage = Image.FromFile(imagePath);
				control.BackgroundImageLayout  = ImageLayout.Center;
			}
		}
		
		public static void setIcon(Form form, string imagePath){
			if(File.Exists(imagePath)){
				form.Icon = new System.Drawing.Icon(imagePath);
			}
		}
	}
}
