namespace Graph_for_Arduino
{
    partial class FormUART
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
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.cboPorts = new System.Windows.Forms.ComboBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.btnTestConection = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnCloseConnection = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReadUART = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(13, 13);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Read Ports";
            this.btnGetSerialPorts.UseVisualStyleBackColor = true;
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnReadUARTPorts_Click);
            // 
            // cboPorts
            // 
            this.cboPorts.FormattingEnabled = true;
            this.cboPorts.Location = new System.Drawing.Point(202, 15);
            this.cboPorts.Name = "cboPorts";
            this.cboPorts.Size = new System.Drawing.Size(121, 21);
            this.cboPorts.TabIndex = 1;
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Location = new System.Drawing.Point(202, 42);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 2;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(12, 50);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(53, 13);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Baud rate";
            // 
            // btnTestConection
            // 
            this.btnTestConection.Location = new System.Drawing.Point(15, 177);
            this.btnTestConection.Name = "btnTestConection";
            this.btnTestConection.Size = new System.Drawing.Size(87, 23);
            this.btnTestConection.TabIndex = 4;
            this.btnTestConection.Text = "Test conection";
            this.btnTestConection.UseVisualStyleBackColor = true;
            this.btnTestConection.Click += new System.EventHandler(this.btnTestConection_Click);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(188, 187);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(0, 13);
            this.lblConnectionStatus.TabIndex = 5;
            // 
            // btnCloseConnection
            // 
            this.btnCloseConnection.Location = new System.Drawing.Point(12, 424);
            this.btnCloseConnection.Name = "btnCloseConnection";
            this.btnCloseConnection.Size = new System.Drawing.Size(75, 23);
            this.btnCloseConnection.TabIndex = 6;
            this.btnCloseConnection.Text = "Close connection";
            this.btnCloseConnection.UseVisualStyleBackColor = true;
            this.btnCloseConnection.Click += new System.EventHandler(this.btnCloseConnection_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 280);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 126);
            this.textBox1.TabIndex = 7;
            // 
            // btnReadUART
            // 
            this.btnReadUART.Location = new System.Drawing.Point(19, 244);
            this.btnReadUART.Name = "btnReadUART";
            this.btnReadUART.Size = new System.Drawing.Size(75, 23);
            this.btnReadUART.TabIndex = 8;
            this.btnReadUART.Text = "Read";
            this.btnReadUART.UseVisualStyleBackColor = true;
            this.btnReadUART.Click += new System.EventHandler(this.btnReadUART_Click);
            // 
            // FormUART
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 459);
            this.Controls.Add(this.btnReadUART);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCloseConnection);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.btnTestConection);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.cboBaudRate);
            this.Controls.Add(this.cboPorts);
            this.Controls.Add(this.btnGetSerialPorts);
            this.Name = "FormUART";
            this.Text = "UART Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.ComboBox cboPorts;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Button btnTestConection;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnCloseConnection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReadUART;
    }
}