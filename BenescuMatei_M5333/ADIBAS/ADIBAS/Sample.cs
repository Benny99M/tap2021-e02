using System;
using System.Collections.Generic;
using System.Text;

namespace ADIBAS
{
    class Sample
    {
        Guid Id;
        string DnaSequence;
        DateTime AnalysisTime;
        protected Sample(Guid Id, string DnaSequence, DateTime AnalysisTime) : this(Id, DnaSequence, AnalysisTime)
        {

        }
        public Guid Id { get; private set; }
        public string DnaSequence { get; private set; }
        public DateTime AnalysisTime { get; private set; }

    }
}
