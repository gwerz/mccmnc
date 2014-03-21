using System;
using System.Collections;
using com.IMSI.util;

namespace MccMncTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			echo(MccMnc.isoCountryCode(460));//China
			echo(MccMnc.carrier(460, 1));//  China Unicom
			echo(MccMnc.carrier(460, 5));//China Telecom
			echo(MccMnc.carrier(460, 0));//China Mobile GSM
			Console.ReadKey ();
		}

		public static void echo(Object msg){
			Console.WriteLine (msg);
		}
	}
}
