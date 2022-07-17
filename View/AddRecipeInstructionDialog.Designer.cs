namespace RecipeBookApp.View
{
    partial class AddRecipeInstructionDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addInstructtionTextBox = new System.Windows.Forms.RichTextBox();
            this.saveInstructionButton = new System.Windows.Forms.Button();
            this.clearInstructionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addInstructtionTextBox
            // 
            this.addInstructtionTextBox.Location = new System.Drawing.Point(3, -1);
            this.addInstructtionTextBox.Name = "addInstructtionTextBox";
            this.addInstructtionTextBox.Size = new System.Drawing.Size(798, 384);
            this.addInstructtionTextBox.TabIndex = 0;
            this.addInstructtionTextBox.Text = "";
            // 
            // saveInstructionButton
            // 
            this.saveInstructionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveInstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveInstructionButton.Location = new System.Drawing.Point(198, 389);
            this.saveInstructionButton.Name = "saveInstructionButton";
            this.saveInstructionButton.Size = new System.Drawing.Size(183, 39);
            this.saveInstructionButton.TabIndex = 1;
            this.saveInstructionButton.Text = "Save And Close";
            this.saveInstructionButton.UseVisualStyleBackColor = true;
            this.saveInstructionButton.Click += new System.EventHandler(this.SaveInstructionButton_Click);
            // 
            // clearInstructionButton
            // 
            this.clearInstructionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearInstructionButton.Location = new System.Drawing.Point(387, 389);
            this.clearInstructionButton.Name = "clearInstructionButton";
            this.clearInstructionButton.Size = new System.Drawing.Size(147, 39);
            this.clearInstructionButton.TabIndex = 2;
            this.clearInstructionButton.Text = "Clear";
            this.clearInstructionButton.UseVisualStyleBackColor = true;
            this.clearInstructionButton.Click += new System.EventHandler(this.ClearInstructionButton_Click);
            // 
            // AddRecipeInstructionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearInstructionButton);
            this.Controls.Add(this.saveInstructionButton);
            this.Controls.Add(this.addInstructtionTextBox);
            this.Name = "AddRecipeInstructionDialog";
            this.Text = "AddRecipeInstructionDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox addInstructtionTextBox;
        private System.Windows.Forms.Button saveInstructionButton;
        private System.Windows.Forms.Button clearInstructionButton;
    }
}