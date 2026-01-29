using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Gyanusitott
	{
		// "person objektum"
		private int gyanusitottsagi_szint;
		private string statusz;

		public Gyanusitott(int gyanusitottsagi_szint, string statusz)
		{
			this.gyanusitottsagi_szint = gyanusitottsagi_szint;
			this.statusz = statusz;
		}

		public int Gyanusitottsagi_szint { get => gyanusitottsagi_szint; set => gyanusitottsagi_szint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
	}
}
