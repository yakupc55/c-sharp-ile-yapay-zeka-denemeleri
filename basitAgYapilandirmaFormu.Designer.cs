namespace yapayzekadenemeleri1
{
    partial class basitAgYapilandirmaFormu
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
            this.btnSnapsisDegerDegistir = new System.Windows.Forms.Button();
            this.tbSnapsisMaxDeger = new System.Windows.Forms.TextBox();
            this.tbSnapsisMinDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSnapsisDegerDegistir
            // 
            this.btnSnapsisDegerDegistir.Location = new System.Drawing.Point(105, 62);
            this.btnSnapsisDegerDegistir.Name = "btnSnapsisDegerDegistir";
            this.btnSnapsisDegerDegistir.Size = new System.Drawing.Size(75, 23);
            this.btnSnapsisDegerDegistir.TabIndex = 18;
            this.btnSnapsisDegerDegistir.Text = "degistir";
            this.btnSnapsisDegerDegistir.UseVisualStyleBackColor = true;
            this.btnSnapsisDegerDegistir.Click += new System.EventHandler(this.btnSnapsisDegerDegistir_Click);
            // 
            // tbSnapsisMaxDeger
            // 
            this.tbSnapsisMaxDeger.Location = new System.Drawing.Point(105, 36);
            this.tbSnapsisMaxDeger.Name = "tbSnapsisMaxDeger";
            this.tbSnapsisMaxDeger.Size = new System.Drawing.Size(100, 20);
            this.tbSnapsisMaxDeger.TabIndex = 17;
            // 
            // tbSnapsisMinDeger
            // 
            this.tbSnapsisMinDeger.Location = new System.Drawing.Point(105, 16);
            this.tbSnapsisMinDeger.Name = "tbSnapsisMinDeger";
            this.tbSnapsisMinDeger.Size = new System.Drawing.Size(100, 20);
            this.tbSnapsisMinDeger.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "max değer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "min değer :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSnapsisDegerDegistir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbSnapsisMaxDeger);
            this.groupBox1.Controls.Add(this.tbSnapsisMinDeger);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "snapsis ilk aralık";
            // 
            // basitAgYapilandirmaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 282);
            this.Controls.Add(this.groupBox1);
            this.Name = "basitAgYapilandirmaFormu";
            this.Text = "basit Ag Yapilandirma Formu";
            this.Load += new System.EventHandler(this.basitAgYapilandirmaFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSnapsisDegerDegistir;
        private System.Windows.Forms.TextBox tbSnapsisMaxDeger;
        private System.Windows.Forms.TextBox tbSnapsisMinDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}