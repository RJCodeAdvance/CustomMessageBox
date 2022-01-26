using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class Form1 : Form
    {
        //More Inf. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-6.0

        public Form1()
        {
            InitializeComponent();
        }

        //-> Text-Only Message Box
        private void btnMsgText_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            //It is optional to save the Dialog Result,
            //use it when you need to know which button or action the user selected,
            //and do a specific function/task according to the dialogue result.
            //-| For Example:
            DialogResult result = RJMessageBox.Show("This is an example of a Text-Only Message Box.");
            if (result == DialogResult.OK)
                labelDialogResult.Text = "You have selected the OK BUTTON";
            else labelDialogResult.Text = "You have selected CANCEL";

            //Many times we only need to display a message box, without the need to retrieve the button or action selected by the user.
            //-| For Example:
            //RJMessageBox.Show("This is an example of a Text-Only Message Box.");
        }

        //-> Text + Caption Message Box
        private void btnMsgTextCaption1_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";

            DialogResult result = RJMessageBox.Show("This is an example of a Text + Caption Message Box.",
                "Important Message");
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgTextCaption2_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\n\nWhy do we use it?\n\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                "System: Save Changes");
            labelDialogResult.Text = result.ToString() + " Selected";
        }

        //-> Buttons Message Box
        private void btnMsgOk_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an OK Button Message Box.",
                "OK Button",
                MessageBoxButtons.OK);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgOkCancel_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an OK, Cancel Button Message Box.",
                "OK-Cancel Button",
                MessageBoxButtons.OKCancel);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgAbortRetryIgnore_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Abort, Retry, Ignore Button Message Box.",
               "Abort-Retry-Ignore Button",
               MessageBoxButtons.AbortRetryIgnore);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgYesNo_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Yes, No Button Message Box.",
                "Yes-No Button",
                MessageBoxButtons.YesNo);
            labelDialogResult.Text = result.ToString() +" Selected";
        }
        private void btnMsgYesNoCancel_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Yes, No, Cancel Button Message Box.",
                "Yes-No-Cancel Button",
                MessageBoxButtons.YesNoCancel);
            labelDialogResult.Text = result.ToString() +" Selected";
        }
        private void btnMsgRetryCancel_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Retry, Cancel Button Message Box.",
               "Retry-Cancel Button",
               MessageBoxButtons.RetryCancel);
            labelDialogResult.Text = result.ToString() + " Selected";
        }

        //-> Icons Message Box
        private void btnMsgQuestion_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Question Icon Message Box.",
              "Question Icon",
              MessageBoxButtons.OKCancel,
              MessageBoxIcon.Question);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgWarning_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Warning-Exclamation Icon Message Box.",
              "Warning-Exclamation Icon",
              MessageBoxButtons.YesNoCancel,
              MessageBoxIcon.Warning);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgError_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Error-Stop Icon Message Box.",
                "Error-Stop Icon",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Error);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgInformation_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of an Information Icon Message Box.",
                "Information Icon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            labelDialogResult.Text = result.ToString() + " Selected";
        }

        //-> Default Button
        private void btnMsgButton1_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of a Message Box that sets Button1 as the Default Selected Button.\nThat is, pressing the Enter Key selects the Button1.",
             "Warning-Exclamation Icon",
             MessageBoxButtons.YesNoCancel,
             MessageBoxIcon.Warning,
             MessageBoxDefaultButton.Button1);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgButton2_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of a Message Box that sets Button2 as the Default Selected Button.\nThat is, pressing the Enter Key selects the Button2.",
             "Warning-Exclamation Icon",
             MessageBoxButtons.RetryCancel,
             MessageBoxIcon.Information,
             MessageBoxDefaultButton.Button2);
            labelDialogResult.Text = result.ToString() + " Selected";
        }
        private void btnMsgButton3_Click(object sender, EventArgs e)
        {
            labelDialogResult.Text = "Dialog Box Result";
            var result = RJMessageBox.Show("This is an example of a Message Box that sets Button3 as the Default Selected Button.\nThat is, pressing the Enter Key selects the Button3.",
           "Warning-Exclamation Icon",
           MessageBoxButtons.AbortRetryIgnore,
           MessageBoxIcon.Error,
           MessageBoxDefaultButton.Button3);
            labelDialogResult.Text = result.ToString()+" Selected";
        }

        //Set Owner Object
        private void Any()
        {
            //-| IWin32Window owner:
            //Displays a message box in front of the specified object and with the other specified parameters.           
            RJMessageBox.Show(this, "Text");
            RJMessageBox.Show(this, "Text", "Caption");
            RJMessageBox.Show(this, "Text", "Caption", MessageBoxButtons.OKCancel);
            //Etc
        }
    }
}
