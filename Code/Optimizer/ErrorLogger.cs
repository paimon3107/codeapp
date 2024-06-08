﻿using System;
using System.IO;
using System.Text;

namespace Optimizer {
    internal static class Logger {
        internal static string ErrorLogFile = Path.Combine(CoreHelper.CoreFolder, "RGBTool.log");

        static StringBuilder _silentReportLog;

        private static void LogErrorSilent(string functionName, string errorMessage, string errorStackTrace) {
            _silentReportLog.AppendLine(string.Format("[ERROR] [{0}] in function [{1}]", DateTime.Now.ToString(), functionName));
            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine(errorMessage);
            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine(errorStackTrace);
            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine();
        }

        internal static void LogInfoSilent(string message) {
            _silentReportLog.AppendLine($"[OK] {message}");
            _silentReportLog.AppendLine();
        }

        internal static void InitializeSilentReport() {
            _silentReportLog = new StringBuilder();

            _silentReportLog.AppendLine(Utilities.GetWindowsDetails());
            _silentReportLog.AppendLine(string.Format("RGBTool {0} - .NET Framework {1} - Experimental build: {2}", Program.GetCurrentVersionTostring(), Utilities.GetNETFramework(), Program.EXPERIMENTAL_BUILD));
            _silentReportLog.AppendLine($"{DateTime.Now.ToLongDateString()} - {DateTime.Now.ToLongTimeString()}");

            _silentReportLog.AppendLine();
            _silentReportLog.AppendLine();
        }

        internal static void GenerateSilentReport() {
            try {
                File.WriteAllText($"Optimizer.SilentReport.{DateTime.Now.ToString("yyyyMMddTHHmm")}.log", _silentReportLog.ToString());
            }
            catch { }
        }

        internal static void LogError(string functionName, string errorMessage, string errorStackTrace) {
            if (Program.SILENT_MODE) {
                LogErrorSilent(functionName, errorMessage, errorStackTrace);
                return;
            }

            try {
                if (!File.Exists(ErrorLogFile) || (File.Exists(ErrorLogFile) && File.ReadAllText(ErrorLogFile).Trim() == string.Empty)) {
                    File.AppendAllText(ErrorLogFile, Utilities.GetWindowsDetails());
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                    File.AppendAllText(ErrorLogFile, string.Format("RGBTool {0} - .NET Framework {1} - Experimental build: {2}", Program.GetCurrentVersionTostring(), Utilities.GetNETFramework(), Program.EXPERIMENTAL_BUILD));
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                    File.AppendAllText(ErrorLogFile, Environment.NewLine);
                }

                File.AppendAllText(ErrorLogFile, string.Format("[ERROR] [{0}] in function [{1}]", DateTime.Now.ToString(), functionName));
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, errorMessage);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, errorStackTrace);

                // seperator
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
                File.AppendAllText(ErrorLogFile, Environment.NewLine);
            }
            catch { }
            //finally
            //{
            //    if (!Options.CurrentOptions.DisableOptimizerTelemetry)
            //    {
            //        TelemetryHelper.GenerateTelemetryData(functionName, errorMessage, errorStackTrace);
            //    }
            //}
        }
    }
}
