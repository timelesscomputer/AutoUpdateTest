using ExileCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdateTest
{
    public class AutoUpdateTest : BaseSettingsPlugin<AutoUpdateTestSettings>
    {
        public override bool Initialise()
        {
            CheckForFile("Textfile1.txt");
            return true;
        }

        public override void Render()
        {
            CheckForFile("Textfile1.txt");
            CheckForFile(Path.Combine(DirectoryFullName, "Textfile1.txt"));
        }

        private void CheckForFile(string path)
        {
            var exists = File.Exists(path);
            DebugWindow.LogMsg($"{path} -> {exists}");
            if (!exists) return;
            var content = File.ReadAllText(path);
            DebugWindow.LogMsg($"{path} content -> {content}");
        }
    }
}
