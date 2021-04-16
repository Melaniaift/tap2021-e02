namespace Sample
{
    public static class SampleExtension
    {
        public static bool MaxSize(this SampleClass sampleclass)
        {
            int lengthS = sampleclass.DnaSequence.Length;
            if (lengthS > 1000)
                return false;
            else
                return true;
        }
    }
}
