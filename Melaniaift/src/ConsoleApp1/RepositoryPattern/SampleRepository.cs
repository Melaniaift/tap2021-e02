using Sample;
using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    class SampleRepository : IRepositoryPattern {
        private List<SampleClass> _sampleList;
        public IEnumerable<SampleClass> GetAllSamples() {
            throw new NotImplementedException();
        }
    }
}
