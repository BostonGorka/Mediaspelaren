using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren {
	internal class Movie : Media {
		private string _director;
		public Movie(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear, string inputDirector) : base(inputTitle, inputFilePath, inputPublicationYear, inputDuration) {
			_director = inputDirector;



		}

		public override void Play() {
			Console.WriteLine("Nu spelas " + Title);
		}

		public override void Stop() {
			Console.WriteLine("Nu pausas " + Title);
		}
		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda " + FilePath + " av " + _director + " år " + PublicationYear + "och är " + Length + " minuter lång");
		}
	}
}
