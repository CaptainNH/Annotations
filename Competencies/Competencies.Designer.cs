
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
            this.SuspendLayout();
            // 
            // saveFileDialogSaveFile
            // 
            this.saveFileDialogSaveFile.Filter = "Word|.doc|Word|.docx";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(21, 149);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(107, 37);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Сохранить";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите файл";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(21, 46);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(107, 37);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialogSelectFile
            // 
            this.openFileDialogSelectFile.Filter = "Excel|*.xls|Excel|*.xlsx";
            // 
            // labelNameOfWorkPlanFile
            // 
            this.labelNameOfWorkPlanFile.AutoSize = true;
            this.labelNameOfWorkPlanFile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfWorkPlanFile.Location = new System.Drawing.Point(136, 50);
            this.labelNameOfWorkPlanFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameOfWorkPlanFile.Name = "labelNameOfWorkPlanFile";
            this.labelNameOfWorkPlanFile.Size = new System.Drawing.Size(146, 24);
            this.labelNameOfWorkPlanFile.TabIndex = 7;
            this.labelNameOfWorkPlanFile.Text = "Файл не выбран";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Выберите место куда хотите сохранить документы";
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoading.Location = new System.Drawing.Point(16, 201);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(98, 24);
            this.labelLoading.TabIndex = 9;
            this.labelLoading.Text = "Ожидание ";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(21, 229);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(767, 28);
            this.progressBar1.TabIndex = 10;
            // 
            // labelNameOfDevelopersFile
            // 
            this.labelNameOfDevelopersFile.AutoSize = true;
            this.labelNameOfDevelopersFile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfDevelopersFile.Location = new System.Drawing.Point(492, 50);
            this.labelNameOfDevelopersFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameOfDevelopersFile.Name = "labelNameOfDevelopersFile";
            this.labelNameOfDevelopersFile.Size = new System.Drawing.Size(146, 24);
            this.labelNameOfDevelopersFile.TabIndex = 11;
            this.labelNameOfDevelopersFile.Text = "Файл не выбран";
            this.labelNameOfDevelopersFile.Visible = false;
            // 
            // buttonOpenDevelopersFile
            // 
            this.buttonOpenDevelopersFile.Location = new System.Drawing.Point(377, 46);
            this.buttonOpenDevelopersFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenDevelopersFile.Name = "buttonOpenDevelopersFile";
            this.buttonOpenDevelopersFile.Size = new System.Drawing.Size(107, 37);
            this.buttonOpenDevelopersFile.TabIndex = 12;
            this.buttonOpenDevelopersFile.Text = "Открыть";
            this.buttonOpenDevelopersFile.UseVisualStyleBackColor = true;
            this.buttonOpenDevelopersFile.Visible = false;
            this.buttonOpenDevelopersFile.Click += new System.EventHandler(this.buttonOpenDevelopersFile_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGenerate.Location = new System.Drawing.Point(168, 324);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(455, 65);
            this.buttonGenerate.TabIndex = 13;
            this.buttonGenerate.Text = "Сформировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelNameOfFolder
            // 
            this.labelNameOfFolder.AutoSize = true;
            this.labelNameOfFolder.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameOfFolder.Location = new System.Drawing.Point(136, 153);
            this.labelNameOfFolder.Name = "labelNameOfFolder";
            this.labelNameOfFolder.Size = new System.Drawing.Size(160, 24);
            this.labelNameOfFolder.TabIndex = 14;
            this.labelNameOfFolder.Text = "Папка не выбрана";
            // 
            // Competencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(804, 401);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Competencies";
            this.Text = "Competencies";
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
    }
}