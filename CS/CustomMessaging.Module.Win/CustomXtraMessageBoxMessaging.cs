using System.Windows.Forms;
using DevExpress.ExpressApp;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.Win.Core;

namespace CustomMessaging.Module.Win {
      public class CustomXtraMessageBoxMessaging : Messaging {
        public CustomXtraMessageBoxMessaging(XafApplication application)
            : base(application) { }
       protected override DialogResult ShowCore(
            string message, string caption, MessageBoxButtons buttons, MessageBoxIcon icon) {            
            return XtraMessageBox.Show(
                message, caption, buttons, icon, MessageBoxDefaultButton.Button2);
        }
    }
}
