namespace 五子棋
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.X_axis = new System.Windows.Forms.Label();
            this.Y_axis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X_CrossPoint = new System.Windows.Forms.Label();
            this.Y_CrossPoint = new System.Windows.Forms.Label();
            this.X_Value = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(433, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "X座標:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(433, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y座標:";
            // 
            // X_axis
            // 
            this.X_axis.AutoSize = true;
            this.X_axis.BackColor = System.Drawing.Color.Transparent;
            this.X_axis.Font = new System.Drawing.Font("新細明體", 15F);
            this.X_axis.Location = new System.Drawing.Point(519, 9);
            this.X_axis.Name = "X_axis";
            this.X_axis.Size = new System.Drawing.Size(27, 20);
            this.X_axis.TabIndex = 2;
            this.X_axis.Text = "__";
            // 
            // Y_axis
            // 
            this.Y_axis.AutoSize = true;
            this.Y_axis.BackColor = System.Drawing.Color.Transparent;
            this.Y_axis.Font = new System.Drawing.Font("新細明體", 15F);
            this.Y_axis.Location = new System.Drawing.Point(519, 40);
            this.Y_axis.Name = "Y_axis";
            this.Y_axis.Size = new System.Drawing.Size(27, 20);
            this.Y_axis.TabIndex = 3;
            this.Y_axis.Text = "__";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(274, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "X軸交叉點:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(274, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y軸交叉點:";
            // 
            // X_CrossPoint
            // 
            this.X_CrossPoint.AutoSize = true;
            this.X_CrossPoint.BackColor = System.Drawing.Color.Transparent;
            this.X_CrossPoint.Font = new System.Drawing.Font("新細明體", 15F);
            this.X_CrossPoint.Location = new System.Drawing.Point(400, 9);
            this.X_CrossPoint.Name = "X_CrossPoint";
            this.X_CrossPoint.Size = new System.Drawing.Size(27, 20);
            this.X_CrossPoint.TabIndex = 6;
            this.X_CrossPoint.Text = "__";
            // 
            // Y_CrossPoint
            // 
            this.Y_CrossPoint.AutoSize = true;
            this.Y_CrossPoint.BackColor = System.Drawing.Color.Transparent;
            this.Y_CrossPoint.Font = new System.Drawing.Font("新細明體", 15F);
            this.Y_CrossPoint.Location = new System.Drawing.Point(400, 40);
            this.Y_CrossPoint.Name = "Y_CrossPoint";
            this.Y_CrossPoint.Size = new System.Drawing.Size(27, 20);
            this.Y_CrossPoint.TabIndex = 7;
            this.Y_CrossPoint.Text = "__";
            // 
            // X_Value
            // 
            this.X_Value.AutoSize = true;
            this.X_Value.BackColor = System.Drawing.Color.Transparent;
            this.X_Value.Font = new System.Drawing.Font("新細明體", 15F);
            this.X_Value.Location = new System.Drawing.Point(167, 9);
            this.X_Value.Name = "X_Value";
            this.X_Value.Size = new System.Drawing.Size(27, 20);
            this.X_Value.TabIndex = 8;
            this.X_Value.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("新細明體", 15F);
            this.label6.Location = new System.Drawing.Point(71, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "X差值:";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("新細明體", 20F);
            this.ResetButton.Location = new System.Drawing.Point(580, 12);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(98, 48);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::五子棋.Properties.Resources.board;
            this.ClientSize = new System.Drawing.Size(731, 647);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.X_Value);
            this.Controls.Add(this.Y_CrossPoint);
            this.Controls.Add(this.X_CrossPoint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y_axis);
            this.Controls.Add(this.X_axis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "五子棋";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label X_axis;
        private System.Windows.Forms.Label Y_axis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label X_CrossPoint;
        private System.Windows.Forms.Label Y_CrossPoint;
        private System.Windows.Forms.Label X_Value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResetButton;
    }
}

