using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren {
	internal class Podcast : Media {
		private string _creator;
		public Podcast(string inputTitle, string inputFilePath, string inputCreator, int inputDuration, int inputPublicationYear) : base(inputTitle, inputFilePath, inputDuration, inputPublicationYear) {
			_creator = inputCreator;




		}

		public override void Play() {
			Console.WriteLine("Nu spelas " + _creator);
		}

		public override void Stop() {
			Console.WriteLine("Nu pausas " + _creator);
		}
		public override void PrintMediaInfo() {
			Console.WriteLine("Din valda " + FilePath + " av " + _creator + " år " + PublicationYear + "och är " + Length + " minuter lång");
		}
	}
}

