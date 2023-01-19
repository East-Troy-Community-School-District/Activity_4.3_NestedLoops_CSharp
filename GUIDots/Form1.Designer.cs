
namespace GUIDots
{
    partial class GUIDotsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberDotsTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.dotsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of dots:";
            // 
            // numberDotsTextBox
            // 
            this.numberDotsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberDotsTextBox.Location = new System.Drawing.Point(226, 30);
            this.numberDotsTextBox.Name = "numberDotsTextBox";
            this.numberDotsTextBox.Size = new System.Drawing.Size(65, 29);
            this.numberDotsTextBox.TabIndex = 1;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayButton.Location = new System.Drawing.Point(116, 75);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(135, 40);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "Display Dots";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // dotsLabel
            // 
            this.dotsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotsLabel.Location = new System.Drawing.Point(31, 133);
            this.dotsLabel.Name = "dotsLabel";
            this.dotsLabel.Size = new System.Drawing.Size(304, 23);
            this.dotsLabel.TabIndex = 3;
            // 
            // GUIDotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 186);
            this.Controls.Add(this.dotsLabel);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.numberDotsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "GUIDotsForm";
            this.Text = "Dots";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberDotsTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label dotsLabel;
    }
}

