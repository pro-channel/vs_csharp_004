namespace vs_Csharp_004
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonControl = new System.Windows.Forms.Button();
            this.checkBoxControl = new System.Windows.Forms.CheckBox();
            this.labelControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonControl
            // 
            this.buttonControl.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonControl.Location = new System.Drawing.Point(57, 80);
            this.buttonControl.Name = "buttonControl";
            this.buttonControl.Size = new System.Drawing.Size(95, 40);
            this.buttonControl.TabIndex = 0;
            this.buttonControl.Text = "確 認";
            this.buttonControl.UseVisualStyleBackColor = true;
            this.buttonControl.Click += new System.EventHandler(this.buttonControl_Click);
            // 
            // checkBoxControl
            // 
            this.checkBoxControl.AutoSize = true;
            this.checkBoxControl.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxControl.Location = new System.Drawing.Point(222, 93);
            this.checkBoxControl.Name = "checkBoxControl";
            this.checkBoxControl.Size = new System.Drawing.Size(15, 14);
            this.checkBoxControl.TabIndex = 1;
            this.checkBoxControl.UseVisualStyleBackColor = true;
            // 
            // labelControl
            // 
            this.labelControl.AutoSize = true;
            this.labelControl.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelControl.Location = new System.Drawing.Point(177, 169);
            this.labelControl.Name = "labelControl";
            this.labelControl.Size = new System.Drawing.Size(0, 20);
            this.labelControl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.checkBoxControl);
            this.Controls.Add(this.buttonControl);
            this.Name = "Form1";
            this.Text = "if文学習";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonControl;
        private System.Windows.Forms.CheckBox checkBoxControl;
        private System.Windows.Forms.Label labelControl;
    }
}

