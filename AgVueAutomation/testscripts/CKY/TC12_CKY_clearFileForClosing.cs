using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC12_CKY_clearFileForClosing
    {
        /// <summary>
        /// Test Case : Clear File for Closing
        /// Test Steps :
        /// Login to the application
        /// Select Admin tab.Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select "Clear File for Closing" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// Search with the case number and click on Search button
        /// Select Clear File for Closing task
        /// Select "CD Processing LO" from the drop down
        /// Select "CD Rec./Serv.L/O"  from the drop down
        /// Verify "CD Loan ID" field under "Loan Action" tab is empty
        /// Select "Submit Loan to CD" button
        /// Verify "CD Loan ID" field under "Loan Action" tab
        /// Navigate to "Pre-Close Checklist" tab
        /// Select "Pre-Close Status" as "Complete" for the "Pre-Close Checklist Items"
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC12CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_12>>", "<<Clear File for Closing>>", "<<Clear File for Closing>>", "PASS");                
                pages.CKYCreditRequestcs.checkPreCloseChecklist();
                pages.CKYCreditRequestcs.selectCDSubmit(dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString(), dtResult[0]["TestData4"].ToString());
            }
        }
    }
}
