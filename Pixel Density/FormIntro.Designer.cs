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
            this.grpMoniInfo = new System.Windows.Forms.GroupBox();
            this.lblMoniDiagonal = new System.Windows.Forms.Label();
            this.lblMoniResY = new System.Windows.Forms.Label();
            this.lblMoniResX = new System.Windows.Forms.Label();
            this.lblMoniPPI = new System.Windows.Forms.Label();
            this.lblMoniHeight = new System.Windows.Forms.Label();
            this.lblMoniWidth = new System.Windows.Forms.Label();
            this.grpMoniInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.Location = new System.Drawing.Point(12, 9);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(776, 507);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = resources.GetString("lblIntro.Text");
            // 
            // btnLoadGridForm
            // 
            this.btnLoadGridForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadGridForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadGridForm.Location = new System.Drawing.Point(12, 520);
            this.btnLoadGridForm.Name = "btnLoadGridForm";
            this.btnLoadGridForm.Size = new System.Drawing.Size(771, 36);
            this.btnLoadGridForm.TabIndex = 1;
            this.btnLoadGridForm.Text = "DRAW THEM SQUAREZZZZ";
            this.btnLoadGridForm.UseVisualStyleBackColor = true;
            this.btnLoadGridForm.Click += new System.EventHandler(this.btnLoadGridForm_Click);
            // 
            // grpMoniInfo
            // 
            this.grpMoniInfo.Controls.Add(this.lblMoniDiagonal);
            this.grpMoniInfo.Controls.Add(this.lblMoniResY);
            this.grpMoniInfo.Controls.Add(this.lblMoniResX);
            this.grpMoniInfo.Controls.Add(this.lblMoniPPI);
            this.grpMoniInfo.Controls.Add(this.lblMoniHeight);
            this.grpMoniInfo.Controls.Add(this.lblMoniWidth);
            this.grpMoniInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMoniInfo.Location = new System.Drawing.Point(794, 12);
            this.grpMoniInfo.Name = "grpMoniInfo";
            this.grpMoniInfo.Size = new System.Drawing.Size(261, 152);
            this.grpMoniInfo.TabIndex = 3;
            this.grpMoniInfo.TabStop = false;
            this.grpMoniInfo.Text = "Current Monitor Information";
            // 
            // lblMoniDiagonal
            // 
            this.lblMoniDiagonal.AutoSize = true;
            this.lblMoniDiagonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoniDiagonal.Location = new System.Drawing.Point(6, 62);
            this.lblMoniDiagonal.Name = "lblMoniDiagonal";
            this.lblMoniDiagonal.Size = new System.Drawing.Size(186, 20);
            this.lblMoniDiagonal.TabIndex = 4;
            this.lblMoniDiagonal.Text = "Physical Diagonal (in):";
            // 
            // lblMoniResY
            // 
            this.lblMoniResY.AutoSize = true;
            this.lblMoniResY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoniResY.Location = new System.Drawing.Point(6, 102);
            this.lblMoniResY.Name = "lblMoniResY";
            this.lblMoniResY.Size = new System.Drawing.Size(247, 20);
            this.lblMoniResY.TabIndex = 3;
            this.lblMoniResY.Text = "Resolution Height (px): {resY}";
            // 
            // lblMoniResX
            // 
            this.lblMoniResX.AutoSize = true;
            this.lblMoniResX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoniResX.Location = new System.Drawing.Point(6, 82);
            this.lblMoniResX.Name = "lblMoniResX";
            this.lblMoniResX.Size = new System.Drawing.Size(240, 20);
            this.lblMoniResX.TabIndex = 3;
            this.lblMoniResX.Text = "Resolution Width (px): {resX}";
            // 
            // lblMoniPPI
            // 
            this.lblMoniPPI.AutoSize = true;
            this.lblMoniPPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoniPPI.Location = new System.Drawing.Point(6, 122);
            this.lblMoniPPI.Name = "lblMoniPPI";
            this.lblMoniPPI.Size = new System.Drawing.Size(156, 20);
            this.lblMoniPPI.TabIndex = 2;
            this.lblMoniPPI.Text = "Density (ppi): {ppi}";
            // 
            // lblMoniHeight
            // 
            this.lblMoniHeight.AutoSize = true;
            this.lblMoniHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoniHeight.Location = new System.Drawing.Point(6, 42);
            this.lblMoniHeight.Name = "lblMoniHeight";
            this.lblMoniHeight.Size = new System.Drawing.Size(168, 20);
            this.lblMoniHeight.TabIndex = 1;
            this.lblMoniHeight.Text = "Physical Height (in):";
            // 
            // lblMoniWidth
            // 
            this.lblMoniWidth.AutoSize = true;
            this.lblMoniWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoniWidth.Location = new System.Drawing.Point(6, 22);
            this.lblMoniWidth.Name = "lblMoniWidth";
            this.lblMoniWidth.Size = new System.Drawing.Size(161, 20);
            this.lblMoniWidth.TabIndex = 0;
            this.lblMoniWidth.Text = "Physical Width (in):";
            // 
            // FormIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 568);
            this.Controls.Add(this.grpMoniInfo);
            this.Controls.Add(this.btnLoadGridForm);
            this.Controls.Add(this.lblIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIntro";
            this.Text = "Pixel Density Intro";
            this.Load += new System.EventHandler(this.FormIntro_Load);
            this.Move += new System.EventHandler(this.DisplayMonitorInfo);
            this.grpMoniInfo.ResumeLayout(false);
            this.grpMoniInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Button btnLoadGridForm;
        private System.Windows.Forms.GroupBox grpMoniInfo;
        private System.Windows.Forms.Label lblMoniHeight;
        private System.Windows.Forms.Label lblMoniWidth;
        private System.Windows.Forms.Label lblMoniPPI;
        private System.Windows.Forms.Label lblMoniResY;
        private System.Windows.Forms.Label lblMoniResX;
        private System.Windows.Forms.Label lblMoniDiagonal;
    }
}

