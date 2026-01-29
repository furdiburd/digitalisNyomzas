using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class IdovonalEsemeny
	{
		private DateTime esemenyDatum;
		private string esemenyLeiras;

		public IdovonalEsemeny(DateTime esemenyDatum, string esemenyLeiras)
		{
			this.esemenyDatum = esemenyDatum;
			this.esemenyLeiras = esemenyLeiras;
		}

		public DateTime EsemenyDatum { get => esemenyDatum; set => esemenyDatum = value; }
		public string EsemenyLeiras { get => esemenyLeiras; set => esemenyLeiras = value; }
	}
}
