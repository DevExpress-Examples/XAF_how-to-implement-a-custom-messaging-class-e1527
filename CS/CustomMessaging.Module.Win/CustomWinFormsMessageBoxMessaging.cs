using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win.Core;

namespace CustomMessaging.Module.Win {
    class CustomWinFormsMessageBoxMessaging : Messaging {
        public CustomWinFormsMessageBoxMessaging(XafApplication application)
            : base(application) { }
        public override DialogResult Show(
            string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {
            DialogResult result = MessageBox.Show(message, caption, buttons, icon);
            OnConfirmationDialogClosed(result);
            return result;
        }
    }
}
