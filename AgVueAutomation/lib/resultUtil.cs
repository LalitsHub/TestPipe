using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgVueAutomation.lib
{
    class resultUtil
    {
        /// <summary>
        /// This method will create a Summary HTML report and append the initial HTML tags or layouts for the report.
        /// </summary>
        public static void CreateSummaryReport()
        {
            string testReportPath = initializeTest.workspace + generalLib.readjson("testReportPath");
            initializeTest.summaryExecutionDate = DateTime.Now.ToString("dd_MMM_yyyy");
            initializeTest.summaryExecutionStartTime = generalLib.Time();
            initializeTest.summaryReportName = generalLib.readjson("reportName") + "_" + generalLib.Timestamp();
            initializeTest.summaryReportPath = testReportPath + "\\" + initializeTest.summaryReportName;
            initializeTest.screenShotPath = testReportPath + "\\" + initializeTest.summaryReportName + "\\ScreenShots";
            initializeTest.screenShotCounter = 0;
            string strSource = initializeTest.workspace + "\\config\\canvasjs.min.js";
            //Console.WriteLine("Source = " + source);
            string strDest = testReportPath + "\\" + initializeTest.summaryReportName + "\\canvasjs.min.js";
            //Console.WriteLine("Destination = " + dest);
            bool exists = System.IO.Directory.Exists(initializeTest.summaryReportPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(initializeTest.summaryReportPath);
                System.IO.Directory.CreateDirectory(initializeTest.screenShotPath);
            }
            else
            {
                Console.WriteLine("Directory " + initializeTest.summaryReportPath + " already exist");
            }

            initializeTest.summaryReportName = initializeTest.summaryReportPath + "\\Summary.html";
            if (!File.Exists(initializeTest.summaryReportName))
            {
                using (StreamWriter sw = File.CreateText(initializeTest.summaryReportName))
                {
                    sw.WriteLine("<html>");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<style>.datagrid table { border-collapse: collapse; text-align: center; width: 100%; }.datagrid {font: normal 12px/150% Arial, Helvetica, sans-serif; background: #fff; overflow: hidden; border: 1px solid #006699; -webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px; }.datagrid table td, .datagrid table th { padding: 3px 10px; }.datagrid table thead th {background:-webkit-gradient( linear, left top, left bottom, color-stop(0.05, #006699), color-stop(1, #00557F) );background:-moz-linear-gradient( center top, #006699 5%, #00557F 100% );filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#006699', endColorstr='#00557F');background-color:#006699; color:#FFFFFF; font-size: 12px; font-weight: bold; border-left: 1px solid #0070A8; } .datagrid table thead th:first-child { border: none; }.datagrid table tbody td { color: #00557F; border-left: 2px solid #E1EEF4;font-size: 12px;font-weight: normal; }.datagrid table tbody .alt td { background: #E1EEf4; color: #00557F; }.datagrid table tbody td:first-child { border-left: none; }.datagrid table tbody tr:last-child td { border-bottom: none; }.datagrid table tfoot td div { border-top: 1px solid #006699;background: #E1EEf4;} .datagrid table tfoot td { padding: 0; font-size: 12px } .datagrid table tfoot td div{ padding: 2px; }.datagrid table tfoot td ul { margin: 0; padding:0; list-style: none; text-align: right; }.datagrid table tfoot li { display: inline; }.datagrid table tfoot li a { text-decoration: none; display: inline-block; padding: 2px 8px; margin: 1px;color: #FFFFFF;border: 1px solid #006699;-webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px; background:-webkit-gradient( linear, left top, left bottom, color-stop(0.05, #006699), color-stop(1, #00557F) );background:-moz-linear-gradient( center top, #006699 5%, #00557F 100% );filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#006699', endColorstr='#00557F');background-color:#006699; }.datagrid table tfoot ul.active, .datagrid table tfoot ul a:hover { text-decoration:none;border-color: #00557F; color: #FFFFFF; background: none;background-color:#006699;}</style>");
                    sw.WriteLine("<script type=\"text/javascript\">");
                    sw.WriteLine("window.onload = function () {");
                    sw.WriteLine("var chart = new CanvasJS.Chart(\"chartContainer\", ");
                    sw.WriteLine("{title:{");
                    sw.WriteLine("text: \"Pie Chart\"},");
                    sw.WriteLine("data: [{type: \"pie\", showInLegend: true, toolTipContent: \"{y} - #percent %\", dataPoints: [{ y: 1, legendText: \"PASS\"},{ y: 1, legendText: \"FAIL\"}]}]");
                    sw.WriteLine("});chart.render();}");
                    sw.WriteLine("</script>");
                    sw.WriteLine("<script src=\"canvasjs.min.js\"></script>");
                    sw.WriteLine("<title>" + generalLib.readjson("reportName") + "</title>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<div align=\"center\"> <h1 id=\"header\">" + generalLib.readjson("reportName") + "</h1> </div> ");
                    sw.WriteLine("<hr><div id=\"chartContainer\" style=\"height: 300px; float:left; width: 40%;\"></div><br><br><br><br><br>");
                    sw.WriteLine("<div align=\"center\" id=\"summary\" class=\"datagrid\">");
                    sw.WriteLine("<table id=\"tblEnvDetails\"><thead><tr><th>Summary Report</th></tr></thead><tbody><tr><td id=\"1\"/></tr></tbody>");
                    sw.WriteLine("<table id=\"tblDetails\"><thead><tr><th>Date</th><th>Start Time</th><th>End Time</th><th>Duration</th><th>No. of TCs Passed</th><th>No. of TCs Failed</th><th>Total TCs Executed</th></tr></thead>");
                    sw.WriteLine("<tbody><tr><td id=\"execDate\"/></td><td id=\"startTime\"/></td><td id=\"endTime\"/></td><td id=\"duration\"/></td><td id=\"tPass\"></td><td id=\"tFail\"></td><td id=\"tExecuted\"></td></tr></tbody></table></div>");
                    sw.WriteLine("<div id=\"details\" class=\"datagrid\" style=\"width: 100%;\">");
                    sw.WriteLine("<table  id=\"details\"><thead><tr><th>Sl.No</th><th>TestCaseId</th><th>TestScript Name</th><th>TimeStamp</th><th>Status</th><th>Link</th></tr></thead>");
                    sw.WriteLine("<tbody>");
                }
            }
            else
            {
                Console.WriteLine("Summary File " + initializeTest.summaryReportName + " already exist");
            }
            //Copies the canavasjs.min.js file to the test results folder.
            generalLib.CopyFile(strSource, strDest);
        }

        /// <summary>
        /// This method will create a new HTML report and append the initial HTML tags or layouts for the report.
        /// </summary>
        /// <param name="TCID"></param>
        /// <param name="TCName"></param>
        public static void CreateTestReport(String TCID, String TCName)
        {
            initializeTest.testReportName = initializeTest.summaryReportPath + "\\" + TCID + "_" + TCName + "_" + generalLib.Timestamp() + ".html";
            //Console.WriteLine("TestReportName = " + Variables.TestReportName);
            initializeTest.currentTCID = TCID;
            initializeTest.currentTCName = TCName;
            initializeTest.testFailCount = 0;
            initializeTest.testPassCount = 0;
            initializeTest.currentTCNo = 1;
            initializeTest.testExecutionDate = DateTime.Now.ToString("dd_MMM_yyyy");
            initializeTest.testExecutionStartTime = generalLib.Time();
            if (!File.Exists(initializeTest.testReportName))
            {
                using (StreamWriter sw = File.CreateText(initializeTest.testReportName))
                {
                    sw.WriteLine("<html>");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<style>.datagrid table { border-collapse: collapse; text-align: center; width: 100%; }.datagrid {font: normal 12px/150% Arial, Helvetica, sans-serif; background: #fff; overflow: hidden; border: 1px solid #006699; -webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px; }.datagrid table td, .datagrid table th { padding: 3px 10px; }.datagrid table thead th {background:-webkit-gradient( linear, left top, left bottom, color-stop(0.05, #006699), color-stop(1, #00557F) );background:-moz-linear-gradient( center top, #006699 5%, #00557F 100% );filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#006699', endColorstr='#00557F');background-color:#006699; color:#FFFFFF; font-size: 12px; font-weight: bold; border-left: 1px solid #0070A8; } .datagrid table thead th:first-child { border: none; }.datagrid table tbody td { color: #00557F; border-left: 2px solid #E1EEF4;font-size: 12px;font-weight: normal; }.datagrid table tbody .alt td { background: #E1EEf4; color: #00557F; }.datagrid table tbody td:first-child { border-left: none; }.datagrid table tbody tr:last-child td { border-bottom: none; }.datagrid table tfoot td div { border-top: 1px solid #006699;background: #E1EEf4;} .datagrid table tfoot td { padding: 0; font-size: 12px } .datagrid table tfoot td div{ padding: 2px; }.datagrid table tfoot td ul { margin: 0; padding:0; list-style: none; text-align: right; }.datagrid table tfoot li { display: inline; }.datagrid table tfoot li a { text-decoration: none; display: inline-block; padding: 2px 8px; margin: 1px;color: #FFFFFF;border: 1px solid #006699;-webkit-border-radius: 3px; -moz-border-radius: 3px; border-radius: 3px; background:-webkit-gradient( linear, left top, left bottom, color-stop(0.05, #006699), color-stop(1, #00557F) );background:-moz-linear-gradient( center top, #006699 5%, #00557F 100% );filter:progid:DXImageTransform.Microsoft.gradient(startColorstr='#006699', endColorstr='#00557F');background-color:#006699; }.datagrid table tfoot ul.active, .datagrid table tfoot ul a:hover { text-decoration:none;border-color: #00557F; color: #FFFFFF; background: none;background-color:#006699;}</style>");
                    sw.WriteLine("<script type=\"text/javascript\">");
                    sw.WriteLine("window.onload = function () {");
                    sw.WriteLine("var chart = new CanvasJS.Chart(\"chartContainer\", ");
                    sw.WriteLine("{title:{");
                    sw.WriteLine("text: \"Pie Chart\"},");
                    sw.WriteLine("data: [{type: \"pie\", showInLegend: true, toolTipContent: \"{y} - #percent %\", dataPoints: [{ y: 1, legendText: \"PASS\"},{ y: 1, legendText: \"FAIL\"}]}]");
                    sw.WriteLine("});chart.render();}");
                    sw.WriteLine("</script>");
                    sw.WriteLine("<script src=\"canvasjs.min.js\"></script>");
                    sw.WriteLine("<title>" + TCID + " - " + TCName + "</title>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<div align=\"center\"> <h1 id=\"header\">" + TCID + " - " + TCName + "</h1> </div> ");
                    sw.WriteLine("<hr><div id=\"chartContainer\" style=\"height: 300px; float:left; width: 40%;\"></div><br><br><br><br>");
                    sw.WriteLine("<div align=\"center\" id=\"details\" class=\"datagrid\">");
                    sw.WriteLine("<table id=\"tblEnvDetails\"><thead><tr><th>Detailed Report</th></tr></thead><tbody><tr><td id=\"1\"/></tr></tbody>");
                    sw.WriteLine("<table id=\"tblDetails\"><thead><tr><th>Date</th><th>Start Time</th><th>End Time</th><th>Duration</th><th>No. of Steps Passed</th><th>No. of Steps Failed</th><th>Total Executed Steps</th></tr></thead>");
                    sw.WriteLine("<tbody><tr><td id=\"execDate\"/></td><td id=\"startTime\"/></td><td id=\"endTime\"/></td><td id=\"duration\"/></td><td id=\"tPass\"></td><td id=\"tFail\"></td><td id=\"tExecuted\"></td></tr></tbody></table></div>");
                    sw.WriteLine("<div id=\"details\" class=\"datagrid\" style=\"width: 100%;\">");
                    sw.WriteLine("<table  id=\"details\"><thead><tr><th>Sl.No</th><th>Test Step</th><th>Expected Result</th><th>Actual Result</th><th>TimeStamp</th><th>Status</th><th>ScreenShot</th></tr></thead>");
                    sw.WriteLine("<tbody>");
                }
            }
            else
            {
                Console.WriteLine("Test Report " + initializeTest.testReportName + " already exist");
            }
        }

        /// <summary>
        /// This method will append the Test case execution result to summary result. This method should be called after completion of each TC execution. This function will also make the failed TCs in the summary report to red color for quick notice.
        /// </summary>
        /// <param name="strPassFail"></param>
        public static void AddSummaryResult(string strPassFail)
        {
            using (StreamWriter sw = File.AppendText(initializeTest.summaryReportName))
            {
                sw.WriteLine("<tr name=\"" + strPassFail + "\">");
                if (strPassFail.Equals("FAIL", StringComparison.Ordinal))
                {
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + initializeTest.currentSummaryTCNo + "</td>");
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + initializeTest.currentTCID + "</td>");
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + initializeTest.currentTCName + "</td>");
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + generalLib.Timestamp() + "</td>");
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + strPassFail + "</td>");
                    initializeTest.summaryFailCount = initializeTest.summaryFailCount + 1;
                }

                if (strPassFail.Equals("PASS", StringComparison.Ordinal))
                {
                    sw.WriteLine("<td>" + initializeTest.currentSummaryTCNo + "</td>");
                    sw.WriteLine("<td>" + initializeTest.currentTCID + "</td>");
                    sw.WriteLine("<td>" + initializeTest.currentTCName + "</td>");
                    sw.WriteLine("<td>" + generalLib.Timestamp() + "</td>");
                    sw.WriteLine("<td>" + strPassFail + "</td>");
                    initializeTest.summaryPassCount = initializeTest.summaryPassCount + 1;
                }
                initializeTest.currentSummaryTCNo = initializeTest.currentSummaryTCNo + 1;
                string[] str = initializeTest.testReportName.Split('\\');
                int len = str.Length;
                sw.WriteLine("<td><a href=\"" + str[len - 1] + "\">Link</a></td>");
                sw.WriteLine("</tr>");
            }
        }

        /// <summary>
        /// This method will append the result of each TCs to the HTML report. This function will also make the failed TCs to red color for quick notice.
        /// </summary>
        /// <param name="strTestStep"></param>
        /// <param name="strExpectedResult"></param>
        /// <param name="strActualResult"></param>
        /// <param name="strPassFail"></param>
        public static void AddResult(string strTestStep, string strExpectedResult, string strActualResult, string strPassFail)
        {

            generalLib.CaptureScreen();
            strTestStep = strTestStep.Replace("<<", "<b><font color =\"green\">").Replace(">>", "</font></b>");
            strExpectedResult = strExpectedResult.Replace("<<", "<b><font color =\"green\">").Replace(">>", "</font></b>");
            strActualResult = strActualResult.Replace("<<", "<b><font color =\"green\">").Replace(">>", "</font></b>");
            using (StreamWriter sw = File.AppendText(initializeTest.testReportName))
            {                
                sw.WriteLine("<tr name=\"" + strPassFail + "\">");
                if (strPassFail.Equals("FAIL", StringComparison.Ordinal))
                {
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + initializeTest.currentTCNo + "</td>");
                    sw.WriteLine("<td align=\"left\" style=\"color:red;font-weight:bold;\">" + strTestStep + "</td>");
                    sw.WriteLine("<td align=\"left\" style=\"color:red;font-weight:bold;\">" + strExpectedResult + "</td>");
                    sw.WriteLine("<td align=\"left\" style=\"color:red;font-weight:bold;\">" + strActualResult + "</td>");
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + generalLib.Timestamp() + "</td>");
                    sw.WriteLine("<td style=\"color:red;font-weight:bold;\">" + strPassFail + "</td>");
                    initializeTest.testFailCount = initializeTest.testFailCount + 1;
                }

                if (strPassFail.Equals("PASS", StringComparison.Ordinal))
                {
                    sw.WriteLine("<td>" + initializeTest.currentTCNo + "</td>");
                    sw.WriteLine("<td align=\"left\">" + strTestStep + "</td>");
                    sw.WriteLine("<td align=\"left\">" + strExpectedResult + "</td>");
                    sw.WriteLine("<td align=\"left\">" + strActualResult + "</td>");
                    sw.WriteLine("<td>" + generalLib.Timestamp() + "</td>");
                    sw.WriteLine("<td>" + strPassFail + "</td>");
                    initializeTest.testPassCount = initializeTest.testPassCount + 1;
                }
                initializeTest.currentTCNo = initializeTest.currentTCNo + 1;
                sw.WriteLine("<td><a href=\"ScreenShots\\" + initializeTest.screenShotName + "\">Link</a></td>");
                sw.WriteLine("</tr>");
            }
        }

        /// <summary>
        ///  This method updates the following entries in the HTML report
        ///  1. PieChart Legends values
        ///  2. Total Passed TCs
        ///  3. Total Failed TCs
        ///  4. Execution Date
        ///  5. Start Time
        ///  6. End TIme
        ///  7. Duration
        /// </summary>
        public static void updateSummaryResults()
        {
            initializeTest.summaryExecutionEndTime = generalLib.Time();
            initializeTest.summaryTestDuration = generalLib.Duration(initializeTest.summaryExecutionStartTime, initializeTest.summaryExecutionEndTime);
            int intTotalExecuted = initializeTest.summaryPassCount + initializeTest.summaryFailCount;
            var content = string.Empty;
            using (StreamReader reader = new StreamReader(initializeTest.summaryReportName))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }

            content = Regex.Replace(content, "{ y: 1, legendText: \"PASS\"},{ y: 1, legendText: \"FAIL\"}", "{ y: " + initializeTest.summaryPassCount + ", legendText: \"PASS\"},{ y: " + initializeTest.summaryFailCount + ", legendText: \"FAIL\"}");
            content = Regex.Replace(content, "<tbody><tr><td id=\"execDate\"/></td><td id=\"startTime\"/></td><td id=\"endTime\"/></td><td id=\"duration\"/></td><td id=\"tPass\"></td><td id=\"tFail\"></td><td id=\"tExecuted\"></td></tr></tbody></table></div>", "<tbody><tr><td id=\"execDate\"/>" + initializeTest.summaryExecutionDate + "</td><td id=\"startTime\"/>" + initializeTest.summaryExecutionStartTime + "</td><td id=\"endTime\"/>" + initializeTest.summaryExecutionEndTime + "</td><td id=\"duration\"/>" + initializeTest.summaryTestDuration + "</td><td id=\"tPass\">" + initializeTest.summaryPassCount + "</td><td id=\"tFail\">" + initializeTest.summaryFailCount + "</td><td id=\"tExecuted\">" + intTotalExecuted + "</td></tr></tbody></table></div>");

            using (StreamWriter writer = new StreamWriter(initializeTest.summaryReportName))
            {
                writer.Write(content);
                writer.Close();
            }
        }

        /// <summary>
        /// This method updates the following entries in the HTML report
        /// 1. PieChart Legends values
        /// 2. Total Passed Steps
        /// 3. Total Failed Steps
        /// 4. Execution Date
        /// 5. Start Time
        /// 6. End TIme
        /// 7. Duration
        /// </summary>
        public static void updateTestResults()
        {
            initializeTest.testExecutionEndTime = generalLib.Time();
            initializeTest.testDuration = generalLib.Duration(initializeTest.testExecutionStartTime, initializeTest.testExecutionEndTime);
            int intTotalExecuted = initializeTest.testPassCount + initializeTest.testFailCount;
            if (initializeTest.testFailCount > 0)
            {
                AddSummaryResult("FAIL");
            }
            else
            {
                AddSummaryResult("PASS");
            }

            var content = string.Empty;
            using (StreamReader reader = new StreamReader(initializeTest.testReportName))
            {
                content = reader.ReadToEnd();
                reader.Close();
            }

            content = Regex.Replace(content, "{ y: 1, legendText: \"PASS\"},{ y: 1, legendText: \"FAIL\"}", "{ y: " + initializeTest.testPassCount + ", legendText: \"PASS\"},{ y: " + initializeTest.testFailCount + ", legendText: \"FAIL\"}");
            content = Regex.Replace(content, "<tbody><tr><td id=\"execDate\"/></td><td id=\"startTime\"/></td><td id=\"endTime\"/></td><td id=\"duration\"/></td><td id=\"tPass\"></td><td id=\"tFail\"></td><td id=\"tExecuted\"></td></tr></tbody></table></div>", "<tbody><tr><td id=\"execDate\"/>" + initializeTest.testExecutionDate + "</td><td id=\"startTime\"/>" + initializeTest.testExecutionStartTime + "</td><td id=\"endTime\"/>" + initializeTest.testExecutionEndTime + "</td><td id=\"duration\"/>" + initializeTest.testDuration + "</td><td id=\"tPass\">" + initializeTest.testPassCount + "</td><td id=\"tFail\">" + initializeTest.testFailCount + "</td><td id=\"tExecuted\">" + intTotalExecuted + "</td></tr></tbody></table></div>");
            using (StreamWriter writer = new StreamWriter(initializeTest.testReportName))
            {
                writer.Write(content);
                writer.Close();
            }
        }

        /// <summary>
        /// This method prepares the final Summary report and it should be called at the end of 
        /// execution of all test scripts. Firstly it calls CreateReportFooter method to add the last closing html tags.
        /// then it calls the copyFile method to copy the canavas js file to the result folder.Lastly calls the 
        /// updateResults method to add the the summary values to the report.
        /// </summary>
        public static void GenerateSummaryReport()
        {
            CreateSummaryReportFooter();
            updateSummaryResults();
        }

        /// <summary>
        /// his method prepares the Test report and it should be called at the end of 
        /// each test execution. Firstly it calls CreateReportFooter method to add the last closing html tags.
        /// Lastly calls the updateResults method to add the the summary values to the report
        /// </summary>
        public static void GenerateTestReport()
        {
            CreateReportFooter();
            updateTestResults();
        }

        /// <summary>
        /// This method adds the last closing html tags to the Summary HTML result file.
        /// </summary>
        public static void CreateSummaryReportFooter()
        {
            using (StreamWriter sw = File.AppendText(initializeTest.summaryReportName))
            {
                sw.WriteLine("</tbody>");
                sw.WriteLine("</table>");
                sw.WriteLine("</div>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
        }

        /// <summary>
        /// This method adds the last closing html tags to the Summary HTML result file.
        /// </summary>
        public static void CreateReportFooter()
        {
            using (StreamWriter sw = File.AppendText(initializeTest.testReportName))
            {
                sw.WriteLine("</tbody>");
                sw.WriteLine("</table>");
                sw.WriteLine("</div>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
        }

    }
}
