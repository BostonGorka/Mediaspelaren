using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren {
	internal class Song : Media {
		private string _artist;
		public Song(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear, string inputArtist) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear) {
			_artist = inputArtist;



		}

		public override void Play() {
			Console.WriteLine("Nu spelas " + _artist);
		}

		public override void Stop() {
			Console.WriteLine("Nu pausas " + _artist);
		}
		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda " + FilePath + " av " + _artist + " år " + PublicationYear + "och är " + Length + " minuter lång");
		}


	}
}
