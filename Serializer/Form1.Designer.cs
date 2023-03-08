namespace Serializer
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
            this.chooseButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // chooseButton
            // 
            this.chooseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chooseButton.Location = new System.Drawing.Point(97, 83);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(505, 146);
            this.chooseButton.TabIndex = 0;
            this.chooseButton.Text = "Выбрать файл";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.openFile);
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settingsButton.Location = new System.Drawing.Point(97, 311);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(505, 146);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Настройки конвертации";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.showSettings);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(97, 547);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(505, 146);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить файл";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveFile);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Serializable files|*.json; *.xml; *.csv; *.xlsx";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.chooseFile);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 815);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.chooseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Сериализатор";
            this.ResumeLayout(false);

        }

        #endregion

        private Button chooseButton;
        private Button settingsButton;
        private Button saveButton;
        private OpenFileDialog openFileDialog;
    }
}