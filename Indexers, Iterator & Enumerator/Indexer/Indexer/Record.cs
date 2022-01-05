using System;
using System.Collections.Generic;
using System.Globalization;

namespace Indexer
{
    public class Record
    {
        private string name { get; set; }
        private List<string> nameList { get; set; }
        
        public string this[int i]
        {
            
            
            get
            {
                if (i > nameList.Count)
                {
                    return "null";
                }
                else
                {
                    return nameList[i];
                }
                

            }
            set
            {
                foreach (char item in nameList[i])
                {
                    if (!char.IsLetter(item))
                    {
                        nameList[i] = value;
                        nameList.Add(value);
                        Console.WriteLine(nameList);
                        
                    }
                    else
                    {
                        throw new FormatException("Name contains characters");
                    }
                }
            }
            
            
        }

       

        
        




    }
}