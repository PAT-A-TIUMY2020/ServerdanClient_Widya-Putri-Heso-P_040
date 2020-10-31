using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ServiceMtk_P1_040
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	
	public interface IMatematika
	{
		
		/* output->*/
		int Tambah(int a, int b); //method
		
		int Kurang(int a, int b); //input
		
		int Kali(int a, int b);
	
		int Bagi(int a, int b);
		
		Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class
	}

	
	public class Koordinat
	{
		private int _x, _y; //atribut
		//membuka koordinat, x,y
		public int X //properties
		{
			get { return _x; }
			set { _x = value; }
		}
		
		public int Y //properties
		{
			get { return _y; }
			set { _y = value; }
		}
	}
}
