namespace Pixel_Density
{
    partial class FormIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntro));
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnLoadGridForm = new System.Windows.Forms.Button();
            this.lblPPI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(12, 9);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(776, 487);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = resources.GetString("lblIntro.Text");
            // 
            // btnLoadGridForm
            // 
            this.btnLoadGridForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadGridForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGridForm.Location = new System.Drawing.Point(17, 498);
            this.btnLoadGridForm.Name = "btnLoadGridForm";
            this.btnLoadGridForm.Size = new System.Drawing.Size(771, 36);
            this.btnLoadGridForm.TabIndex = 1;
            this.btnLoadGridForm.Text = "DRAW THEM SQUAREZZZZ";
            this.btnLoadGridForm.UseVisualStyleBackColor = true;
            this.btnLoadGridForm.Click += new System.EventHandler(this.btnLoadGridForm_Click);
            // 
            // lblPPI
            // 
            this.lblPPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPPI.AutoSize = true;
            this.lblPPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPI.Location = new System.Drawing.Point(12, 538);
            this.lblPPI.Name = "lblPPI";
            this.lblPPI.Size = new System.Drawing.Size(270, 25);
            this.lblPPI.TabIndex = 2;
            this.lblPPI.Text = "Current Monitor\'s PPI: {ppi}";
            // 
            // FormIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 571);
            this.Controls.Add(this.lblPPI);
            this.Controls.Add(this.btnLoadGridForm);
            this.Controls.Add(this.lblIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIntro";
            this.Text = "Pixel Density Intro";
            this.Load += new System.EventHandler(this.FormIntro_Load);
            this.Move += new System.EventHandler(this.FormIntro_Move);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnLoadGridForm;
        private System.Windows.Forms.Label lblPPI;
    }
}

