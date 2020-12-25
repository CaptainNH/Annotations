﻿
namespace Competencies
{
    partial class Competencies
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Competencies));
            this.saveFileDialogSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialogSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.labelNameOfWorkPlanFile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelLoading = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelNameOfDevelopersFile = new System.Windows.Forms.Label();
            this.buttonOpenDevelopersFile = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelNameOfFolder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveFileDialogSaveFile
            // 
            this.saveFileDialogSaveFile.Filter = "Word|.doc|Word|.docx";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(23, 120);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(120, 30);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Выбрать папку";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите рабочий план";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(23, 40);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(80, 30);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialogSelectFile
            // 
            this.openFileDialogSelectFile.Filter = "Excel File(*.xls; *.xlsx;)|*.xls; *.xlsx";
            // 
            // labelNameOfWorkPlanFile
            // 
            this.labelNameOfWorkPlanFile.AutoEllipsis = true;
            this.labelNameOfWorkPlanFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfWorkPlanFile.Location = new System.Drawing.Point(109, 49);
            this.labelNameOfWorkPlanFile.Name = "labelNameOfWorkPlanFile";
            this.labelNameOfWorkPlanFile.Size = new System.Drawing.Size(168, 27);
            this.labelNameOfWorkPlanFile.TabIndex = 7;
            this.labelNameOfWorkPlanFile.Text = "Файл не выбран";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите место куда хотите сохранить документы";
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoading.Location = new System.Drawing.Point(148, 180);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(82, 17);
            this.labelLoading.TabIndex = 9;
            this.labelLoading.Text = "Ожидание ";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(151, 200);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(381, 30);
            this.progressBar1.TabIndex = 10;
            // 
            // labelNameOfDevelopersFile
            // 
            this.labelNameOfDevelopersFile.AutoEllipsis = true;
            this.labelNameOfDevelopersFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfDevelopersFile.Location = new System.Drawing.Point(369, 49);
            this.labelNameOfDevelopersFile.Name = "labelNameOfDevelopersFile";
            this.labelNameOfDevelopersFile.Size = new System.Drawing.Size(163, 27);
            this.labelNameOfDevelopersFile.TabIndex = 11;
            this.labelNameOfDevelopersFile.Text = "Файл не выбран";
            // 
            // buttonOpenDevelopersFile
            // 
            this.buttonOpenDevelopersFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDevelopersFile.Location = new System.Drawing.Point(283, 41);
            this.buttonOpenDevelopersFile.Name = "buttonOpenDevelopersFile";
            this.buttonOpenDevelopersFile.Size = new System.Drawing.Size(80, 30);
            this.buttonOpenDevelopersFile.TabIndex = 12;
            this.buttonOpenDevelopersFile.Text = "Открыть";
            this.buttonOpenDevelopersFile.UseVisualStyleBackColor = true;
            this.buttonOpenDevelopersFile.Click += new System.EventHandler(this.buttonOpenDevelopersFile_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(23, 200);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(120, 30);
            this.buttonGenerate.TabIndex = 13;
            this.buttonGenerate.Text = "Сформировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelNameOfFolder
            // 
            this.labelNameOfFolder.AutoSize = true;
            this.labelNameOfFolder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfFolder.Location = new System.Drawing.Point(148, 128);
            this.labelNameOfFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameOfFolder.Name = "labelNameOfFolder";
            this.labelNameOfFolder.Size = new System.Drawing.Size(113, 15);
            this.labelNameOfFolder.TabIndex = 14;
            this.labelNameOfFolder.Text = "Папка не выбрана";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(280, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Выберите кадровую справку";
            // 
            // Competencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(544, 251);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNameOfFolder);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonOpenDevelopersFile);
            this.Controls.Add(this.labelNameOfDevelopersFile);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNameOfWorkPlanFile);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Competencies";
            this.Text = "Annotations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogSaveFile;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialogSelectFile;
        private System.Windows.Forms.Label labelNameOfWorkPlanFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelNameOfDevelopersFile;
        private System.Windows.Forms.Button buttonOpenDevelopersFile;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelNameOfFolder;
        private System.Windows.Forms.Label label3;
    }
}