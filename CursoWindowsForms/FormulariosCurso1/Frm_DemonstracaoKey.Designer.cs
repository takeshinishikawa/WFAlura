﻿namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.Txt_Msgm = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.Lbl_Maius = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(8, 8);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(100, 23);
            this.Txt_Input.TabIndex = 0;
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // Txt_Msgm
            // 
            this.Txt_Msgm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Msgm.Location = new System.Drawing.Point(8, 40);
            this.Txt_Msgm.Multiline = true;
            this.Txt_Msgm.Name = "Txt_Msgm";
            this.Txt_Msgm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msgm.Size = new System.Drawing.Size(304, 232);
            this.Txt_Msgm.TabIndex = 1;
            this.Txt_Msgm.TabStop = false;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.Location = new System.Drawing.Point(328, 8);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(75, 28);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Minus.AutoSize = true;
            this.Lbl_Minus.Location = new System.Drawing.Point(320, 104);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(43, 15);
            this.Lbl_Minus.TabIndex = 3;
            this.Lbl_Minus.Text = "Minus.";
            // 
            // Lbl_Maius
            // 
            this.Lbl_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Maius.AutoSize = true;
            this.Lbl_Maius.Location = new System.Drawing.Point(320, 56);
            this.Lbl_Maius.Name = "Lbl_Maius";
            this.Lbl_Maius.Size = new System.Drawing.Size(42, 15);
            this.Lbl_Maius.TabIndex = 4;
            this.Lbl_Maius.Text = "Maius.";
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(368, 56);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Upper.TabIndex = 5;
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(368, 104);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Lower.TabIndex = 6;
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.Lbl_Maius);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Txt_Msgm);
            this.Controls.Add(this.Txt_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_Input;
        private TextBox Txt_Msgm;
        private Button Btn_Reset;
        private Label Lbl_Minus;
        private Label Lbl_Maius;
        private Label Lbl_Upper;
        private Label Lbl_Lower;
    }
}