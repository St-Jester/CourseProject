using System;
using System.Collections.Generic;
using System.Text;

namespace RPGClassLibrary
{
    public class NameGenerator
    {
		public List<string> FirstPart { get; set; }
		public List<string> SecondPart { get; set; }

		public NameGenerator()
		{
			FirstPart = new List<string>();
			SecondPart = new List<string>();
			PopulateLists();
		}


		//FUTURE - ADD FROM FILE
		private void PopulateLists()
		{
			FirstPart.Add("malo");
			FirstPart.Add("zak");
			FirstPart.Add("abo");
			FirstPart.Add("wonk");
			FirstPart.Add("mor");
			FirstPart.Add("novo");
			FirstPart.Add("le");

			SecondPart.Add("ros");
			SecondPart.Add("ana");
			SecondPart.Add("miu");
			SecondPart.Add("ent");
			SecondPart.Add("aliep");
			SecondPart.Add("ner");
			SecondPart.Add("ran");
		}

		public string GenerateName()
		{
			Random r = new Random();
			string finalname = "";
			finalname = FirstPart[r.Next(FirstPart.Count - 1)];
			finalname+= SecondPart[r.Next(SecondPart.Count - 1)];
			return finalname;
		}
	}
}
