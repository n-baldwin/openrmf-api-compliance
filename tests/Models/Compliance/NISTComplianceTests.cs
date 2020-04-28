using Xunit;
using openrmf_api_compliance.Models.Compliance;
using System;

namespace tests.Models
{
    public class NISTComplianceTests
    {
        [Fact]
        public void Test_NewNISTComplianceIsValid()
        {
            NISTCompliance nistCompliance = new NISTCompliance();

            // Testing
            Assert.False(nistCompliance == null);
        }
    
        [Fact]
        public void Test_NISTComplianceWithDataIsValid()
        {
            NISTCompliance nistCompliance = new NISTCompliance();
            nistCompliance.control = "AC-1";
            nistCompliance.index = "1.2";
            nistCompliance.title = "My Title here";
            nistCompliance.version = "23333";
            nistCompliance.location = "this location";
            nistCompliance.CCI = "34234234234";
            nistCompliance.sortString = "AC-01";

            ComplianceRecord complianceRecord = new ComplianceRecord();
            complianceRecord.artifactId = "23423423423423423423";
            complianceRecord.title = "mytitle";
            complianceRecord.stigType = "Google Chrome";
            complianceRecord.stigRelease = "Version 1";
            complianceRecord.status = "valid";
            complianceRecord.hostName = "myHost";
            complianceRecord.updatedOn = DateTime.Now;

            nistCompliance.complianceRecords.Add(complianceRecord);

            // Testing
            Assert.True(nistCompliance.control == "AC-1");
            Assert.True(nistCompliance.index == "1.2");
            Assert.True(nistCompliance.title == "My Title here");
            Assert.True(nistCompliance.version == "23333");
            Assert.True(nistCompliance.location == "this location");
            Assert.True(nistCompliance.CCI == "34234234234");
            Assert.True(nistCompliance.complianceRecords.Count == 1);
            Assert.True(nistCompliance.sortString == "AC-01");
        }
    }
}
