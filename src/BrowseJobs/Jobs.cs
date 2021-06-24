namespace BrowseJobs
{
    public class Jobs {

        private readonly IResult result;

        public Jobs(IService service)
        {
            this.result = service.Download();
        }

        public void Display() {
            this.result.Display();
        }
    }
}