using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Core;

namespace CustomMessaging.Module.Win {
    public class CustomWinFormsMessageBoxMessaging : Messaging {
        public CustomWinFormsMessageBoxMessaging(XafApplication application)
            : base(application) { }
        protected override DialogResult ShowCore(
            string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {            
            return MessageBox.Show(message, caption, buttons, icon);
        }
    }
}
