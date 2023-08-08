namespace Lottery
{
    partial class Lottery
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxmaxvalue = new System.Windows.Forms.TextBox();
            this.txtboxwantednumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncreate = new System.Windows.Forms.Button();
            this.btndraw = new System.Windows.Forms.Button();
            this.btndrawatones = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtboxmaxvalue);
            this.groupBox1.Controls.Add(this.txtboxwantednumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotterysettings";
            // 
            // txtboxmaxvalue
            // 
            this.txtboxmaxvalue.Location = new System.Drawing.Point(107, 48);
            this.txtboxmaxvalue.Name = "txtboxmaxvalue";
            this.txtboxmaxvalue.Size = new System.Drawing.Size(107, 28);
            this.txtboxmaxvalue.TabIndex = 1;
            // 
            // txtboxwantednumber
            // 
            this.txtboxwantednumber.Location = new System.Drawing.Point(218, 104);
            this.txtboxwantednumber.Name = "txtboxwantednumber";
            this.txtboxwantednumber.Size = new System.Drawing.Size(124, 28);
            this.txtboxwantednumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "No of wanted numbers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max value:";
            // 
            // btncreate
            // 
            this.btncreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.Location = new System.Drawing.Point(39, 213);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(368, 38);
            this.btncreate.TabIndex = 2;
            this.btncreate.Text = "Create lottery object";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btndraw
            // 
            this.btndraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndraw.Location = new System.Drawing.Point(39, 272);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(368, 34);
            this.btndraw.TabIndex = 2;
            this.btndraw.Text = "Draw next number";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // btndrawatones
            // 
            this.btndrawatones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndrawatones.Location = new System.Drawing.Point(39, 322);
            this.btndrawatones.Name = "btndrawatones";
            this.btndrawatones.Size = new System.Drawing.Size(368, 37);
            this.btndrawatones.TabIndex = 2;
            this.btndrawatones.Text = "Draw all numbers at ones";
            this.btndrawatones.UseVisualStyleBackColor = true;
            this.btndrawatones.Click += new System.EventHandler(this.btndrawatones_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            " "});
            this.listBox1.Location = new System.Drawing.Point(441, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(232, 356);
            this.listBox1.TabIndex = 3;
            // 
            // Lottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btndrawatones);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lottery";
            this.Text = "Lottery";
            this.Load += new System.EventHandler(this.Lottery_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxmaxvalue;
        private System.Windows.Forms.TextBox txtboxwantednumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Button btndrawatones;
        private System.Windows.Forms.ListBox listBox1;
    }
}

