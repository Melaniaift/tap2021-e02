using System;


namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass IsP = new SampleClass();
            IsP.DnaSequence = "GCGTGTTAGTATGTTGACCCGTGTATTACGCATGCGGGTAGATCATGTGGGTAGA";
            IsP.MaxSize();
            Console.WriteLine(IsP.CheckAllowedChars());

            SampleClass IsNot = new SampleClass();
            IsNot.DnaSequence = "LBAGCGTGTTAGTATGTTGACCCGTGTATTACGCATGCGGGTAGATCATGTGGGTAGA";
            Console.WriteLine(IsNot.MaxSize());

        }
    }
}
