using Xunit;

namespace ManualDi.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var repo = new ValueRepository();
            var service = new ValueService(repo);
            var controller = new ValuesController(service);
            var controllerActivator = new ManualControllerActivator(new [] { controller });
        }
    }
}
