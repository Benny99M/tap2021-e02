using NUnit.Framework;
using System;

namespace IsValidDnaSequence
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public static bool IsvalidDna()
        {

 
            var RandomDna = "AGCETAS";            
                string ShouldContain = "ACGT";
                foreach (char c in RandomDna)
                {
                    if (ShouldContain.Contains(c) == false)
                    {
                    return false;

                    }
                }
            if (RandomDna.Length > 999)
                return false;
           return true;
        }
        
        }
    }
