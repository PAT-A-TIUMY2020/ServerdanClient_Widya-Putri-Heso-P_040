using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_040;

namespace Client_Widya_Putri_Heso_P_040
{
	static class Program
	{

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]

		static void Main()
		{
			BasicHttpBinding bind = new BasicHttpBinding();
			ChannelFactory<IMatematika> objChannel = new
		   ChannelFactory<IMatematika>(bind, "http://localhost:1907");
			IMatematika obj = objChannel.CreateChannel();
			double hasilTambah = obj.Tambah(1, 2);
			Console.WriteLine("1 + 2 = " + hasilTambah);
			double hasilKurang = obj.Kurang(3, 2);
			Console.WriteLine("3 - 2 = " + hasilKurang);
			double hasilKali = obj.Kali(2, 2);
			Console.WriteLine("2 x 2 = " + hasilKali);
			double hasilBagi = obj.Bagi(2, 2);
			Console.WriteLine("2 / 2 = " + hasilBagi);
			Console.ReadLine();
			Koordinat objk = new Koordinat();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
