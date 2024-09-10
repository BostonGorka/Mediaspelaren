using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren {
	internal class Program {
		static void Main(string[] args) {
			List<Media> media = new List<Media>() {
				new Movie("Minioner", "jfjf", 2000, 21, "jaua"),
				new Movie("Minioner1", "jajf", 2004, 20, "jaukda"),
				new Movie("Minifjfner1", "jaaf", 2000, 80, "jajgkda"),
				new Song("sång", "kfkf", 1990, 40, "dnc"),
				new Song("slng", "kjfkf", 1980, 40, "djfc"),
				new Song("slanng", "kjfkf", 1970, 30, "dnnfj"),
				new Podcast("kihfjkf", "nhf", "jojf", 1940 ,50),
				new Podcast("kifjjff", "nhf", "jjff", 1940 ,40),
				new Podcast("kijgf", "nhf", "jajf", 1960 ,80)
			};
			for(int i = 0; i < media.Count; i++) {
				media[i].PrintMediaInfo();
			}
		}
	}
}
