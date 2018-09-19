namespace _2_7AutoScore
{
    partial class autoScore
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelA = new System.Windows.Forms.Label();
            this.labelOp = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnJudge = new System.Windows.Forms.Button();
            this.listDisp = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(125, 75);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(41, 12);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a";
            // 
            // labelOp
            // 
            this.labelOp.AutoSize = true;
            this.labelOp.Location = new System.Drawing.Point(200, 75);
            this.labelOp.Name = "labelOp";
            this.labelOp.Size = new System.Drawing.Size(41, 12);
            this.labelOp.TabIndex = 1;
            this.labelOp.Text = "+";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(281, 75);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(41, 12);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(369, 75);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(41, 12);
            this.labelE.TabIndex = 3;
            this.labelE.Text = "=";
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(461, 72);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(100, 21);
            this.textAnswer.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(168, 141);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(131, 46);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "出题";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnJudge
            // 
            this.btnJudge.Location = new System.Drawing.Point(371, 141);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(131, 46);
            this.btnJudge.TabIndex = 6;
            this.btnJudge.Text = "判断";
            this.btnJudge.UseVisualStyleBackColor = true;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // listDisp
            // 
            this.listDisp.Location = new System.Drawing.Point(127, 223);
            this.listDisp.Name = "listDisp";
            this.listDisp.Size = new System.Drawing.Size(434, 137);
            this.listDisp.TabIndex = 5;
            this.listDisp.UseCompatibleStateImageBehavior = false;
            // 
            // autoScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listDisp);
            this.Controls.Add(this.btnJudge);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelOp);
            this.Controls.Add(this.labelA);
            this.Name = "autoScore";
            this.Text = "autoScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelOp;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.ListView listDisp;
    }
}

