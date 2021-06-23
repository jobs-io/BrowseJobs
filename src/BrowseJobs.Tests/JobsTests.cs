using NUnit.Framework;
using Moq;

namespace BrowseJobs.Tests
{
    public class JobsTests
    {
        private Mock<IService> _serviceMock;
        private Mock<IResult> _resultMock;

        [SetUp]
        public void Setup()
        {
            _serviceMock = new Mock<IService>();
            _resultMock = new Mock<IResult>();
        }

        [Test]
        public void ShouldDownloadJobs()
        {
            _serviceMock.Setup(x => x.Download());

            new Jobs(_serviceMock.Object);

            _serviceMock.Verify(x => x.Download(), Times.Once);
        }

        [Test]
        public void ShouldDisplayJobs() {
            _resultMock.Setup(x => x.Display());
            _serviceMock.Setup(x => x.Download()).Returns(_resultMock.Object);

            new Jobs(_serviceMock.Object).Display();

            _resultMock.Verify(x => x.Display(), Times.Once);
        }
    }
}
