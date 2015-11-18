namespace ARM_AGRANOM_
{
    partial class AddNaselen
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aRM_AGRONOMDataSet2 = new ARM_AGRANOM_.ARM_AGRONOMDataSet2();
            this.oblastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oblastTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSet2TableAdapters.OblastTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.arM_AGRONOMDataSet1 = new ARM_AGRANOM_.ARM_AGRONOMDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aRM_AGRONOMDataSet11 = new ARM_AGRANOM_.ARM_AGRONOMDataSet1();
            this.naselnTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSet1TableAdapters.NaselnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arM_AGRONOMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите область";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.oblastBindingSource, "Название", true));
            this.comboBox1.DataSource = this.oblastBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(41, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aRM_AGRONOMDataSet2
            // 
            this.aRM_AGRONOMDataSet2.DataSetName = "ARM_AGRONOMDataSet2";
            this.aRM_AGRONOMDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oblastBindingSource
            // 
            this.oblastBindingSource.DataMember = "Oblast";
            this.oblastBindingSource.DataSource = this.aRM_AGRONOMDataSet2;
            // 
            // oblastTableAdapter
            // 
            this.oblastTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите населенный пункт";
            // 
            // arM_AGRONOMDataSet1
            // 
            this.arM_AGRONOMDataSet1.DataSetName = "ARM_AGRONOMDataSet";
            this.arM_AGRONOMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Naseln";
            this.bindingSource1.DataSource = this.aRM_AGRONOMDataSet11;
            // 
            // aRM_AGRONOMDataSet11
            // 
            this.aRM_AGRONOMDataSet11.DataSetName = "ARM_AGRONOMDataSet1";
            this.aRM_AGRONOMDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naselnTableAdapter
            // 
            this.naselnTableAdapter.ClearBeforeFill = true;
            // 
            // AddNaselen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddNaselen";
            this.Text = "Добавление населенного пункта";
            this.Load += new System.EventHandler(this.AddNaselen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oblastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arM_AGRONOMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private ARM_AGRONOMDataSet2 aRM_AGRONOMDataSet2;
        private System.Windows.Forms.BindingSource oblastBindingSource;
        private ARM_AGRONOMDataSet2TableAdapters.OblastTableAdapter oblastTableAdapter;
        private System.Windows.Forms.Label label2;
        private ARM_AGRONOMDataSet arM_AGRONOMDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ARM_AGRONOMDataSet1 aRM_AGRONOMDataSet11;
        private ARM_AGRONOMDataSet1TableAdapters.NaselnTableAdapter naselnTableAdapter;
    }
}