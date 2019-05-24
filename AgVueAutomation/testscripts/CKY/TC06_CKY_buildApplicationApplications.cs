using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC06_CKY_buildApplicationApplications
    {
        /// <summary>
        /// Test Case : Build Application - Applications
        /// Test Steps :        
        /// 1.Click on "Application" tab 
        /// 2.Select "Process Application" from Application decision option
        /// 3.Click on "Save" button 
        /// 4.Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC06CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_06>>", "<<Build Application - Applications>>", "<<Build Application - Applications>>", "PASS");
                pages.CKYCreditRequestcs.addApplication_Decession(dtResult[0]["TestData1"].ToString(), dtResult[0]["TestData2"].ToString());
            }
        }
    }
}
