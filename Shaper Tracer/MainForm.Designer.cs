namespace Shaper_Tracer
{
    partial class MainForm
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
            this.DrawPanel = new System.Windows.Forms.Panel();
            this.ShapeSelectPanel = new System.Windows.Forms.Panel();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.ClearCanvasButton = new System.Windows.Forms.Button();
            this.OptionsPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DrawPanel.Location = new System.Drawing.Point(342, 174);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(610, 377);
            this.DrawPanel.TabIndex = 0;
            this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanel_MouseMove);
            // 
            // ShapeSelectPanel
            // 
            this.ShapeSelectPanel.Location = new System.Drawing.Point(342, 12);
            this.ShapeSelectPanel.Name = "ShapeSelectPanel";
            this.ShapeSelectPanel.Size = new System.Drawing.Size(615, 156);
            this.ShapeSelectPanel.TabIndex = 1;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.ClearCanvasButton);
            this.OptionsPanel.Controls.Add(this.RunButton);
            this.OptionsPanel.Location = new System.Drawing.Point(12, 174);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(324, 377);
            this.OptionsPanel.TabIndex = 2;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.Location = new System.Drawing.Point(12, 12);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(324, 156);
            this.TitlePanel.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(76, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(172, 29);
            this.Title.TabIndex = 0;
            this.Title.Text = "Shape Tracer";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(114, 74);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 0;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearCanvasButton
            // 
            this.ClearCanvasButton.Location = new System.Drawing.Point(114, 103);
            this.ClearCanvasButton.Name = "ClearCanvasButton";
            this.ClearCanvasButton.Size = new System.Drawing.Size(75, 23);
            this.ClearCanvasButton.TabIndex = 1;
            this.ClearCanvasButton.Text = "Clear";
            this.ClearCanvasButton.UseVisualStyleBackColor = true;
            this.ClearCanvasButton.Click += new System.EventHandler(this.ClearCanvasButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 563);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.OptionsPanel);
            this.Controls.Add(this.ShapeSelectPanel);
            this.Controls.Add(this.DrawPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.OptionsPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DrawPanel;
        private System.Windows.Forms.Panel ShapeSelectPanel;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ClearCanvasButton;
    }
}

