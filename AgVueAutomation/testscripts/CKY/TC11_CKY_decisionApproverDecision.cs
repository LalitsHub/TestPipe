using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC11_CKY_decisionApproverDecision
    {
        /// <summary>
        /// Test Case : Decision - Approver Decision
        /// Test Steps :
        /// Login to the application as Loan approver
        /// Check whether the user receives a request in the Inbox with activity  "Approve loan actions". Click on the request.
        /// Select "Approve" for "Approver Decision"
        /// Click on "Submit" button
        /// Select "Submit Credit Request for Processing" for "Post Decision Review"
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC11CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_11>>", "<<Decision - Approver Decision>>", "<<Decision - Approver Decision>>", "PASS");
                string idcase = pages.CKYCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectMenuYAN("INBOX", "", "");
                System.Threading.Thread.Sleep(3000);
                pages.CKYCreditRequestcs.searchCaseIdWithAprroval(idcase);
                System.Threading.Thread.Sleep(5000);
                pages.CKYCreditRequestcs.selectApproverDecision();
                pages.CKYCreditRequestcs.selectPostDecisionReview();
            }
        }
    }
}
