namespace menucsharp2
{
    partial class Form1menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1menu));
            this.Ordernow = new System.Windows.Forms.Button();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.BASES = new System.Windows.Forms.Label();
            this.PROTEINAS = new System.Windows.Forms.Label();
            this.ADEREZOS = new System.Windows.Forms.Label();
            this.TOPPINGS = new System.Windows.Forms.Label();
            this.CRUJIENTES = new System.Windows.Forms.Label();
            this.ORDERLIST = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox6 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Ordernow
            // 
            this.Ordernow.BackColor = System.Drawing.Color.Pink;
            this.Ordernow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ordernow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Ordernow.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ordernow.ForeColor = System.Drawing.Color.Red;
            this.Ordernow.Location = new System.Drawing.Point(424, 631);
            this.Ordernow.Margin = new System.Windows.Forms.Padding(0);
            this.Ordernow.Name = "Ordernow";
            this.Ordernow.Size = new System.Drawing.Size(124, 84);
            this.Ordernow.TabIndex = 3;
            this.Ordernow.Text = "ORDENAR Y PAGAR";
            this.Ordernow.UseVisualStyleBackColor = false;
            this.Ordernow.Click += new System.EventHandler(this.Ordernow_Click);
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.CheckOnClick = true;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(388, 262);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(144, 94);
            this.checkedListBox3.TabIndex = 6;
            this.checkedListBox3.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox3_ItemCheck);
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkedListBox4.CheckOnClick = true;
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(388, 505);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(150, 94);
            this.checkedListBox4.TabIndex = 7;
            this.checkedListBox4.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox4_ItemCheck);
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.CheckOnClick = true;
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Location = new System.Drawing.Point(93, 505);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(141, 76);
            this.checkedListBox5.TabIndex = 8;
            this.checkedListBox5.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox5_ItemCheck);
            // 
            // BASES
            // 
            this.BASES.AutoSize = true;
            this.BASES.Location = new System.Drawing.Point(135, 205);
            this.BASES.Name = "BASES";
            this.BASES.Size = new System.Drawing.Size(40, 15);
            this.BASES.TabIndex = 9;
            this.BASES.Text = "BASES";
            // 
            // PROTEINAS
            // 
            this.PROTEINAS.AutoSize = true;
            this.PROTEINAS.Location = new System.Drawing.Point(424, 205);
            this.PROTEINAS.Name = "PROTEINAS";
            this.PROTEINAS.Size = new System.Drawing.Size(67, 15);
            this.PROTEINAS.TabIndex = 10;
            this.PROTEINAS.Text = "PROTEINAS";
            // 
            // ADEREZOS
            // 
            this.ADEREZOS.AutoSize = true;
            this.ADEREZOS.Location = new System.Drawing.Point(111, 447);
            this.ADEREZOS.Name = "ADEREZOS";
            this.ADEREZOS.Size = new System.Drawing.Size(64, 15);
            this.ADEREZOS.TabIndex = 11;
            this.ADEREZOS.Text = "ADEREZOS";
            // 
            // TOPPINGS
            // 
            this.TOPPINGS.AutoSize = true;
            this.TOPPINGS.Location = new System.Drawing.Point(766, 205);
            this.TOPPINGS.Name = "TOPPINGS";
            this.TOPPINGS.Size = new System.Drawing.Size(61, 15);
            this.TOPPINGS.TabIndex = 12;
            this.TOPPINGS.Text = "TOPPINGS";
            // 
            // CRUJIENTES
            // 
            this.CRUJIENTES.AutoSize = true;
            this.CRUJIENTES.Location = new System.Drawing.Point(424, 447);
            this.CRUJIENTES.Name = "CRUJIENTES";
            this.CRUJIENTES.Size = new System.Drawing.Size(70, 15);
            this.CRUJIENTES.TabIndex = 13;
            this.CRUJIENTES.Text = "CRUJIENTES";
            // 
            // ORDERLIST
            // 
            this.ORDERLIST.AutoSize = true;
            this.ORDERLIST.Location = new System.Drawing.Point(670, 388);
            this.ORDERLIST.Name = "ORDERLIST";
            this.ORDERLIST.Size = new System.Drawing.Size(131, 15);
            this.ORDERLIST.TabIndex = 15;
            this.ORDERLIST.Text = "DETALLE  DE LA ORDEN";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(93, 262);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(144, 94);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // ListBox1
            // 
            this.ListBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 15;
            this.ListBox1.Location = new System.Drawing.Point(649, 447);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(219, 154);
            this.ListBox1.TabIndex = 17;
            this.ListBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // checkedListBox6
            // 
            this.checkedListBox6.CheckOnClick = true;
            this.checkedListBox6.FormattingEnabled = true;
            this.checkedListBox6.Location = new System.Drawing.Point(705, 262);
            this.checkedListBox6.Name = "checkedListBox6";
            this.checkedListBox6.Size = new System.Drawing.Size(178, 94);
            this.checkedListBox6.TabIndex = 18;
            this.checkedListBox6.SelectedIndexChanged += new System.EventHandler(this.checkedListBox6_SelectedIndexChanged);
            // 
            // Form1menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 734);
            this.Controls.Add(this.checkedListBox6);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.ORDERLIST);
            this.Controls.Add(this.CRUJIENTES);
            this.Controls.Add(this.TOPPINGS);
            this.Controls.Add(this.ADEREZOS);
            this.Controls.Add(this.PROTEINAS);
            this.Controls.Add(this.BASES);
            this.Controls.Add(this.checkedListBox5);
            this.Controls.Add(this.checkedListBox4);
            this.Controls.Add(this.checkedListBox3);
            this.Controls.Add(this.Ordernow);
            this.Name = "Form1menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button Ordernow;
        private Label BASES;
        private Label PROTEINAS;
        private Label ADEREZOS;
        private Label TOPPINGS;
        private Label CRUJIENTES;
        private Label ORDERLIST;
        private ListBox ListBox1;
        public CheckedListBox checkedListBox2;
        public CheckedListBox checkedListBox3;
        public CheckedListBox checkedListBox4;
        public CheckedListBox checkedListBox5;
        private CheckedListBox checkedListBox6;
        public CheckedListBox checkedListBox1;
    }
}