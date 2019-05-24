using NUnit.Framework;

namespace AgVueAutomation
{
    /// <summary>
    /// Driver script class will call all the tests which are specified in the test suite excel sheet
    /// </summary>
    class driverscript
    {
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void initialize()
        {
            lib.resultUtil.CreateSummaryReport();
        }
        [Test]
        public void Executetest()
        {
            int i, rcount = 0;
            string tcname;
            rcount = lib.generalLib.getTestSuiteRowCount();
            for (i=2; i<=rcount; i++)
            {           
                if (lib.generalLib.getCellValue(i, 3) == "Yes")
                {
                    lib.initializeTest.currentTestCase = lib.generalLib.getCellValue(i, 1);
                    tcname = lib.generalLib.getCellValue(i, 2);
                    lib.generalLib.InvokeStringMethod("AgVueAutomation", "AgVueAutomation.testscripts", tcname.Trim(), "testscript");
                }
            }
        }
        [TearDown]
        public void cleanup()
        {
            lib.generalLib.quitDriver();
            lib.resultUtil.GenerateSummaryReport();
            System.Diagnostics.Process.Start(lib.initializeTest.summaryReportPath + "\\summary.html");
        }
    }
}