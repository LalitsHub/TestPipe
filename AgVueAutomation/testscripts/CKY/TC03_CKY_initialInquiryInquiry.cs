using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC03_CKY_initialInquiryInquiry
    {
        /// <summary>
        /// Test Case :Initial Inquiry - Inquiry
        /// Test Steps :
        /// 1. Click on "Inquiry" tab  
        /// 2.Enter Values in the below fields for consumer loan:
        ///         -Inquiry Decision: Select "Proceed with Application"
        ///         -Application Date: M/d/yyyy
        ///         -Inquiry Comments: 
        /// 3. Click on "Save" button 
        /// 4. Click on "Submit" button 
        /// 5. Verify the breadcrumbs displayed at the top of the page
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC03CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_03>>", "<<Initial Inquiry - Inquiry>>", "<<Initial Inquiry - Inquiry>>", "PASS");
                // Add Inquiry Decision
                pages.CKYCreditRequestcs.addinquiryDecisionAG(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString());
            }
        }
    }
}
