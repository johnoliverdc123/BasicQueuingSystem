namespace BasicQueuingSystem
{
    partial class ServingQueueForm
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
            this.components = new System.ComponentModel.Container();
            this.lblServingQueue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblServingQueue
            // 
            this.lblServingQueue.AutoSize = true;
            this.lblServingQueue.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingQueue.ForeColor = System.Drawing.Color.Black;
            this.lblServingQueue.Location = new System.Drawing.Point(54, 78);
            this.lblServingQueue.Name = "lblServingQueue";
            this.lblServingQueue.Size = new System.Drawing.Size(210, 55);
            this.lblServingQueue.TabIndex = 5;
            this.lblServingQueue.Text = "P - 10000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "*Now Serving";
            // 
            // timer1
            // 
            // 
            // ServingQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 181);
            this.Controls.Add(this.lblServingQueue);
            this.Controls.Add(this.label2);
            this.Name = "ServingQueueForm";
            this.Text = "ServingQueueForm";
            this.Load += new System.EventHandler(this.ServingQueueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblServingQueue;
        private System.Windows.Forms.Timer timer1;
    }
}