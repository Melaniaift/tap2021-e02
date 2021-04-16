using NUnit.Framework;
using Sample;
using System;

namespace UnitTestExtensionMethod
{
    public class Tests
    {
        //punem o proprietate
        public SampleClass sample { get; protected set; }
        [SetUp]
        protected void Initialize()
        {
            this.sample = new SampleClass();
        }
        public void Setup()
        {
        }

        [Test]
        public void IsMaxLength()
        {
            
            //Arrange 
            this.sample.DnaSequence = "GCGTGTTAGTATGTTGA";
            var exceptionThrown = false;

            //Act
            try
            {
                bool result = this.sample.MaxSize();
            }
            catch (InvalidOperationException)
            {
                exceptionThrown = true;
            }

            // Assert
            Assert.IsTrue(exceptionThrown);
            
        }

        [Test]
        public void IsCharacter() {
            //Arrange 
            this.sample.DnaSequence = "GCGTGTTAGTATGTTGA";
            var exceptionThrown = false;

            //Act
            try
            {
                bool result = this.sample.CheckAllowedChars();
            }
            catch (InvalidOperationException)
            {
                exceptionThrown = true;
            }

            // Assert
            Assert.IsTrue(exceptionThrown);
        }
    }
}