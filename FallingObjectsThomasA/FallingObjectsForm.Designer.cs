namespace FallingObjectsThomasA
{
    partial class frmFallingObjects
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
            this.lblInputPromptTime = new System.Windows.Forms.Label();
            this.txtInputTime = new System.Windows.Forms.TextBox();
            this.lblAnswerPrompt = new System.Windows.Forms.Label();
            this.lblFinalAnswer = new System.Windows.Forms.Label();
            this.btnCalculateAnswer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInputPromptHeight = new System.Windows.Forms.Label();
            this.txtInputHeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInputPromptTime
            // 
            this.lblInputPromptTime.AutoSize = true;
            this.lblInputPromptTime.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPromptTime.Location = new System.Drawing.Point(0, 124);
            this.lblInputPromptTime.Name = "lblInputPromptTime";
            this.lblInputPromptTime.Size = new System.Drawing.Size(549, 45);
            this.lblInputPromptTime.TabIndex = 0;
            this.lblInputPromptTime.Text = "Enter how much time (Seconds) has passed since the object was released:";
            // 
            // txtInputTime
            // 
            this.txtInputTime.Location = new System.Drawing.Point(555, 139);
            this.txtInputTime.Name = "txtInputTime";
            this.txtInputTime.Size = new System.Drawing.Size(100, 20);
            this.txtInputTime.TabIndex = 1;
            // 
            // lblAnswerPrompt
            // 
            this.lblAnswerPrompt.AutoSize = true;
            this.lblAnswerPrompt.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPrompt.Location = new System.Drawing.Point(5, 261);
            this.lblAnswerPrompt.Name = "lblAnswerPrompt";
            this.lblAnswerPrompt.Size = new System.Drawing.Size(344, 45);
            this.lblAnswerPrompt.TabIndex = 2;
            this.lblAnswerPrompt.Text = "The height of the object above the ground is:";
            // 
            // lblFinalAnswer
            // 
            this.lblFinalAnswer.AutoSize = true;
            this.lblFinalAnswer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalAnswer.Location = new System.Drawing.Point(355, 272);
            this.lblFinalAnswer.Name = "lblFinalAnswer";
            this.lblFinalAnswer.Size = new System.Drawing.Size(0, 22);
            this.lblFinalAnswer.TabIndex = 3;
            // 
            // btnCalculateAnswer
            // 
            this.btnCalculateAnswer.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAnswer.Location = new System.Drawing.Point(246, 180);
            this.btnCalculateAnswer.Name = "btnCalculateAnswer";
            this.btnCalculateAnswer.Size = new System.Drawing.Size(131, 66);
            this.btnCalculateAnswer.TabIndex = 4;
            this.btnCalculateAnswer.Text = "Calculate";
            this.btnCalculateAnswer.UseVisualStyleBackColor = true;
            this.btnCalculateAnswer.Click += new System.EventHandler(this.btnCalculateAnswer_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(286, 42);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Where Is Your Object?";
            // 
            // lblInputPromptHeight
            // 
            this.lblInputPromptHeight.AutoSize = true;
            this.lblInputPromptHeight.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPromptHeight.Location = new System.Drawing.Point(5, 79);
            this.lblInputPromptHeight.Name = "lblInputPromptHeight";
            this.lblInputPromptHeight.Size = new System.Drawing.Size(367, 45);
            this.lblInputPromptHeight.TabIndex = 6;
            this.lblInputPromptHeight.Text = "What was the objects original height (Meters) ?";
            // 
            // txtInputHeight
            // 
            this.txtInputHeight.Location = new System.Drawing.Point(378, 94);
            this.txtInputHeight.Name = "txtInputHeight";
            this.txtInputHeight.Size = new System.Drawing.Size(100, 20);
            this.txtInputHeight.TabIndex = 7;
            this.txtInputHeight.Text = "100";
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 316);
            this.Controls.Add(this.txtInputHeight);
            this.Controls.Add(this.lblInputPromptHeight);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalculateAnswer);
            this.Controls.Add(this.lblFinalAnswer);
            this.Controls.Add(this.lblAnswerPrompt);
            this.Controls.Add(this.txtInputTime);
            this.Controls.Add(this.lblInputPromptTime);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputPromptTime;
        private System.Windows.Forms.TextBox txtInputTime;
        private System.Windows.Forms.Label lblAnswerPrompt;
        private System.Windows.Forms.Label lblFinalAnswer;
        private System.Windows.Forms.Button btnCalculateAnswer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInputPromptHeight;
        private System.Windows.Forms.TextBox txtInputHeight;
    }
}

