using ExileCore.Shared.Interfaces;
using ExileCore.Shared.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUpdateTest
{
    public class AutoUpdateTestSettings : ISettings
    {
        public ToggleNode Enable { get; set; }
    }
}
