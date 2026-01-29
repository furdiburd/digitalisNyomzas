using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Tanu
	{
		// "Person objektum"
		private string vallomasSzovege;
		private DateTime vallomasDatuma;

		public Tanu(string vallomasSzovege, DateTime vallomasDatuma)
		{
			this.vallomasSzovege = vallomasSzovege;
			this.vallomasDatuma = vallomasDatuma;
		}

		public string VallomasSzovege { get => vallomasSzovege; set => vallomasSzovege = value; }
		public DateTime VallomasDatuma { get => vallomasDatuma; set => vallomasDatuma = value; }
	}
}
