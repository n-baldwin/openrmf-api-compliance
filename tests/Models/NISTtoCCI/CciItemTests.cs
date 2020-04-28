using Xunit;
using openrmf_api_compliance.Models.NISTtoCCI;

namespace tests.Models
{
    public class CciItemTests
    {
        [Fact]
        public void Test_NewCciItemIsValid()
        {
            CciItem cciItem = new CciItem();

            // Testing
            Assert.False(cciItem == null);
        }
    
        [Fact]
        public void Test_CciItemWithDataIsValid()
        {
            CciItem cciItem = new CciItem();
            
            cciItem.cciId = "cciId";
            cciItem.status = "status";
            cciItem.publishDate = "mydate";
            cciItem.contributor = "mycontributor";
            cciItem.definition = "mydefinition";
            cciItem.type = "mytype";
            cciItem.parameter = "param1";
            cciItem.note = "mynote";

            CciReference cciReference = new CciReference();

            cciReference.creator = "me";
            cciReference.title = "mytitle";
            cciReference.version = "v1";
            cciReference.location = "mylocation";
            cciReference.index = "2.3";
            cciReference.majorControl = "AC-2";
            cciItem.references.Add(cciReference);

            // Testing
            Assert.True(cciItem.cciId == "cciId");
            Assert.True(cciItem.status == "status");
            Assert.True(cciItem.publishDate == "mydate");
            Assert.True(cciItem.contributor == "mycontributor");
            Assert.True(cciItem.definition == "mydefinition");
            Assert.True(cciItem.type == "mytype");
            Assert.True(cciItem.parameter == "param1");
            Assert.True(cciItem.note == "mynote");
            Assert.True(cciItem.references.Count == 1);
        }
    }
}
