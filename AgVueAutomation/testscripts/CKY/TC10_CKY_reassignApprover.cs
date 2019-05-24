using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC10_CKY_reassignApprover
    {
        /// <summary>
        /// Test Case : Reassign Approver
        /// Test Steps :
        /// Select Admin tab. Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select "Approve Loan Actions" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC10CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_10>>", "<<Reassign Approver>>", "<<Reassign Approver>>", "PASS");
                string idcase = pages.CKYCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                System.Threading.Thread.Sleep(3000);
                pages.CKYCreditRequestcs.searchCase(idcase);
                pages.CKYCreditRequestcs.clickApproveLoanAction(dtResult[0]["TestData1"].ToString());
                System.Threading.Thread.Sleep(7000);
            }
        }
    }
}
