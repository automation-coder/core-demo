
using NUnit.Framework;
using System.Threading.Tasks;

namespace CoreDemo.Tests
{
    public class Tests
    {
        [Category("Test")]
        [Test]
        public async Task testApiCall()
        {
            CoreDemo.API.Request.API api = new CoreDemo.API.Request.API();
            var response = await api.testrequest();
        }
    }
}
