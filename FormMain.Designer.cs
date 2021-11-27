
namespace BubbleSort_Visualiser
{
    partial class FormMain
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonNextStep = new System.Windows.Forms.Button();
            this.comboBoxSortOrder = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.labelSort = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelSwap = new System.Windows.Forms.Label();
            this.labelStepsTotal = new System.Windows.Forms.Label();
            this.labelStepsLeft = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panelArray = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.panelButtons.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelArray.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGenerate.BackColor = System.Drawing.Color.Teal;
            this.buttonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.White;
            this.buttonGenerate.Location = new System.Drawing.Point(12, 14);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(143, 60);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate Array";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextStep.BackColor = System.Drawing.Color.Teal;
            this.buttonNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextStep.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextStep.ForeColor = System.Drawing.Color.White;
            this.buttonNextStep.Location = new System.Drawing.Point(627, 14);
            this.buttonNextStep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(143, 60);
            this.buttonNextStep.TabIndex = 1;
            this.buttonNextStep.Text = "Next Step";
            this.buttonNextStep.UseVisualStyleBackColor = false;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
            // 
            // comboBoxSortOrder
            // 
            this.comboBoxSortOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBoxSortOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSortOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxSortOrder.FormattingEnabled = true;
            this.comboBoxSortOrder.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.comboBoxSortOrder.Location = new System.Drawing.Point(355, 34);
            this.comboBoxSortOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSortOrder.Name = "comboBoxSortOrder";
            this.comboBoxSortOrder.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSortOrder.TabIndex = 2;
            this.comboBoxSortOrder.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortType_SelectedIndexChanged);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.labelSort);
            this.panelButtons.Controls.Add(this.buttonGenerate);
            this.panelButtons.Controls.Add(this.buttonNextStep);
            this.panelButtons.Controls.Add(this.comboBoxSortOrder);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 217);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(781, 86);
            this.panelButtons.TabIndex = 3;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(300, 38);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(49, 17);
            this.labelSort.TabIndex = 3;
            this.labelSort.Text = "Order:";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelSwap);
            this.panelMain.Controls.Add(this.labelStepsTotal);
            this.panelMain.Controls.Add(this.labelStepsLeft);
            this.panelMain.Controls.Add(this.panelInfo);
            this.panelMain.Controls.Add(this.panelArray);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(781, 217);
            this.panelMain.TabIndex = 4;
            // 
            // labelSwap
            // 
            this.labelSwap.AutoSize = true;
            this.labelSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSwap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSwap.Location = new System.Drawing.Point(359, 145);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(0, 24);
            this.labelSwap.TabIndex = 8;
            // 
            // labelStepsTotal
            // 
            this.labelStepsTotal.AutoSize = true;
            this.labelStepsTotal.Location = new System.Drawing.Point(126, 150);
            this.labelStepsTotal.Name = "labelStepsTotal";
            this.labelStepsTotal.Size = new System.Drawing.Size(0, 17);
            this.labelStepsTotal.TabIndex = 4;
            // 
            // labelStepsLeft
            // 
            this.labelStepsLeft.Location = new System.Drawing.Point(555, 142);
            this.labelStepsLeft.Name = "labelStepsLeft";
            this.labelStepsLeft.Size = new System.Drawing.Size(102, 33);
            this.labelStepsLeft.TabIndex = 3;
            this.labelStepsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(781, 66);
            this.panelInfo.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.ForeColor = System.Drawing.Color.Black;
            this.labelInfo.Location = new System.Drawing.Point(0, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(781, 66);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Please generate an array using the Generate Array button";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelArray
            // 
            this.panelArray.Controls.Add(this.label7);
            this.panelArray.Controls.Add(this.label6);
            this.panelArray.Controls.Add(this.label5);
            this.panelArray.Controls.Add(this.label4);
            this.panelArray.Controls.Add(this.label3);
            this.panelArray.Controls.Add(this.label2);
            this.panelArray.Controls.Add(this.label1);
            this.panelArray.Controls.Add(this.label0);
            this.panelArray.Location = new System.Drawing.Point(12, 73);
            this.panelArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelArray.Name = "panelArray";
            this.panelArray.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelArray.Size = new System.Drawing.Size(757, 66);
            this.panelArray.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 60);
            this.label7.TabIndex = 7;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 60);
            this.label6.TabIndex = 6;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 60);
            this.label5.TabIndex = 5;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 60);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 60);
            this.label3.TabIndex = 3;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 60);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 60);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label0
            // 
            this.label0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label0.BackColor = System.Drawing.SystemColors.Window;
            this.label0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label0.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(117, 2);
            this.label0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(61, 60);
            this.label0.TabIndex = 0;
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(781, 303);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BubbleSort Visualiser";
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelArray.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonNextStep;
        private System.Windows.Forms.ComboBox comboBoxSortOrder;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelArray;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelStepsTotal;
        private System.Windows.Forms.Label labelStepsLeft;
        private System.Windows.Forms.Label labelSwap;
    }
}

