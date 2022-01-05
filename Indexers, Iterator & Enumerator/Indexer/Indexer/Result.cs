using System;

namespace Indexer
{
    public class Result
    {
        string FirstName { get; set; }
        private string LastName { get; set; }

        public string FullName {get { return $"{LastName} {FirstName}"; } }
        
        private int [] Score { get; set; }

        public int this[int i]
        {
            get
            {
                if (i > Score.Length)
                {
                    return 0;
                }
                else
                {
                    return Score[i];
                }
            }

            set
            {
                if (i < Score.Length && i >= 0)
                {
                    Score[i] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("The Index is not valid given");
                }
            }
            
        }

        public Result(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Score = new int[5];
        }
        
    }
}