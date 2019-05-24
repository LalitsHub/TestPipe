using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC08_CKY_analyzeCreditRequestAssignCreditAnalyst
    {
        /// <summary>
        /// Test Case : Analyze Credit Request - Asssign Credit Analyst
        /// Test Steps :
        /// Verify the user is logged into the application and the breadcrumb is displayed as in Assign Credit Analyst process
        /// Click on "Assign Analyst" tab.
        /// Select "No" for Review required
        /// Select Assign Analyst from the analyst decision.Then select the analyst from the drop down "Credit Analyst"
        /// Click on "Save" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC08CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_08>>", "<<Analyze Credit Request - Assign Credit Analyst>>", "<<Analyze Credit Request - Assign Credit Analyst>>", "PASS");
                //Assign Analyst
                pages.CKYCreditRequestcs.assignAnalyst(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString());
                //Assign Collaterals, Exceptions, Conditions
                pages.CKYCreditRequestcs.verifyCollateralsExceptionsandConditions();                 
            }
        }
    }
}
