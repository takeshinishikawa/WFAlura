namespace CursoWindowsForms
{
    partial class Frm_HelloWorld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HelloWorld));
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_ModificaTexto = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Location = new System.Drawing.Point(278, 271);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.Btn_Sair.TabIndex = 0;
            this.Btn_Sair.Text = "Fechar a aplicação";
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click_1);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Titulo.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(257, 22);
            this.Lbl_Titulo.TabIndex = 1;
            this.Lbl_Titulo.Text = "Visual Studio .NET Version";
            // 
            // Lbl_ModificaTexto
            // 
            this.Lbl_ModificaTexto.Location = new System.Drawing.Point(13, 42);
            this.Lbl_ModificaTexto.Name = "Lbl_ModificaTexto";
            this.Lbl_ModificaTexto.Size = new System.Drawing.Size(257, 23);
            this.Lbl_ModificaTexto.TabIndex = 2;
            this.Lbl_ModificaTexto.Text = "Alterar Título";
            this.Lbl_ModificaTexto.UseVisualStyleBackColor = true;
            this.Lbl_ModificaTexto.Click += new System.EventHandler(this.Lbl_ModificaTexto_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(13, 75);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(257, 23);
            this.Txt_ConteudoLabel.TabIndex = 3;
            // 
            // Frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 306);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.Lbl_ModificaTexto);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_Sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_HelloWorld";
            this.Text = "Hello World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_Sair;
        private Label Lbl_Titulo;
        private Button Lbl_ModificaTexto;
        private TextBox Txt_ConteudoLabel;
    }
}