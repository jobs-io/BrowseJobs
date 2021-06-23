using NUnit.Framework;
using Moq;

namespace BrowseJobs.Tests
{
    public class JobsTests
    {
        private Mock<IService> _serviceMock;

        [SetUp]
        public void Setup()
        {
            _serviceMock = new Mock<IService>();
        }

        [Test]
        public void ShouldGetJobs()
        {
            _serviceMock.Setup(x => x.Download());

            new Jobs(_serviceMock.Object);

            _serviceMock.Verify(x => x.Download(), Times.Once);
        }
    }

    public interface IService {
        void Download();
    }

    public class Jobs {

        // private readonly IService service;
        public Jobs(IService service)
        {
            service.Download();
        }
    }
}