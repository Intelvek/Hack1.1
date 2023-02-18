
namespace БД
{
    partial class Form1
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
            this.AddButton = new System.Windows.Forms.Button();
            this.FloorBox = new System.Windows.Forms.TextBox();
            this.GkBox = new System.Windows.Forms.TextBox();
            this.BilderBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.PloshadBox = new System.Windows.Forms.TextBox();
            this.TypeLb = new System.Windows.Forms.Label();
            this.FloorLb = new System.Windows.Forms.Label();
            this.GKLb = new System.Windows.Forms.Label();
            this.BilderName = new System.Windows.Forms.Label();
            this.DataLb = new System.Windows.Forms.Label();
            this.PriceLb = new System.Windows.Forms.Label();
            this.PloshadLb = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DelBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.changeB = new System.Windows.Forms.Button();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.VidBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(713, 324);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // FloorBox
            // 
            this.FloorBox.Location = new System.Drawing.Point(766, 76);
            this.FloorBox.Name = "FloorBox";
            this.FloorBox.Size = new System.Drawing.Size(100, 20);
            this.FloorBox.TabIndex = 3;
            // 
            // GkBox
            // 
            this.GkBox.Location = new System.Drawing.Point(766, 119);
            this.GkBox.Name = "GkBox";
            this.GkBox.Size = new System.Drawing.Size(100, 20);
            this.GkBox.TabIndex = 4;
            // 
            // BilderBox
            // 
            this.BilderBox.Location = new System.Drawing.Point(766, 155);
            this.BilderBox.Name = "BilderBox";
            this.BilderBox.Size = new System.Drawing.Size(100, 20);
            this.BilderBox.TabIndex = 5;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(766, 236);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 7;
            // 
            // PloshadBox
            // 
            this.PloshadBox.Location = new System.Drawing.Point(766, 279);
            this.PloshadBox.Name = "PloshadBox";
            this.PloshadBox.Size = new System.Drawing.Size(100, 20);
            this.PloshadBox.TabIndex = 8;
            // 
            // TypeLb
            // 
            this.TypeLb.AutoSize = true;
            this.TypeLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLb.Location = new System.Drawing.Point(677, 49);
            this.TypeLb.Name = "TypeLb";
            this.TypeLb.Size = new System.Drawing.Size(31, 18);
            this.TypeLb.TabIndex = 9;
            this.TypeLb.Text = "тип";
            // 
            // FloorLb
            // 
            this.FloorLb.AutoSize = true;
            this.FloorLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FloorLb.Location = new System.Drawing.Point(672, 78);
            this.FloorLb.Name = "FloorLb";
            this.FloorLb.Size = new System.Drawing.Size(42, 18);
            this.FloorLb.TabIndex = 10;
            this.FloorLb.Text = "этаж";
            // 
            // GKLb
            // 
            this.GKLb.AutoSize = true;
            this.GKLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GKLb.Location = new System.Drawing.Point(677, 121);
            this.GKLb.Name = "GKLb";
            this.GKLb.Size = new System.Drawing.Size(32, 18);
            this.GKLb.TabIndex = 11;
            this.GKLb.Text = "ЖК";
            // 
            // BilderName
            // 
            this.BilderName.AutoSize = true;
            this.BilderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BilderName.Location = new System.Drawing.Point(667, 157);
            this.BilderName.Name = "BilderName";
            this.BilderName.Size = new System.Drawing.Size(93, 18);
            this.BilderName.TabIndex = 12;
            this.BilderName.Text = "Застройщик";
            // 
            // DataLb
            // 
            this.DataLb.AutoSize = true;
            this.DataLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLb.Location = new System.Drawing.Point(627, 200);
            this.DataLb.Name = "DataLb";
            this.DataLb.Size = new System.Drawing.Size(43, 18);
            this.DataLb.TabIndex = 13;
            this.DataLb.Text = "Дата";
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLb.Location = new System.Drawing.Point(677, 238);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(43, 18);
            this.PriceLb.TabIndex = 14;
            this.PriceLb.Text = "Цена";
            // 
            // PloshadLb
            // 
            this.PloshadLb.AutoSize = true;
            this.PloshadLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PloshadLb.Location = new System.Drawing.Point(677, 281);
            this.PloshadLb.Name = "PloshadLb";
            this.PloshadLb.Size = new System.Drawing.Size(73, 18);
            this.PloshadLb.TabIndex = 15;
            this.PloshadLb.Text = "Площадь";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(680, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(738, 435);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(75, 23);
            this.DelButton.TabIndex = 17;
            this.DelButton.Text = "удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(705, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "№ID";
            // 
            // DelBox
            // 
            this.DelBox.Location = new System.Drawing.Point(745, 382);
            this.DelBox.Name = "DelBox";
            this.DelBox.Size = new System.Drawing.Size(100, 20);
            this.DelBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Площадь";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Цена";
            this.Column7.Name = "Column7";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Дата";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Застройщик";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ЖК";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Этаж";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(609, 424);
            this.dataGridView1.TabIndex = 1;
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(122, 5);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(75, 23);
            this.changeB.TabIndex = 21;
            this.changeB.Text = "изменить";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TypeBox.Location = new System.Drawing.Point(754, 49);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 22;
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // VidBox
            // 
            this.VidBox.FormattingEnabled = true;
            this.VidBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.VidBox.Location = new System.Drawing.Point(754, 12);
            this.VidBox.Name = "VidBox";
            this.VidBox.Size = new System.Drawing.Size(121, 21);
            this.VidBox.TabIndex = 24;
            this.VidBox.TextChanged += new System.EventHandler(this.VidBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(653, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "вид объекта";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Location = new System.Drawing.Point(745, 408);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(644, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "вид объекта";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 470);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VidBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DelBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.PloshadLb);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.DataLb);
            this.Controls.Add(this.BilderName);
            this.Controls.Add(this.GKLb);
            this.Controls.Add(this.FloorLb);
            this.Controls.Add(this.TypeLb);
            this.Controls.Add(this.PloshadBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.BilderBox);
            this.Controls.Add(this.GkBox);
            this.Controls.Add(this.FloorBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox FloorBox;
        private System.Windows.Forms.TextBox GkBox;
        private System.Windows.Forms.TextBox BilderBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox PloshadBox;
        private System.Windows.Forms.Label TypeLb;
        private System.Windows.Forms.Label FloorLb;
        private System.Windows.Forms.Label GKLb;
        private System.Windows.Forms.Label BilderName;
        private System.Windows.Forms.Label DataLb;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.Label PloshadLb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DelBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.ComboBox VidBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

