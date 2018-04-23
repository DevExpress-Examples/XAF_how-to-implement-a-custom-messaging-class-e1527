using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace CustomMessaging.Module.Win {
    [ToolboxItemFilter("Xaf.Platform.Win")]
    public sealed partial class CustomMessagingWindowsFormsModule : ModuleBase {
        public CustomMessagingWindowsFormsModule() {
            InitializeComponent();
        }
    }
}
