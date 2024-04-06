using BFMECompetetiveArena_OnlineKitForms;

namespace BfmeOnlineKitFormsExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadButton = new Button();
            unloadButton = new Button();
            onlineMenu = new OnlineMenu();
            SuspendLayout();
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            loadButton.Location = new Point(12, 869);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(75, 23);
            loadButton.TabIndex = 0;
            loadButton.Text = "Load";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += LoadClicked;
            // 
            // unloadButton
            // 
            unloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            unloadButton.Location = new Point(93, 869);
            unloadButton.Name = "unloadButton";
            unloadButton.Size = new Size(75, 23);
            unloadButton.TabIndex = 0;
            unloadButton.Text = "Unload";
            unloadButton.UseVisualStyleBackColor = true;
            unloadButton.Click += UnloadClicked;
            // 
            // onlineMenu
            // 
            onlineMenu.AccessToken = "";
            onlineMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            onlineMenu.Location = new Point(0, 0);
            onlineMenu.Name = "onlineMenu";
            onlineMenu.Size = new Size(1364, 859);
            onlineMenu.TabIndex = 2;
            onlineMenu.UpdateBranch = "main";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 900);
            Controls.Add(onlineMenu);
            Controls.Add(unloadButton);
            Controls.Add(loadButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button loadButton;
        private Button unloadButton;
        private OnlineMenu onlineMenu;
    }
}