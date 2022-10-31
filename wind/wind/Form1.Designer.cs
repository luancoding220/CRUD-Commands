
namespace wind
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_obs = new System.Windows.Forms.TextBox();
            this.txt_tot = new System.Windows.Forms.NumericUpDown();
            this.txt_max = new System.Windows.Forms.NumericUpDown();
            this.txt_min = new System.Windows.Forms.NumericUpDown();
            this.txt_lote = new System.Windows.Forms.NumericUpDown();
            this.txt_expi_date = new System.Windows.Forms.DateTimePicker();
            this.txt_manu_date = new System.Windows.Forms.DateTimePicker();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_new_document = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.PictureBox();
            this.btn_edit = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.PictureBox();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_search_expi_date = new System.Windows.Forms.PictureBox();
            this.msk_txt_expi_date = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_print_report = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new_document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_expi_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registration";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_obs);
            this.groupBox2.Controls.Add(this.txt_tot);
            this.groupBox2.Controls.Add(this.txt_max);
            this.groupBox2.Controls.Add(this.txt_min);
            this.groupBox2.Controls.Add(this.txt_lote);
            this.groupBox2.Controls.Add(this.txt_expi_date);
            this.groupBox2.Controls.Add(this.txt_manu_date);
            this.groupBox2.Controls.Add(this.txt_desc);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Location = new System.Drawing.Point(196, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 550);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(149, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Obs:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(143, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(112, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Maximum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(115, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minimum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(149, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lot:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(65, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Expiration Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Manufacturing Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // txt_obs
            // 
            this.txt_obs.Location = new System.Drawing.Point(204, 392);
            this.txt_obs.Multiline = true;
            this.txt_obs.Name = "txt_obs";
            this.txt_obs.Size = new System.Drawing.Size(369, 145);
            this.txt_obs.TabIndex = 10;
            // 
            // txt_tot
            // 
            this.txt_tot.Location = new System.Drawing.Point(204, 358);
            this.txt_tot.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_tot.Name = "txt_tot";
            this.txt_tot.Size = new System.Drawing.Size(369, 29);
            this.txt_tot.TabIndex = 9;
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(204, 327);
            this.txt_max.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(369, 29);
            this.txt_max.TabIndex = 8;
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(204, 297);
            this.txt_min.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(369, 29);
            this.txt_min.TabIndex = 7;
            // 
            // txt_lote
            // 
            this.txt_lote.Location = new System.Drawing.Point(204, 266);
            this.txt_lote.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txt_lote.Name = "txt_lote";
            this.txt_lote.Size = new System.Drawing.Size(369, 29);
            this.txt_lote.TabIndex = 6;
            // 
            // txt_expi_date
            // 
            this.txt_expi_date.Location = new System.Drawing.Point(204, 233);
            this.txt_expi_date.Name = "txt_expi_date";
            this.txt_expi_date.Size = new System.Drawing.Size(369, 29);
            this.txt_expi_date.TabIndex = 5;
            // 
            // txt_manu_date
            // 
            this.txt_manu_date.Location = new System.Drawing.Point(204, 198);
            this.txt_manu_date.Name = "txt_manu_date";
            this.txt_manu_date.Size = new System.Drawing.Size(369, 29);
            this.txt_manu_date.TabIndex = 4;
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(204, 49);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(369, 145);
            this.txt_desc.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(204, 17);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(369, 29);
            this.txt_id.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Coral;
            this.groupBox1.Controls.Add(this.lbl_time);
            this.groupBox1.Controls.Add(this.btn_new_document);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Location = new System.Drawing.Point(8, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(26, 526);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(57, 21);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "label11";
            // 
            // btn_new_document
            // 
            this.btn_new_document.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_new_document.Image = global::wind.Properties.Resources.new_document;
            this.btn_new_document.Location = new System.Drawing.Point(44, 443);
            this.btn_new_document.Name = "btn_new_document";
            this.btn_new_document.Size = new System.Drawing.Size(70, 69);
            this.btn_new_document.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_new_document.TabIndex = 5;
            this.btn_new_document.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_new_document, "New_document");
            this.btn_new_document.Click += new System.EventHandler(this.btn_new_document_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Image = global::wind.Properties.Resources.trash_can;
            this.btn_delete.Location = new System.Drawing.Point(44, 340);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(70, 69);
            this.btn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_delete.TabIndex = 4;
            this.btn_delete.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_delete, "Delete");
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.Image = global::wind.Properties.Resources.edit;
            this.btn_edit.Location = new System.Drawing.Point(44, 231);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(70, 69);
            this.btn_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_edit.TabIndex = 3;
            this.btn_edit.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_edit, "Update");
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Image = global::wind.Properties.Resources.diskete;
            this.btn_save.Location = new System.Drawing.Point(44, 120);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 69);
            this.btn_save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_save.TabIndex = 2;
            this.btn_save.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_save, "Save");
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = global::wind.Properties.Resources.searchh;
            this.btn_search.Location = new System.Drawing.Point(44, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(70, 69);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_search.TabIndex = 1;
            this.btn_search.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_search, "Search");
            this.btn_search.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.DGV1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultation";
            // 
            // DGV1
            // 
            this.DGV1.BackgroundColor = System.Drawing.Color.LightGray;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(27, 205);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.Size = new System.Drawing.Size(738, 307);
            this.DGV1.TabIndex = 1;
            this.DGV1.VirtualMode = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Coral;
            this.groupBox3.Controls.Add(this.btn_search_expi_date);
            this.groupBox3.Controls.Add(this.msk_txt_expi_date);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.btn_print_report);
            this.groupBox3.Controls.Add(this.btn_load);
            this.groupBox3.Location = new System.Drawing.Point(21, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 162);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // btn_search_expi_date
            // 
            this.btn_search_expi_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_expi_date.Image = global::wind.Properties.Resources.searchh;
            this.btn_search_expi_date.Location = new System.Drawing.Point(612, 48);
            this.btn_search_expi_date.Name = "btn_search_expi_date";
            this.btn_search_expi_date.Size = new System.Drawing.Size(33, 29);
            this.btn_search_expi_date.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_search_expi_date.TabIndex = 4;
            this.btn_search_expi_date.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_search_expi_date, "Pesquisar");
            this.btn_search_expi_date.Click += new System.EventHandler(this.btn_search_data_val_Click);
            // 
            // msk_txt_expi_date
            // 
            this.msk_txt_expi_date.Location = new System.Drawing.Point(506, 48);
            this.msk_txt_expi_date.Mask = "00/00/0000";
            this.msk_txt_expi_date.Name = "msk_txt_expi_date";
            this.msk_txt_expi_date.Size = new System.Drawing.Size(100, 29);
            this.msk_txt_expi_date.TabIndex = 3;
            this.msk_txt_expi_date.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(449, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Search by Expiration Date";
            // 
            // btn_print_report
            // 
            this.btn_print_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print_report.Image = global::wind.Properties.Resources.printer2;
            this.btn_print_report.Location = new System.Drawing.Point(123, 19);
            this.btn_print_report.Name = "btn_print_report";
            this.btn_print_report.Size = new System.Drawing.Size(78, 81);
            this.btn_print_report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_print_report.TabIndex = 1;
            this.btn_print_report.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_print_report, "Report");
            this.btn_print_report.Click += new System.EventHandler(this.btn_print_report_Click);
            // 
            // btn_load
            // 
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.Image = global::wind.Properties.Resources.reload2;
            this.btn_load.Location = new System.Drawing.Point(17, 19);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(78, 81);
            this.btn_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_load.TabIndex = 0;
            this.btn_load.TabStop = false;
            this.toolTip1.SetToolTip(this.btn_load, "Load Registers");
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 300;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::wind.Properties.Resources.amazon;
            this.pictureBox9.Location = new System.Drawing.Point(718, 7);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(70, 69);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox9, "Amazon");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.tabControl1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD - Inventory Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_lote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_id)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_new_document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search_expi_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_obs;
        private System.Windows.Forms.NumericUpDown txt_tot;
        private System.Windows.Forms.NumericUpDown txt_max;
        private System.Windows.Forms.NumericUpDown txt_min;
        private System.Windows.Forms.NumericUpDown txt_lote;
        private System.Windows.Forms.DateTimePicker txt_expi_date;
        private System.Windows.Forms.DateTimePicker txt_manu_date;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.NumericUpDown txt_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btn_new_document;
        private System.Windows.Forms.PictureBox btn_delete;
        private System.Windows.Forms.PictureBox btn_edit;
        private System.Windows.Forms.PictureBox btn_save;
        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox btn_search_expi_date;
        private System.Windows.Forms.MaskedTextBox msk_txt_expi_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox btn_print_report;
        private System.Windows.Forms.PictureBox btn_load;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label lbl_time;
    }
}

