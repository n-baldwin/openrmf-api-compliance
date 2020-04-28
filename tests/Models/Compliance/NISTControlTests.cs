using Xunit;
using openrmf_api_compliance.Models.Compliance;

namespace tests.Models
{
    public class NISTControlTests
    {
        [Fact]
        public void Test_NewNISTControlIsValid()
        {
            NISTControl nistControl = new NISTControl();

            // Testing
            Assert.False(nistControl == null);
        }
    
        [Fact]
        public void Test_CciItemWithDataIsValid()
        {
            NISTControl nistControl = new NISTControl();

            nistControl.control = "AC-1";
            nistControl.index = "1.2";
            nistControl.title = "My Title here";
            nistControl.version = "23333";
            nistControl.location = "this location";
            nistControl.CCI = "34234234234";
            
            // test things out
            Assert.True(nistControl != null);
            Assert.True(nistControl.control == "AC-1");
            Assert.True(nistControl.index == "1.2");
            Assert.True(nistControl.title == "My Title here");
            Assert.True(nistControl.version == "23333");
            Assert.True(nistControl.location == "this location");
            Assert.True(nistControl.CCI == "34234234234");
        }
    }
}
