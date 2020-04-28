using Xunit;
using openrmf_api_compliance.Models.Compliance;
using System;

namespace tests.Models
{
    public class ComplianceRecordTests
    {
        [Fact]
        public void Test_NewComplianceRecordIsValid()
        {
            ComplianceRecord complianceRecord = new ComplianceRecord();

            // Testing
            Assert.False(complianceRecord == null);
        }
    
        [Fact]
        public void Test_ComplianceRecordWithDataIsValid()
        {
            ComplianceRecord complianceRecord = new ComplianceRecord();
            
            complianceRecord.artifactId = "23423423423423423423";
            complianceRecord.title = "mytitle";
            complianceRecord.stigType = "Google Chrome";
            complianceRecord.stigRelease = "Version 1";
            complianceRecord.status = "valid";
            complianceRecord.hostName = "myHost";
            complianceRecord.updatedOn = DateTime.Now;

            // Testing
            Assert.True(complianceRecord.artifactId == "23423423423423423423");
            Assert.True(complianceRecord.title == "mytitle");
            Assert.True(complianceRecord.stigType == "Google Chrome");
            Assert.True(complianceRecord.stigRelease == "Version 1");
            Assert.True(complianceRecord.status == "valid");
            Assert.True(complianceRecord.hostName == "myHost");
            Assert.False(complianceRecord.updatedOn == null);
        }
    }
}
