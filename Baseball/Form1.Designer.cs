namespace Baseball
{
    partial class Form1
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
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnPlayball = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.btnBallFly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(33, 182);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(633, 273);
            this.txtResult.TabIndex = 10;
            this.txtResult.Text = "";
            // 
            // btnPlayball
            // 
            this.btnPlayball.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlayball.Location = new System.Drawing.Point(331, 110);
            this.btnPlayball.Name = "btnPlayball";
            this.btnPlayball.Size = new System.Drawing.Size(149, 35);
            this.btnPlayball.TabIndex = 9;
            this.btnPlayball.Text = "打球";
            this.btnPlayball.UseVisualStyleBackColor = true;
            this.btnPlayball.Click += new System.EventHandler(this.btnPlayball_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDistance.Location = new System.Drawing.Point(191, 110);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 35);
            this.txtDistance.TabIndex = 8;
            // 
            // txtAngle
            // 
            this.txtAngle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAngle.Location = new System.Drawing.Point(191, 62);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 35);
            this.txtAngle.TabIndex = 7;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDistance.Location = new System.Drawing.Point(80, 113);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(54, 27);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "距離";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAngle.Location = new System.Drawing.Point(80, 65);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(54, 27);
            this.lblAngle.TabIndex = 6;
            this.lblAngle.Text = "角度";
            // 
            // btnBallFly
            // 
            this.btnBallFly.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBallFly.Location = new System.Drawing.Point(331, 61);
            this.btnBallFly.Name = "btnBallFly";
            this.btnBallFly.Size = new System.Drawing.Size(149, 35);
            this.btnBallFly.TabIndex = 9;
            this.btnBallFly.Text = "投球";
            this.btnBallFly.UseVisualStyleBackColor = true;
            this.btnBallFly.Click += new System.EventHandler(this.btnBallFly_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 517);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnBallFly);
            this.Controls.Add(this.btnPlayball);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblAngle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnPlayball;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Button btnBallFly;
    }
}