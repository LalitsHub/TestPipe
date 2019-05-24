using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC04_CKY_buidApplicationEditNewLoanActions
    {
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC04CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_04>>", "<<Build Application - Loan Actions - Edit New Loan Actions>>", "<<Build Application - Loan Actions - Edit New Loan Actions>>", "PASS");
                System.Threading.Thread.Sleep(3000);
                pages.CKYCreditRequestcs.EditLoanActionAG(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString(), dtResult[0]["TestData3"].ToString(), dtResult[0]["TestData4"].ToString(), dtResult[0]["TestData5"].ToString(), dtResult[0]["TestData6"].ToString(), dtResult[0]["TestData7"].ToString(), dtResult[0]["TestData8"].ToString(), dtResult[0]["TestData9"].ToString(), dtResult[0]["TestData10"].ToString(), dtResult[0]["TestData11"].ToString(), dtResult[0]["TestData12"].ToString(), dtResult[0]["TestData13"].ToString(), dtResult[0]["TestData14"].ToString(), dtResult[0]["TestData15"].ToString(), dtResult[0]["TestData16"].ToString(), dtResult[0]["TestData17"].ToString(), dtResult[0]["TestData18"].ToString());
            }
        }
    }
}
