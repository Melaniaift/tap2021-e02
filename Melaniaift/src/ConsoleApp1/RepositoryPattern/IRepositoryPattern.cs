using Sample;
using System.Collections.Generic;

namespace RepositoryPattern
{
    public interface IRepositoryPattern {
        IEnumerable<SampleClass> GetAllSamples();
    }
}
