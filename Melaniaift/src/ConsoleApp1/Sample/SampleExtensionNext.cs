namespace Sample
{
    public static class SampleExtensionNext {
        public static bool CheckAllowedChars(this SampleClass sampleclass)
        {
            for (int i = 0; i < sampleclass.DnaSequence.Length; i++)
                if (sampleclass.DnaSequence[i] >= 'a' && sampleclass.DnaSequence[i] <= 'z' || sampleclass.DnaSequence[i] == 'B' || sampleclass.DnaSequence[i] >= 'D' && sampleclass.DnaSequence[i] <= 'S' || sampleclass.DnaSequence[i] >= 'U' && sampleclass.DnaSequence[i] <= 'Z')
                    return false;
            return true;
        }
    }
}
