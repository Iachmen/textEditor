﻿namespace TestProject
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
			this.label1 = new System.Windows.Forms.Label();
			this.fldFilePath = new System.Windows.Forms.TextBox();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numericFont = new System.Windows.Forms.NumericUpDown();
			this.fldContent = new System.Windows.Forms.TextBox();
			this.btnSaveFile = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.numericFont)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Выберите файл:";
			// 
			// fldFilePath
			// 
			this.fldFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fldFilePath.Location = new System.Drawing.Point(127, 27);
			this.fldFilePath.Name = "fldFilePath";
			this.fldFilePath.Size = new System.Drawing.Size(208, 20);
			this.fldFilePath.TabIndex = 1;
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectFile.Location = new System.Drawing.Point(52, 75);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
			this.btnSelectFile.TabIndex = 2;
			this.btnSelectFile.Text = "Выбрать";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFile.Location = new System.Drawing.Point(190, 75);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 3;
			this.btnOpenFile.Text = "Открыть";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Шрифт";
			// 
			// numericFont
			// 
			this.numericFont.Location = new System.Drawing.Point(91, 118);
			this.numericFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
			this.numericFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.numericFont.Name = "numericFont";
			this.numericFont.Size = new System.Drawing.Size(120, 20);
			this.numericFont.TabIndex = 5;
			this.numericFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
			// 
			// fldContent
			// 
			this.fldContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fldContent.Location = new System.Drawing.Point(13, 151);
			this.fldContent.Multiline = true;
			this.fldContent.Name = "fldContent";
			this.fldContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.fldContent.Size = new System.Drawing.Size(338, 142);
			this.fldContent.TabIndex = 6;
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveFile.Location = new System.Drawing.Point(276, 298);
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Size = new System.Drawing.Size(75, 24);
			this.btnSaveFile.TabIndex = 8;
			this.btnSaveFile.Text = "Сохранить";
			this.btnSaveFile.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSymbolCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 329);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(363, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(133, 17);
			this.toolStripStatusLabel1.Text = "Количество символов:";
			// 
			// lblSymbolCount
			// 
			this.lblSymbolCount.Name = "lblSymbolCount";
			this.lblSymbolCount.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 351);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnSaveFile);
			this.Controls.Add(this.fldContent);
			this.Controls.Add(this.numericFont);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.fldFilePath);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Тектовый редактор";
			((System.ComponentModel.ISupportInitialize)(this.numericFont)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fldFilePath;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericFont;
		private System.Windows.Forms.TextBox fldContent;
		private System.Windows.Forms.Button btnSaveFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
	}
}

