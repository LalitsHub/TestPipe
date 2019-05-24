
namespace AgVueAutomation.testscripts
{
    class CKY_Happy_Path_Test
    {
        public static void testscript()
        {
            lib.resultUtil.CreateTestReport(lib.initializeTest.currentTestCase, "AG (CKY) - Happy Path Test");
            string url = lib.generalLib.readjson("UatURL");
            lib.generalLib.initializeDriver();
            lib.initializeTest.driver.Navigate().GoToUrl(url + "CKY");
            System.Threading.Thread.Sleep(2000);
            CKY.TC01_CKY_initialInquiryApplicant.testscript();
            CKY.TC02_CKY_initialInquiryLoanAction.testscript();
            CKY.TC03_CKY_initialInquiryInquiry.testscript();
            CKY.TC04_CKY_buidApplicationEditNewLoanActions.testscript();
            CKY.TC05_CKY_buildApplicationLoanActions.testscript();
            CKY.TC06_CKY_buildApplicationApplications.testscript();
            CKY.TC07_CKY_buildApplicationLoanPackage.testscript();
            CKY.TC08_CKY_analyzeCreditRequestAssignCreditAnalyst.testscript();
            CKY.TC09_CKY_preDecisionReview.testscript();
            CKY.TC10_CKY_reassignApprover.testscript();
            CKY.TC11_CKY_decisionApproverDecision.testscript();
            CKY.TC12_CKY_clearFileForClosing.testscript();
            CKY.TC13_CKY_prepareDocuments.testscript();
            CKY.TC14_CKY_receiveandReviewDocuments.testscript();
            CKY.TC15_CKY_crClosingActions_BookingandFunding.testscript();
            CKY.TC16_CKY_nextDayVerification.testscript();
            CKY.TC17_CKY_postCloseChecklist.testscript();
            CKY.TC18_CKY_finalCreditRequestActions.testscript();
            //lib.generalLib.quitDriver();
            lib.resultUtil.GenerateTestReport();
        }
    }
}
