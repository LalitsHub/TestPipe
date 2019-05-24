using AgVueAutomation.lib;
using System.Data;

namespace AgVueAutomation.testscripts.CKY
{
    class TC15_CKY_crClosingActions_BookingandFunding
    {
        /// <summary>
        /// Test Case : Credit Request Closing - Recieve Signed Docs and Send For Booking
        /// Test Steps :
        /// Select Admin tab. Then select "Cases"
        /// Search with the case number and click on Search button
        /// Select  "Receive Docs and Send for Booking" and then click on Reassign button
        /// Enter full name(Service AC) to search and click on search button
        /// Select the search user displayed and click on Reassign button.Then click on Finish button
        /// Close the case window displayed
        /// Search with the case number and click on Search button
        /// Select "Receive Docs and Send for Booking" task
        /// Click on "Submit" button
        /// </summary>
        public static void testscript()
        {
            generalLib objgeneralLib = new generalLib();
            DataRow[] dtResult = objgeneralLib.ImportFromExcel("TC15CKY");
            if (dtResult.Length > 0)
            {
                lib.resultUtil.AddResult("<<CKY_TC_15>>", "<<Credit Request Closing - Recieve Signed Docs and Send For Booking>>", "<<Credit Request Closing - Recieve Signed Docs and Send For Booking>>", "PASS");
                string idcase = pages.CKYCreditRequestcs.fetchCaseID();
                pages.mainMenu.selectAdminCases();
                System.Threading.Thread.Sleep(3000);
                pages.CKYCreditRequestcs.searchCase(idcase);
                pages.CKYCreditRequestcs.clickAcceptBookingAndReassign(dtResult[0]["TestData1"].ToString());                
                System.Threading.Thread.Sleep(5000);
                pages.mainMenu.selectMenuCKY("INBOX", "", "");
                System.Threading.Thread.Sleep(3000);                
                pages.CKYCreditRequestcs.searchCaseIdWithAcceptBooking(idcase);
                //System.Threading.Thread.Sleep(1000);
                pages.CKYCreditRequestcs.fetchtaskreviewerQueue(); 
                pages.CKYCreditRequestcs.clickAcceptBooking();
                pages.CKYCreditRequestcs.bookingAndFunding();
                pages.CKYCreditRequestcs.selectNextDayVerification();
            }
        }
    }
}
