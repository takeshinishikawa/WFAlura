namespace CursoWindowsForms
{
    partial class Frm_HelloWorld_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.Lbl_ModificaTexto = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(23, 87);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(401, 23);
            this.Txt_ConteudoLabel.TabIndex = 6;
            // 
            // Lbl_ModificaTexto
            // 
            this.Lbl_ModificaTexto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ModificaTexto.Location = new System.Drawing.Point(23, 54);
            this.Lbl_ModificaTexto.Name = "Lbl_ModificaTexto";
            this.Lbl_ModificaTexto.Size = new System.Drawing.Size(203, 23);
            this.Lbl_ModificaTexto.TabIndex = 5;
            this.Lbl_ModificaTexto.Text = "Alterar Título";
            this.Lbl_ModificaTexto.UseVisualStyleBackColor = true;
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titulo.Location = new System.Drawing.Point(23, 25);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(257, 22);
            this.Lbl_Titulo.TabIndex = 4;
            this.Lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Frm_HelloWorld_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Lbl_ModificaTexto);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_HelloWorld_UC";
            this.Size = new System.Drawing.Size(450, 276);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Txt_ConteudoLabel;
        private Button Lbl_ModificaTexto;
        private Label Lbl_Titulo;
    }
}
