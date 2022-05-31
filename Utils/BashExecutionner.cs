namespace my_website.Utils;

static class BashExecutionner {
        public static void ExecuteCommand(string command) {
                System.Diagnostics.ProcessStartInfo process = new System.Diagnostics.ProcessStartInfo();
                process.UseShellExecute = false;
                process.FileName = "/bin/bash";
                process.Arguments = "-c \" " + command + " \"";
                process.RedirectStandardOutput = true;

                System.Diagnostics.Process cmd =  System.Diagnostics.Process.Start(process);
                // waiting to complete 
                cmd.WaitForExit();
        }
}