namespace ProjWinform202344073
{
    partial class multibootForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.multibootLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // multibootLbl
            // 
            this.multibootLbl.AutoSize = true;
            this.multibootLbl.BackColor = System.Drawing.Color.Magenta;
            this.multibootLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.multibootLbl.ForeColor = System.Drawing.Color.YellowGreen;
            this.multibootLbl.Location = new System.Drawing.Point(294, 5);
            this.multibootLbl.Name = "multibootLbl";
            this.multibootLbl.Padding = new System.Windows.Forms.Padding(7);
            this.multibootLbl.Size = new System.Drawing.Size(14, 27);
            this.multibootLbl.TabIndex = 0;
            // 
            // multibootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 290);
            this.Controls.Add(this.multibootLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "multibootForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "multibootText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label multibootLbl;
    }
}

