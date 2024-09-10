using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaspelaren {
	internal class Media {
		private string _title;
		private string _filepath;
		private int _duration;
		private int _publicationyear;
		
		

		public Media(string inputTitle, string inputFilePath, int inputDuration, int inputPublicationYear) {
			_title = inputTitle;
			_filepath = inputFilePath;
			_duration = inputDuration;
			_publicationyear = inputPublicationYear;
			


		}

		public int Length {
			get {
				return _duration;
			}
			set {
				if(value >= 0) {
					_duration = value;
				}
			}

		}

		public string FilePath {
			get {
				return _filepath;
			}
			set {
				if (value != "") {
					_filepath = value;
				}
			}
		}

		public string Title {
			get {
				return _title;
			}
			set {
				if(value != "") {
					_title = value;
				}
			}
		}

		public int PublicationYear {
			get {
				return _publicationyear;
			}
			set {
				if (value >= 1900 && value <= 2024) {
					_publicationyear = value;
				}
			}
		}
		
		public virtual void Play() {
			Console.WriteLine("Nu spelas jag");
		}

		public virtual void Stop() {
			Console.WriteLine("Nu pausas jag");
		}
		public virtual void PrintMediaInfo() {
			Console.WriteLine("Din valda " + _filepath + " skapades år "  + _publicationyear + " och är " + _duration);
		}
	}
}
