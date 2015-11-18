namespace ARM_AGRANOM_
{
    partial class AddInformation
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.aRM_AGRONOMDataSet = new ARM_AGRANOM_.ARM_AGRONOMDataSet();
            this.poleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poleTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSetTableAdapters.PoleTableAdapter();
            this.kultureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kultureTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSetTableAdapters.KultureTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.osnovnoeTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSetTableAdapters.OsnovnoeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kultureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите информацию";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.poleBindingSource, "Название", true));
            this.comboBox1.DataSource = this.poleBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Название";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kultureBindingSource, "Название", true));
            this.comboBox2.DataSource = this.kultureBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 118);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // aRM_AGRONOMDataSet
            // 
            this.aRM_AGRONOMDataSet.DataSetName = "ARM_AGRONOMDataSet";
            this.aRM_AGRONOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // poleBindingSource
            // 
            this.poleBindingSource.DataMember = "Pole";
            this.poleBindingSource.DataSource = this.aRM_AGRONOMDataSet;
            // 
            // poleTableAdapter
            // 
            this.poleTableAdapter.ClearBeforeFill = true;
            // 
            // kultureBindingSource
            // 
            this.kultureBindingSource.DataMember = "Kulture";
            this.kultureBindingSource.DataSource = this.aRM_AGRONOMDataSet;
            // 
            // kultureTableAdapter
            // 
            this.kultureTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Osnovnoe";
            this.bindingSource1.DataSource = this.aRM_AGRONOMDataSet;
            // 
            // osnovnoeTableAdapter
            // 
            this.osnovnoeTableAdapter.ClearBeforeFill = true;
            // 
            // AddInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(294, 214);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddInformation";
            this.Text = "Добавление информации о посеве";
            this.Load += new System.EventHandler(this.AddInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kultureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private ARM_AGRONOMDataSet aRM_AGRONOMDataSet;
        private System.Windows.Forms.BindingSource poleBindingSource;
        private ARM_AGRONOMDataSetTableAdapters.PoleTableAdapter poleTableAdapter;
        private System.Windows.Forms.BindingSource kultureBindingSource;
        private ARM_AGRONOMDataSetTableAdapters.KultureTableAdapter kultureTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ARM_AGRONOMDataSetTableAdapters.OsnovnoeTableAdapter osnovnoeTableAdapter;
    }
}