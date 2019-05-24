using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC14_CKY_receiveandReviewDocuments
    {
        /// <summary>
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC14CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_14>>", "<<Review Documents>>", "<<Review Documents>>", "PASS");
                pages.CKYCreditRequestcs.receiveandReviewDocuments();

            }
        }
    }
}
