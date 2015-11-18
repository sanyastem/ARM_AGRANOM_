namespace ARM_AGRANOM_
{
    partial class AddPole
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aRM_AGRONOMDataSet = new ARM_AGRANOM_.ARM_AGRONOMDataSet();
            this.naselnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.naselnTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSetTableAdapters.NaselnTableAdapter();
            this.vidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vidTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSetTableAdapters.VidTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poleTableAdapter = new ARM_AGRANOM_.ARM_AGRONOMDataSetTableAdapters.PoleTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naselnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите информацию";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.naselnBindingSource, "Название", true));
            this.comboBox1.DataSource = this.naselnBindingSource;
            this.comboBox1.DisplayMember = "Название";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Название";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(42, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vidBindingSource, "Название", true));
            this.comboBox2.DataSource = this.vidBindingSource;
            this.comboBox2.DisplayMember = "Название";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(42, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "Название";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aRM_AGRONOMDataSet
            // 
            this.aRM_AGRONOMDataSet.DataSetName = "ARM_AGRONOMDataSet";
            this.aRM_AGRONOMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // naselnBindingSource
            // 
            this.naselnBindingSource.DataMember = "Naseln";
            this.naselnBindingSource.DataSource = this.aRM_AGRONOMDataSet;
            // 
            // naselnTableAdapter
            // 
            this.naselnTableAdapter.ClearBeforeFill = true;
            // 
            // vidBindingSource
            // 
            this.vidBindingSource.DataMember = "Vid";
            this.vidBindingSource.DataSource = this.aRM_AGRONOMDataSet;
            // 
            // vidTableAdapter
            // 
            this.vidTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Pole";
            this.bindingSource1.DataSource = this.aRM_AGRONOMDataSet;
            // 
            // poleTableAdapter
            // 
            this.poleTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите размер";
            // 
            // AddPole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(199, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPole";
            this.Text = "Добавление поле";
            this.Load += new System.EventHandler(this.AddPole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aRM_AGRONOMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naselnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private ARM_AGRONOMDataSet aRM_AGRONOMDataSet;
        private System.Windows.Forms.BindingSource naselnBindingSource;
        private ARM_AGRONOMDataSetTableAdapters.NaselnTableAdapter naselnTableAdapter;
        private System.Windows.Forms.BindingSource vidBindingSource;
        private ARM_AGRONOMDataSetTableAdapters.VidTableAdapter vidTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ARM_AGRONOMDataSetTableAdapters.PoleTableAdapter poleTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}