using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.Win.Core;

namespace CustomMessaging.Module.Win {
    class CustomXtraMessageBoxMessaging : Messaging {
        public CustomXtraMessageBoxMessaging(XafApplication application)
            : base(application) { }
        public override DialogResult Show(
            string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {
            DialogResult result = XtraMessageBox.Show(
                message, caption, buttons, icon, MessageBoxDefaultButton.Button2);
            OnConfirmationDialogClosed(result);
            return result;
        }
    }
}
