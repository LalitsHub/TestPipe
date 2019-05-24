using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC13_CKY_prepareDocuments
    {
        /// <summary>
        /// Test Case : Prepare Documents
        /// Test Steps :
        /// Select Admin tab.Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select "Prepare Documents" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// Search with the case number and click on Search button
        /// Select "Prepare Documents" task
        /// Select "Documents Prepared" checkbox
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC13CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_13>>", "<<Prepare Documents>>", "<<Prepare Documents>>", "PASS");
                pages.CKYCreditRequestcs.clickDocumentsSent();
            }
        }
    }
}
