using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgVueAutomation.lib
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassNamme
    }
    class initializeTest
    {
        public static IWebDriver driver { get; set; }
        
        //AUT related Variables
        public static string projectName = "AgVue.Automation";
 
        //Database related Variables
        public static string dbConnectionString = "";

        //Test Result related Variables
        public static string workspace = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase))).Remove(0, 6);
        public static string testDataPath = initializeTest.workspace + generalLib.readjson("testDataPath");
        public static string testSuitePath = initializeTest.workspace + generalLib.readjson("testSuitePath");
        public static string testXMLPath = initializeTest.workspace + generalLib.readjson("testXMLPath");
        public static string testReportName = "";
        public static string testReportPath = "";
        public static string summaryReportName = "";
        public static string summaryReportPath = "";
        public static string screenShotPath = "";
        public static string screenShotName = "";
        public static int screenShotCounter = 1;
        public static int summaryFailCount = 0;
        public static int summaryPassCount = 0;
        public static int testFailCount = 0;
        public static int testPassCount = 0;
        public static int currentSummaryTCNo = 1;
        public static int currentTCNo = 1;
        public static string currentTCID = "";
        public static string currentTCName = "";
        public static string summaryExecutionDate = "";
        public static string testExecutionDate = "";
        public static string summaryExecutionStartTime = "";
        public static string summaryExecutionEndTime = "";
        public static string testExecutionStartTime = "";
        public static string testExecutionEndTime = "";
        public static string summaryTestDuration = "";
        public static string testDuration = "";
        public static string currentTestCase = "";
        //Maximum wait in seconds
        public static int maxWait = 60;
    }
}
