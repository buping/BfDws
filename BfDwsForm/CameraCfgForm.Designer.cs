namespace BfDwsForm
{
    partial class CameraCfgForm
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
            this.ComboBoxCamList = new System.Windows.Forms.ComboBox();
            this.ButtonEnum = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSetParam = new System.Windows.Forms.Button();
            this.buttonGetParam = new System.Windows.Forms.Button();
            this.textBoxFrameRate = new System.Windows.Forms.TextBox();
            this.textBoxGain = new System.Windows.Forms.TextBox();
            this.textBoxExposure = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAlgorithm = new System.Windows.Forms.DataGridView();
            this.ParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCameraCfgConfirm = new System.Windows.Forms.Button();
            this.btnCameraCfgCancel = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlgorithm)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxCamList
            // 
            this.ComboBoxCamList.FormattingEnabled = true;
            this.ComboBoxCamList.Location = new System.Drawing.Point(146, 25);
            this.ComboBoxCamList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboBoxCamList.Name = "ComboBoxCamList";
            this.ComboBoxCamList.Size = new System.Drawing.Size(625, 23);
            this.ComboBoxCamList.TabIndex = 4;
            // 
            // ButtonEnum
            // 
            this.ButtonEnum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ButtonEnum.Location = new System.Drawing.Point(13, 25);
            this.ButtonEnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEnum.Name = "ButtonEnum";
            this.ButtonEnum.Size = new System.Drawing.Size(112, 29);
            this.ButtonEnum.TabIndex = 3;
            this.ButtonEnum.Text = "搜索相机";
            this.ButtonEnum.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSetParam);
            this.groupBox4.Controls.Add(this.buttonGetParam);
            this.groupBox4.Controls.Add(this.textBoxFrameRate);
            this.groupBox4.Controls.Add(this.textBoxGain);
            this.groupBox4.Controls.Add(this.textBoxExposure);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 85);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(711, 162);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "相机参数设置";
            // 
            // buttonSetParam
            // 
            this.buttonSetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSetParam.Location = new System.Drawing.Point(523, 102);
            this.buttonSetParam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSetParam.Name = "buttonSetParam";
            this.buttonSetParam.Size = new System.Drawing.Size(100, 29);
            this.buttonSetParam.TabIndex = 6;
            this.buttonSetParam.Text = "参数设置";
            this.buttonSetParam.UseVisualStyleBackColor = true;
            // 
            // buttonGetParam
            // 
            this.buttonGetParam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonGetParam.Location = new System.Drawing.Point(523, 54);
            this.buttonGetParam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGetParam.Name = "buttonGetParam";
            this.buttonGetParam.Size = new System.Drawing.Size(100, 29);
            this.buttonGetParam.TabIndex = 5;
            this.buttonGetParam.Text = "参数获取";
            this.buttonGetParam.UseVisualStyleBackColor = true;
            // 
            // textBoxFrameRate
            // 
            this.textBoxFrameRate.Location = new System.Drawing.Point(88, 124);
            this.textBoxFrameRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFrameRate.Name = "textBoxFrameRate";
            this.textBoxFrameRate.Size = new System.Drawing.Size(359, 25);
            this.textBoxFrameRate.TabIndex = 0;
            // 
            // textBoxGain
            // 
            this.textBoxGain.Location = new System.Drawing.Point(88, 80);
            this.textBoxGain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGain.Name = "textBoxGain";
            this.textBoxGain.Size = new System.Drawing.Size(359, 25);
            this.textBoxGain.TabIndex = 4;
            // 
            // textBoxExposure
            // 
            this.textBoxExposure.Location = new System.Drawing.Point(88, 32);
            this.textBoxExposure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxExposure.Name = "textBoxExposure";
            this.textBoxExposure.Size = new System.Drawing.Size(359, 25);
            this.textBoxExposure.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(40, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "帧率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "增益";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "曝光";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewAlgorithm);
            this.groupBox3.Location = new System.Drawing.Point(13, 286);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(723, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "算法参数设置";
            // 
            // dataGridViewAlgorithm
            // 
            this.dataGridViewAlgorithm.AllowUserToAddRows = false;
            this.dataGridViewAlgorithm.AllowUserToDeleteRows = false;
            this.dataGridViewAlgorithm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlgorithm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParamName,
            this.ParamValue});
            this.dataGridViewAlgorithm.Location = new System.Drawing.Point(9, 26);
            this.dataGridViewAlgorithm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAlgorithm.Name = "dataGridViewAlgorithm";
            this.dataGridViewAlgorithm.RowHeadersWidth = 51;
            this.dataGridViewAlgorithm.RowTemplate.Height = 23;
            this.dataGridViewAlgorithm.Size = new System.Drawing.Size(705, 230);
            this.dataGridViewAlgorithm.TabIndex = 0;
            // 
            // ParamName
            // 
            this.ParamName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParamName.HeaderText = "ParamName";
            this.ParamName.MinimumWidth = 6;
            this.ParamName.Name = "ParamName";
            this.ParamName.ReadOnly = true;
            // 
            // ParamValue
            // 
            this.ParamValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParamValue.HeaderText = "ParamValue";
            this.ParamValue.MinimumWidth = 6;
            this.ParamValue.Name = "ParamValue";
            // 
            // btnCameraCfgConfirm
            // 
            this.btnCameraCfgConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCameraCfgConfirm.Location = new System.Drawing.Point(111, 591);
            this.btnCameraCfgConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCameraCfgConfirm.Name = "btnCameraCfgConfirm";
            this.btnCameraCfgConfirm.Size = new System.Drawing.Size(112, 29);
            this.btnCameraCfgConfirm.TabIndex = 7;
            this.btnCameraCfgConfirm.Text = "确认";
            this.btnCameraCfgConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCameraCfgCancel
            // 
            this.btnCameraCfgCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCameraCfgCancel.Location = new System.Drawing.Point(388, 591);
            this.btnCameraCfgCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCameraCfgCancel.Name = "btnCameraCfgCancel";
            this.btnCameraCfgCancel.Size = new System.Drawing.Size(112, 29);
            this.btnCameraCfgCancel.TabIndex = 8;
            this.btnCameraCfgCancel.Text = "取消";
            this.btnCameraCfgCancel.UseVisualStyleBackColor = true;
            // 
            // CameraCfgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 670);
            this.Controls.Add(this.btnCameraCfgCancel);
            this.Controls.Add(this.btnCameraCfgConfirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.ComboBoxCamList);
            this.Controls.Add(this.ButtonEnum);
            this.Name = "CameraCfgForm";
            this.Text = "读码相机配置";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlgorithm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxCamList;
        private System.Windows.Forms.Button ButtonEnum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonSetParam;
        private System.Windows.Forms.Button buttonGetParam;
        private System.Windows.Forms.TextBox textBoxFrameRate;
        private System.Windows.Forms.TextBox textBoxGain;
        private System.Windows.Forms.TextBox textBoxExposure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewAlgorithm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParamValue;
        private System.Windows.Forms.Button btnCameraCfgConfirm;
        private System.Windows.Forms.Button btnCameraCfgCancel;
    }
}