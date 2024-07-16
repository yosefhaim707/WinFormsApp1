namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Show = new Button();
            dataGridView_Show = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Show).BeginInit();
            SuspendLayout();
            // 
            // button_Show
            // 
            button_Show.Location = new Point(58, 353);
            button_Show.Name = "button_Show";
            button_Show.Size = new Size(161, 56);
            button_Show.TabIndex = 1;
            button_Show.Text = "Show";
            button_Show.UseVisualStyleBackColor = true;
            button_Show.Click += button_Show_Click;
            // 
            // dataGridView_Show
            // 
            dataGridView_Show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Show.Location = new Point(58, 32);
            dataGridView_Show.Name = "dataGridView_Show";
            dataGridView_Show.RowHeadersWidth = 62;
            dataGridView_Show.Size = new Size(480, 273);
            dataGridView_Show.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView_Show);
            Controls.Add(button_Show);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Show).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_Show;
        private DataGridView dataGridView_Show;
    }
}
