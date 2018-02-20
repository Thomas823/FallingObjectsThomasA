﻿namespace FallingObjectsThomasA
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
            this.lblInputPrompt = new System.Windows.Forms.Label();
            this.txtAnswerInput = new System.Windows.Forms.TextBox();
            this.lblAnswerPrompt = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculateAnswer = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputPrompt
            // 
            this.lblInputPrompt.AutoSize = true;
            this.lblInputPrompt.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPrompt.Location = new System.Drawing.Point(0, 78);
            this.lblInputPrompt.Name = "lblInputPrompt";
            this.lblInputPrompt.Size = new System.Drawing.Size(549, 45);
            this.lblInputPrompt.TabIndex = 0;
            this.lblInputPrompt.Text = "Enter how much time (Seconds) has passed since the object was released:";
            // 
            // txtAnswerInput
            // 
            this.txtAnswerInput.Location = new System.Drawing.Point(555, 93);
            this.txtAnswerInput.Name = "txtAnswerInput";
            this.txtAnswerInput.Size = new System.Drawing.Size(100, 20);
            this.txtAnswerInput.TabIndex = 1;
            // 
            // lblAnswerPrompt
            // 
            this.lblAnswerPrompt.AutoSize = true;
            this.lblAnswerPrompt.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerPrompt.Location = new System.Drawing.Point(26, 230);
            this.lblAnswerPrompt.Name = "lblAnswerPrompt";
            this.lblAnswerPrompt.Size = new System.Drawing.Size(344, 45);
            this.lblAnswerPrompt.TabIndex = 2;
            this.lblAnswerPrompt.Text = "The height of the object above the ground is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(380, 241);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 22);
            this.lblAnswer.TabIndex = 3;
            // 
            // btnCalculateAnswer
            // 
            this.btnCalculateAnswer.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateAnswer.Location = new System.Drawing.Point(249, 144);
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
            this.lblTitle.Font = new System.Drawing.Font("Monotxt_IV50", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(327, 26);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Where Is Your Object?";
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 316);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalculateAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerPrompt);
            this.Controls.Add(this.txtAnswerInput);
            this.Controls.Add(this.lblInputPrompt);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputPrompt;
        private System.Windows.Forms.TextBox txtAnswerInput;
        private System.Windows.Forms.Label lblAnswerPrompt;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculateAnswer;
        private System.Windows.Forms.Label lblTitle;
    }
}

