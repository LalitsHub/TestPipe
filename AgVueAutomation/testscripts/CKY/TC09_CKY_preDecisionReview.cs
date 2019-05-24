using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC09_CKY_preDecisionReview
    {
        /// <summary>
        /// Test Case : Decision - Pre-Decision Review
        /// Test Steps :
        /// 1.Precondition:
        /// Execute "Analyze Credit Request - Credit Analysis" test case 
        /// 2.Login to the application 
        /// 3.Check whether the user receives a request in the Inbox with activity "Pre-Decision Review". Click on the request. 
        /// 4.Select "Send for Decisioning" for "Pre-Decision Review Decision" 
        /// 5.Click on "Save" button 
        /// '''6.Click on "Submit" button 
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC09CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_09>>", "<<Decision - Pre-Decision Review>>", "<<Decision - Pre-Decision Review>>", "PASS");
                pages.CKYCreditRequestcs.preDecisionReviewCKY(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString());
            }
        }
    }
}
