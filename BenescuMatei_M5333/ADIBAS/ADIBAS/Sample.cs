using System;
using System.Collections.Generic;
using System.Text;

namespace ADIBAS
{
    class Sample
    {
     

       public Sample(Guid id, string DNA, DateTime Date)
        {
            Id = id;
            DnaSequence = DNA;
            AnalysisTime = Date;

        }
        public Guid Id { get; private set; }
        public string DnaSequence { get; private set; }
        public DateTime AnalysisTime { get; private set; }

    }
}
