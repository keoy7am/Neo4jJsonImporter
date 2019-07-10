namespace Neo4jJsonImporter
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Addr = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_runtimeDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_JsonDir = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lb_Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Addr
            // 
            this.tb_Addr.Font = new System.Drawing.Font("新細明體", 16F);
            this.tb_Addr.Location = new System.Drawing.Point(104, 19);
            this.tb_Addr.Name = "tb_Addr";
            this.tb_Addr.Size = new System.Drawing.Size(622, 33);
            this.tb_Addr.TabIndex = 1;
            this.tb_Addr.Text = "http://127.0.0.1:11006/db/data";
            // 
            // tb_User
            // 
            this.tb_User.Font = new System.Drawing.Font("新細明體", 16F);
            this.tb_User.Location = new System.Drawing.Point(104, 58);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(622, 33);
            this.tb_User.TabIndex = 3;
            this.tb_User.Text = "neo4j";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("新細明體", 16F);
            this.tb_Password.Location = new System.Drawing.Point(104, 97);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(622, 33);
            this.tb_Password.TabIndex = 5;
            this.tb_Password.Text = "123";
            // 
            // tb_runtimeDir
            // 
            this.tb_runtimeDir.Font = new System.Drawing.Font("新細明體", 16F);
            this.tb_runtimeDir.Location = new System.Drawing.Point(104, 136);
            this.tb_runtimeDir.Name = "tb_runtimeDir";
            this.tb_runtimeDir.Size = new System.Drawing.Size(622, 33);
            this.tb_runtimeDir.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Env Dir";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(412, 214);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(314, 193);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "json Dir";
            // 
            // tb_JsonDir
            // 
            this.tb_JsonDir.Font = new System.Drawing.Font("新細明體", 16F);
            this.tb_JsonDir.Location = new System.Drawing.Point(104, 175);
            this.tb_JsonDir.Name = "tb_JsonDir";
            this.tb_JsonDir.Size = new System.Drawing.Size(622, 33);
            this.tb_JsonDir.TabIndex = 13;
            this.tb_JsonDir.Text = "D:\\法院資料\\臺灣澎湖地方法院\\臺灣澎湖地方法院";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(543, 23);
            this.progressBar.TabIndex = 15;
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Font = new System.Drawing.Font("新細明體", 17F);
            this.lb_Count.Location = new System.Drawing.Point(562, 415);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(0, 23);
            this.lb_Count.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_JsonDir);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_runtimeDir);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.tb_Addr);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Neo4j Json Importer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Addr;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_runtimeDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_JsonDir;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lb_Count;
    }
}

