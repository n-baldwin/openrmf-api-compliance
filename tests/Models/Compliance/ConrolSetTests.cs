using Xunit;
using openrmf_api_compliance.Models.Compliance;
using System;

namespace tests.Models
{
    public class ControlSetTests
    {
        [Fact]
        public void Test_NewControlSetIsValid()
        {
            ControlSet controlSet = new ControlSet();
            
            // Testing
            Assert.False(controlSet == null);
        }
    
        [Fact]
        public void Test_ControlSetWithDataIsValid()
        {
            ControlSet controlSet = new ControlSet();

            controlSet.id = Guid.NewGuid();
            controlSet.family = "Program Management";
            controlSet.number = "PM-12";
            controlSet.title = "Program Mgmt Title";
            controlSet.priority = "P1";
            controlSet.lowimpact = true;
            controlSet.moderateimpact = true;
            controlSet.highimpact = false;
            controlSet.supplementalGuidance = "My supplemental text";
            controlSet.subControlDescription = "my description";
            controlSet.subControlNumber = "1.1.1.1.1";

            // Testing
            Assert.True(controlSet.family == "Program Management");
            Assert.True(controlSet.number == "PM-12");
            Assert.True(controlSet.title == "Program Mgmt Title");
            Assert.True(controlSet.priority == "P1");
            Assert.True(controlSet.supplementalGuidance == "My supplemental text");
            Assert.True(controlSet.subControlDescription == "my description");
            Assert.True(controlSet.subControlNumber == "1.1.1.1.1");
            Assert.True(controlSet.lowimpact);
            Assert.True(controlSet.moderateimpact);
            Assert.False(controlSet.highimpact);
            Assert.False(controlSet.id == null);
        }
    }
}
