using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//These Two lines of code are IMPORTANT, without it the software won't work
using MySql.Data;
using MySql.Data.MySqlClient;
//------------------------------------

namespace wind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; " +
            "User Id = root; Database = bdcontrole_de_estoque");

        MySqlCommand cmd = new MySqlCommand();

        DataTable dt = new DataTable();


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
           if (MessageBox.Show("Do you wish to exit?", "Message",
         MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void cleaning()
        {
            txt_id.Value = 0;
            txt_desc.Clear();
            txt_manu_date.Value = DateTime.Now;
            txt_expi_date.Value = DateTime.Now;
            txt_lote.Value = 0;
            txt_min.Value = 0;
            txt_max.Value = 0;
            txt_tot.Value = 0;
            txt_obs.Clear();
        }

        private bool confirmation()
        {
            if (MessageBox.Show("Are you sure? You need to be aware!", "Alert",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool validateDate()
        {
            if (txt_expi_date.Value < txt_manu_date.Value)
            {
                MessageBox.Show("Expiration Date cannot be less or equal to Manufacturing Date!", 
                    "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void execution(string sql2)
        {
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = sql2;
            cmd.ExecuteNonQuery();
        }

        string time;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time = DateTime.Now.ToLongTimeString();
            lbl_time.Text = "Time: " + time;
        }

        private void dgvGerarTabela()
        {
            DGV1.Columns[0].Width = 50;
            DGV1.Columns[1].Width = 300;
            DGV1.Columns[2].Width = 200;
            DGV1.Columns[3].Width = 200;
            DGV1.Columns[4].Width = 50;
            DGV1.Columns[5].Width = 50;
            DGV1.Columns[6].Width = 50;
            DGV1.Columns[7].Width = 50;
            DGV1.Columns[8].Width = 300;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbestoque " +
                    "WHERE id = '"+txt_id.Value.ToString()+"'", conn);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);

                txt_id.Value = Convert.ToInt32(dt2.Rows[0].Field<int>("id"));
                txt_desc.Text = dt2.Rows[0].Field<string>("description");
                txt_manu_date.Value = dt2.Rows[0].Field<DateTime>("manu_date");
                txt_expi_date.Value = dt2.Rows[0].Field<DateTime>("expi_date");
                txt_lote.Value = dt2.Rows[0].Field<int>("lot");
                txt_min.Value = dt2.Rows[0].Field<int>("minimum");
                txt_max.Value = dt2.Rows[0].Field<int>("maximum");
                txt_tot.Value = dt2.Rows[0].Field<int>("total");
                txt_obs.Text = dt2.Rows[0].Field<string>("obs");

                MessageBox.Show("Register: " + txt_id.Value.ToString() + " was selected successfully!");
            }
            catch (Exception E)
            {
                if (MessageBox.Show("ERROR: An error occured! For more information click 'OK'.", "Alert", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show("ERRO: " + E);
                }
            }
            conn.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (validateDate())
            {
                try
                {
                    string sql = "INSERT INTO tbestoque(id,description,manu_date,expi_date,lot,minimum,maximum,total,obs) " +
                        "VALUES('" + txt_id.Value.ToString() + "' , '"
                        + txt_desc.Text + "' , '"
                        + txt_manu_date.Value.ToString("yyyy-MM-dd") + "' , '"
                        + txt_expi_date.Value.ToString("yyyy-MM-dd") + "' , '"
                        + txt_lote.Value.ToString() + "' , '"
                        + txt_min.Value.ToString() + "' , '"
                        + txt_max.Value.ToString() + "' , '"
                        + txt_tot.Value.ToString() + "' , '"
                        + txt_obs.Text + "')";

                        execution(sql);

                        DGV1.Refresh();

                        MessageBox.Show("Register: " + txt_id.Value.ToString() + " was inserted successfully!");
                }
                catch (Exception E)
                {
                    MessageBox.Show("ERROR: " + E);
                }
            }
            conn.Close();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (validateDate())
            {
                try
                {
                    string sql = "UPDATE tbestoque SET " +
                       "description = '" + txt_desc.Text + "' , " +
                       "manu_date = '" + txt_manu_date.Value.ToString("yyyy-MM-dd") + "' , " +
                       "expi_date = '" + txt_expi_date.Value.ToString("yyyy-MM-dd") + "' , " +
                       "lot = '" + txt_lote.Value.ToString() + "' , " +
                       "minimum = '" + txt_min.Value.ToString() + "' , " +
                       "maximum = '" + txt_max.Value.ToString() + "' , " +
                       "total = '" + txt_tot.Value.ToString() + "' , " +
                       "obs = '" + txt_obs.Text + "' " +
                       " where id = '"
                       + txt_id.Value.ToString() + "'";

                    execution(sql);

                    DGV1.Refresh();

                    MessageBox.Show("Register " + txt_id.Value.ToString() + " was updated successfully!");
                }
                catch(Exception E)
                {
                    if (MessageBox.Show("ERROR: An error occured! For more information click 'OK'.", "Alert",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        MessageBox.Show("ERROR: " + E);
                    }
                }
            }
            conn.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (confirmation())
            {
                try
                {
                    string sql = "DELETE FROM tbestoque WHERE id = '" + txt_id.Value.ToString() + "'";

                    execution(sql);

                    MessageBox.Show("Register " + txt_id.Value.ToString() + " deleted successfully!");
                }
                catch (Exception E)
                {
                    if (MessageBox.Show("ERROR: An error occured! For more information click 'OK'.", "Alert",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        MessageBox.Show("ERROR: " + E);
                    }
                }
            }
            conn.Close();
        }

        private void btn_new_document_Click(object sender, EventArgs e)
        {
            cleaning();
        }

        //Consulta PAGE
        private void btn_load_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter
            ("SELECT * from tbestoque", conn);
            da.Fill(dt);
            DGV1.DataSource = dt;
            dgvGerarTabela();
            conn.Close();
        }

        DataTable dados;
        int count = 0;

        private void btn_print_report_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbestoque", conn);
            da.Fill(dt);
            dados = dt;
            printPreviewDialog1.ShowDialog();
            conn.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Font declaration and resources that we're going to use in the document!
            int pgwidth = 820;
            string font = "Arial";
            Brush black = Brushes.Black;
            Font fntDoc = new Font(font, 18, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntFoot = new Font(font, 14, FontStyle.Regular, GraphicsUnit.Pixel);
            Font fntTitulo = new Font(font, 22, FontStyle.Bold, GraphicsUnit.Pixel);
            Font fntSubtitulo = new Font(font, 18, FontStyle.Italic, GraphicsUnit.Pixel);
            Font fntH1 = new Font(font, 20, FontStyle.Bold, GraphicsUnit.Pixel);

            //Drawing the header
            string Titulo = "Amazon Innventory";
            string Subtitulo = "ID Register: " + dados.Rows[count].Field<int>("id").ToString("00000");
            Image logo = Properties.Resources.amazon;
            int logo_w = (80 * logo.Width) / logo.Height;
            //e.Graphics.DrawImage(logo, 90, 80, 80, 80);
            e.Graphics.DrawImage(logo, (pgwidth - logo_w) - 80, 80, logo_w, 80);
            e.Graphics.DrawString(Titulo, fntTitulo, black, ((pgwidth - logo_w) - e.Graphics.MeasureString(Titulo, fntTitulo).Width) / 2, 95);
            e.Graphics.DrawString(Subtitulo, fntSubtitulo, black, ((pgwidth - logo_w) - e.Graphics.MeasureString(Subtitulo, fntSubtitulo).Width) / 2, 125);
            e.Graphics.DrawLine(Pens.Black, 90, 175, 730, 175);

            //Defining the positioning variables
            int y_pos, spacing, leftmarg;
            y_pos = 195; spacing = 30; leftmarg = 90;

            //Drawing the poster's image
            int img_x = 0, img_w = 360;
            Image poster;
            try
            {
                poster = Image.FromFile(@"imgs\" + dados.Rows[count].Field<int>("id").ToString() + ".png");
                int img_h = (img_w * poster.Height) / poster.Width;
                img_x = (pgwidth - img_w) / 2;
                e.Graphics.DrawImage(poster, img_x, y_pos, img_w, img_h);
                e.Graphics.DrawRectangle(Pens.Black, img_x, y_pos, img_w, img_h);
                y_pos += img_h + spacing;
            }
            catch { }

            //Drawing the movie's data
            e.Graphics.DrawString("Data of the Register", fntH1, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("ID: " + dados.Rows[count].Field<int>("id").ToString(), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Description: " + dados.Rows[count].Field<string>("description"), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Manufacturing Date: " + dados.Rows[count].Field<DateTime>("manu_date").ToString("dd/MM/yyyy"), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Expiration Date: " + dados.Rows[count].Field<DateTime>("expi_date").ToString("dd/MM/yyyy"), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Lot's Number: " + dados.Rows[count].Field<int>("lot").ToString(), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Mínimum: " + dados.Rows[count].Field<int>("minimum").ToString(), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Máximum: " + dados.Rows[count].Field<int>("maximum").ToString(), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Total: " + dados.Rows[count].Field<int>("total").ToString(), fntDoc, black, leftmarg, y_pos); y_pos += spacing;
            e.Graphics.DrawString("Observations: ", fntDoc, black, leftmarg, y_pos); y_pos += spacing;

            //Word-wrap to print obs
            string Observacoes = dados.Rows[count].Field<string>("obs").ToString();
            List<string> sinopse_linhas = new List<string>();
            int max_width = 70;
            int x = (Observacoes.Length / max_width) + 1;
            int a = 0;
            for (int i = 0; i < x; i++)
            {
                string linha = Observacoes.Substring(a, Observacoes.Length - a <= max_width ? Observacoes.Length - a : max_width);
                a += max_width;
                sinopse_linhas.Add(linha);
            }
            foreach (string linha in sinopse_linhas)
            {
                e.Graphics.DrawString(linha, fntDoc, black, leftmarg + 30, y_pos); y_pos += spacing;
            }

            //Drawing the Footer
            e.Graphics.DrawLine(Pens.Black, 90, 1056, 730, 1056);
            e.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss\ndd/MM/yyyy"), fntFoot, black, 90, 1066);
            SizeF footerTitle = e.Graphics.MeasureString(Titulo, fntFoot);
            e.Graphics.DrawString(Titulo, fntFoot, black, (pgwidth - (footerTitle.Width + 80)), 1066);
            string address = "R. Indaiá 354, Guilermina, Praia Grande, SP, Brazil";
            e.Graphics.DrawString(address, fntFoot, black, (pgwidth - e.Graphics.MeasureString(address, fntFoot).Width - 78), 1082);

            if (count < (dados.Rows.Count - 1))
            {
                count++;
                e.HasMorePages = true;
            }
        }

        private void btn_search_data_val_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                string date = DateTime.Parse(msk_txt_expi_date.Text).ToString("yyyy-MM-dd");
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tbestoque WHERE data_val = '" + date + "'", conn);
                da.Fill(dt);
                DGV1.DataSource = dt;
                dgvGerarTabela();
                conn.Close();
            }
            catch (Exception E)
            {
                if (MessageBox.Show("ERROR: An error occured! For more information click 'OK'.", "Alert",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    MessageBox.Show("ERROR: " + E);
                }
            }
        }
    }
}
