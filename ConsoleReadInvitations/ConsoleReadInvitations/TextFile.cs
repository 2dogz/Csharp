using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleReadInvitations
{
    class TextFile
    {
        public string InFile { get; set; }

        public List<string> LinesRead { get; set; }

        public TextFile(string inFile = "") 
        {
            if (inFile.Length > 0)
            {
                this.InFile = inFile;
                ReadFile();
            }
        }

	    // Read in a file line-by-line, and store it all in a List.
        private void ReadFile() 
        {
	        List<string> list = new List<string>();

	        using (StreamReader reader = new StreamReader(this.InFile))
	        {
	            string line;
	            while ((line = reader.ReadLine()) != null)
		            list.Add(line); // Add to list.
	        }

            this.LinesRead = list;
        }
    }
}
