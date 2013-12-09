﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace NER_SPLRL
{
    class LocationGazetteerPER : IGazetteer
    {

        private const string TAG_START = "<[LOCATION:";
        private const string TAG_END = "]>";

        
        public LocationGazetteerPER():base()
        {
            
        }

        
        public override string TagLine(string line)
        {
            // copy of input parameter (line)
            string copyLine = line;

            // match only whole words
            foreach (string country in ItemList)
            {
                MatchCollection matches = Regex.Matches(line, String.Format(@"\b{0}\b", country));

                // replace all occurences of found location
                if (matches.Count != 0)
                    copyLine = copyLine.Replace(String.Format(@"\b{0}\b", country),String.Format(@"\b{0}\b",  TAG_START + country + TAG_END));
            }

            return copyLine;
        }

    }
}
