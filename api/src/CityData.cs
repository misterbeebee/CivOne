// CivOne
//
// To the extent possible under law, the person who associated CC0 with
// CivOne has waived all copyright and related or neighboring rights
// to CivOne.
//
// You should have received a copy of the CC0 legalcode along with this
// work. If not, see <http://creativecommons.org/publicdomain/zero/1.0/>.

namespace CivOne
{
	public struct CityData
	{
		public byte Id;
		public byte NameId;
		public byte Status;
		public byte[] Buildings;
		public byte X, Y;
		public byte ActualSize;
		public byte CurrentProduction;
		public byte Owner;
		public ushort Food, Shields;
		public byte[] ResourceTiles;
		public byte[] FortifiedUnits;
	}
}