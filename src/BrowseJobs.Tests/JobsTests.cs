using NUnit.Framework;
using Moq;

namespace BrowseJobs.Tests
{
    public class JobsTests
    {
        private Mock<IService> _service;

        [SetUp]
        public void Setup()
        {
            _service = new Mock<IService>();
        }

        [Test]
        public void ShouldGetJobs()
        {
            new Jobs(_service.Object);
        }
    }

    public interface IService {}

    public class Jobs {

        private readonly IService service;
        public Jobs(IService service)
        {
            
        }
    }
}