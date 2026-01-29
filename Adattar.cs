using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisNyomzas
{
	internal class Adattar
	{
		private List<Felhasznalo> felhasznalok;
		private List<Ugy> ugyek;
		private List<Szemely> szemelyek;
		private List<Bizonyitek> bizonyitekok;

		public Adattar(List<Felhasznalo> felhasznalok, List<Ugy> ugyek, List<Szemely> szemelyek, List<Bizonyitek> bizonyitekok)
		{
			this.felhasznalok = felhasznalok;
			this.ugyek = ugyek;
			this.szemelyek = szemelyek;
			this.bizonyitekok = bizonyitekok;
		}

		internal List<Felhasznalo> Felhasznalok { get => felhasznalok; set => felhasznalok = value; }
		internal List<Ugy> Ugyek { get => ugyek; set => ugyek = value; }
		internal List<Szemely> Szemelyek { get => szemelyek; set => szemelyek = value; }
		internal List<Bizonyitek> Bizonyitekok { get => bizonyitekok; set => bizonyitekok = value; }
	}
}
