using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace БД
{
    public partial class Form1 : Form
    {
        public static string connect = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ASK.mdb;";
        private OleDbConnection connection;
        private int i = 0;
        private string[] Vid = { "1-а комнотная", "2-ух комнотная", "студия", "3-ех комнотная", "1-а комнотная евро", "2-ух комнотная евро" };
        private string[] Type = { "комерция", "коттедж", "парковка", "жилье" };
        public Form1()
        {
            connection = new OleDbConnection(connect);
            connection.Open();              
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VidBox.Items.AddRange(Type);
            TypeBox.Items.AddRange(Vid);
            comboBox1.Items.AddRange(Type);
            
            dataGridView1.RowCount = 3;
            dataGridView1.ColumnCount = 8;
            AbdateGrid();
        }
       
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string type = TypeBox.Text;
            string flor = FloorBox.Text;
            string GK = GkBox.Text;
            string Bilder = BilderBox.Text;
            DateTime DAta = dateTimePicker1.Value;
            string Price = PriceBox.Text;
            string Poshad = PloshadBox.Text;
            String SQLtext ="";
            switch (VidBox.Text)
            {
                case "комерция":
                SQLtext = "INSERT INTO com(Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь) VALUES('" + type.ToString() + "' ,'" + flor.ToString() + "','" + GK.ToString() + "','" + Bilder.ToString() + "','" + DAta.ToShortDateString() + "','" + Price.ToString() + "','" + Poshad.ToString() + "')";
                break;
                case "коттедж":
                SQLtext = "INSERT INTO zemkot( ЖК, Цена, Площадь, Дата) VALUES('" + GK.ToString() + "','" + Price.ToString() + "','" + Poshad.ToString() + "','" + DAta.ToShortDateString() + "')";
                break;
                case "парковка":
                SQLtext = "INSERT INTO park( ЖК, Цена, Площадь, Дата) VALUES('" + GK.ToString() + "','" + Price.ToString() + "','" + Poshad.ToString() + "','" + DAta.ToShortDateString() + "')";
                break;
                case "жилье":
                SQLtext = "INSERT INTO Tab(Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь) VALUES('" + type.ToString() + "' ,'" + flor.ToString() + "','" + GK.ToString() + "','" + Bilder.ToString() + "','" + DAta.ToShortDateString() + "','" + Price.ToString() + "','" + Poshad.ToString() + "')";
                break;
            }
           // string SQLtext = "INSERT INTO Tab(Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь) VALUES('" + type.ToString() + "' ,'"+ flor.ToString() + "','" + GK.ToString() + "','" + Bilder.ToString() + "','" + DAta.ToShortDateString() + "','" + Price.ToString() + "','" + Poshad.ToString() + "')";
            OleDbCommand dobstr = new OleDbCommand(SQLtext, connection);
            dobstr.ExecuteNonQuery();
            AbdateGrid();

        }


        private void Ploshad_Filter(int value)
        {

        }


        private void Vid_Filter(string vid)
        {
            VidBox.Text = vid;
            AbdateGrid();
        }

        private void Zas_Filter(string name)
        {
            int i = 0;
            dataGridView1.RowCount = 3;
           string perenosstr = "SELECT Код, Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь FROM com";
           OleDbCommand perenos = new OleDbCommand(perenosstr, connection);
          OleDbDataReader  read = perenos.ExecuteReader();
            while (read.Read())
            {
                dataGridView1.Rows[i].Cells[0].Value = read[0];
                dataGridView1.Rows[i].Cells[1].Value = read[1];
                dataGridView1.Rows[i].Cells[2].Value = read[2];
                dataGridView1.Rows[i].Cells[3].Value = read[3];
                dataGridView1.Rows[i].Cells[4].Value = read[4];
                dataGridView1.Rows[i].Cells[5].Value = read[5];
                dataGridView1.Rows[i].Cells[6].Value = read[6];
                dataGridView1.Rows[i].Cells[7].Value = read[7];
                i++;
                dataGridView1.RowCount = i + 1;
            }
            read.Close();

            perenosstr = "SELECT Код, Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь FROM Tab";
            perenos = new OleDbCommand(perenosstr, connection);
            read = perenos.ExecuteReader();
            while (read.Read())
            {
                dataGridView1.Rows[i].Cells[0].Value = read[0];
                dataGridView1.Rows[i].Cells[1].Value = read[1];
                dataGridView1.Rows[i].Cells[2].Value = read[2];
                dataGridView1.Rows[i].Cells[3].Value = read[3];
                dataGridView1.Rows[i].Cells[4].Value = read[4];
                dataGridView1.Rows[i].Cells[5].Value = read[5];
                dataGridView1.Rows[i].Cells[6].Value = read[6];
                dataGridView1.Rows[i].Cells[7].Value = read[7];

                i++;
                dataGridView1.RowCount++;
            }
            read.Close();

        }


        private void AbdateGrid()
        {
            i = 0;
            dataGridView1.RowCount = 3;

            string perenosstr = "";
            OleDbCommand perenos;
            OleDbDataReader read;
            switch(VidBox.Text)
            {
                case "комерция":
                    dataGridView1.ColumnCount = 8;
                    dataGridView1.Columns[0].HeaderText="Код";
                    dataGridView1.Columns[1].HeaderText="Тип";
                    dataGridView1.Columns[2].HeaderText="Этаж";
                    dataGridView1.Columns[3].HeaderText="ЖК";
                    dataGridView1.Columns[4].HeaderText="Застройщик";
                    dataGridView1.Columns[5].HeaderText="Дата";
                    dataGridView1.Columns[6].HeaderText="Цена";
                    dataGridView1.Columns[7].HeaderText="Площадь";
                    perenosstr = "SELECT Код, Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь FROM com";
                    perenos = new OleDbCommand(perenosstr, connection);          
                    read = perenos.ExecuteReader();
                    while (read.Read())
                    {
                        dataGridView1.Rows[i].Cells[0].Value = read[0];
                        dataGridView1.Rows[i].Cells[1].Value = read[1];
                        dataGridView1.Rows[i].Cells[2].Value = read[2];
                        dataGridView1.Rows[i].Cells[3].Value = read[3];
                        dataGridView1.Rows[i].Cells[4].Value = read[4];
                        dataGridView1.Rows[i].Cells[5].Value = read[5];
                        dataGridView1.Rows[i].Cells[6].Value = read[6];
                        dataGridView1.Rows[i].Cells[7].Value = read[7];
                        i++;
                        dataGridView1.RowCount = i+1;
                    }
                read.Close();
                break;

                case "коттедж":
                    perenosstr = "SELECT IDzk, ЖК, Дата, Цена, Площадь FROM zemkot";
                    perenos = new OleDbCommand(perenosstr, connection);          
                    read = perenos.ExecuteReader();
                    dataGridView1.ColumnCount = 5;
                    dataGridView1.Columns[0].HeaderText="Код";
                    dataGridView1.Columns[1].HeaderText="ЖК";
                    dataGridView1.Columns[2].HeaderText="Дата";
                    dataGridView1.Columns[3].HeaderText="Цена";
                    dataGridView1.Columns[4].HeaderText="Площадь";
                    while (read.Read())
                    {
                        dataGridView1.Rows[i].Cells[0].Value = read[0];
                        dataGridView1.Rows[i].Cells[1].Value = read[1];
                        dataGridView1.Rows[i].Cells[2].Value = read[2];
                        dataGridView1.Rows[i].Cells[3].Value = read[3];
                        dataGridView1.Rows[i].Cells[4].Value = read[4];
                        i++;
                        dataGridView1.RowCount = i+1;
                    }
                read.Close();
                break;

                case "парковка":
                perenosstr = "SELECT IDp, ЖК, Дата, Цена, Площадь FROM park";
                 perenos = new OleDbCommand(perenosstr, connection);          
                 read = perenos.ExecuteReader();
                 dataGridView1.ColumnCount = 5;
                 dataGridView1.Columns[0].HeaderText="Код";
                 dataGridView1.Columns[1].HeaderText="ЖК";
                 dataGridView1.Columns[2].HeaderText="Дата";
                 dataGridView1.Columns[3].HeaderText="Цена";
                 dataGridView1.Columns[4].HeaderText="Площадь";
                while (read.Read())
                {
                dataGridView1.Rows[i].Cells[0].Value = read[0];
                dataGridView1.Rows[i].Cells[1].Value = read[1];
                dataGridView1.Rows[i].Cells[2].Value = read[2];
                dataGridView1.Rows[i].Cells[3].Value = read[3];
                dataGridView1.Rows[i].Cells[4].Value = read[4];
                i++;
                dataGridView1.RowCount = i+1;
                }
                read.Close();
                break;

                    case "жилье":
                    dataGridView1.ColumnCount = 8;
                    dataGridView1.Columns[0].HeaderText="Код";
                    dataGridView1.Columns[1].HeaderText="Тип";
                    dataGridView1.Columns[2].HeaderText="Этаж";
                    dataGridView1.Columns[3].HeaderText="ЖК";
                    dataGridView1.Columns[4].HeaderText="Застройщик";
                    dataGridView1.Columns[5].HeaderText="Дата";
                    dataGridView1.Columns[6].HeaderText="Цена";
                    dataGridView1.Columns[7].HeaderText="Площадь";
                    perenosstr = "SELECT Код, Тип, Этаж, ЖК, Застройщик, Дата, Цена, Площадь FROM Tab";
                    perenos = new OleDbCommand(perenosstr, connection);          
                    read = perenos.ExecuteReader();
                    while (read.Read())
                {
                dataGridView1.Rows[i].Cells[0].Value = read[0];
                dataGridView1.Rows[i].Cells[1].Value = read[1];
                dataGridView1.Rows[i].Cells[2].Value = read[2];
                dataGridView1.Rows[i].Cells[3].Value = read[3];
                dataGridView1.Rows[i].Cells[4].Value = read[4];
                dataGridView1.Rows[i].Cells[5].Value = read[5];
                dataGridView1.Rows[i].Cells[6].Value = read[6];
                dataGridView1.Rows[i].Cells[7].Value = read[7];

                i++;
                        dataGridView1.RowCount ++;
                }
                read.Close();
                break;
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            string a = comboBox1.Text;
            string b = DelBox.Text;
            string del = "";
            if (a == Type[0]) { del = "DELETE FROM com WHERE Код=" + b; }
            else if(a == Type[1]) { del = "DELETE FROM  zemkot WHERE IDzk=" + b; }
            else if(a == Type[2]) { del = "DELETE FROM park WHERE IDp=" + b; }
            else if(a == Type[3]) { del = "DELETE FROM Tab WHERE Код=" + b; }

            OleDbCommand delstr = new OleDbCommand(del, connection);
            delstr.ExecuteNonQuery();
            AbdateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbdateGrid();
        }
        
        
       private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VidBox_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < Type.Length; i++)
            {

                if (VidBox.Text == Type[1] || VidBox.Text == Type[2])
                {
                    TypeBox.Enabled = false;
                    TypeBox.Text = "";
                    FloorBox.Enabled = false;
                    FloorBox.Text = "";
                    BilderBox.Enabled = false;
                    BilderBox.Text = "";
                }
                else { TypeBox.Enabled = true; BilderBox.Enabled = true; FloorBox.Enabled = true; }

            }
            
        }
        
        private void changeB_Click(object sender, EventArgs e)
        {
            int j = 0;
            string changestr;
            OleDbCommand change;
            while(j < dataGridView1.RowCount)
            {
              changestr = "UPDATE Tab SET (Тип ="+ dataGridView1.Rows[j].Cells[1].ToString()+", Этаж ="+ dataGridView1.Rows[j].Cells[2].ToString()+", ЖК ="+ dataGridView1.Rows[j].Cells[3].ToString()+", Застройщик ="+ dataGridView1.Rows[j].Cells[4].ToString()+", Дата ="+ dataGridView1.Rows[j].Cells[5].ToString()+", Цена ="+ dataGridView1.Rows[j].Cells[6].ToString()+", Площадь ="+ dataGridView1.Rows[j].Cells[7].ToString() +")";
                change = new OleDbCommand(changestr, connection);
                
                change.ExecuteNonQuery();
            }
        }

        private string NAib_like()
        {
            i = 0;
            string perenosstr = "SELECT IDu, ID FROM fav";
            OleDbCommand perenos = new OleDbCommand(perenosstr,connection);
            OleDbDataReader read = perenos.ExecuteReader();
            dataGridView1.ColumnCount = 2;
            dataGridView1.RowCount = 2;
            dataGridView1.Columns[0].HeaderText = "IDuser";
            dataGridView1.Columns[1].HeaderText = "IDitem";
            while (read.Read())
            {
                dataGridView1.Rows[i].Cells[0].Value = read[0];
                dataGridView1.Rows[i].Cells[1].Value = read[1];
                i++;
                dataGridView1.RowCount++;
            }
            read.Close();
            

            int sum = 0, max = -1;
            string idI = "";
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
                sum = 0;
                for(int j = 0; j < dataGridView1.RowCount; j++) 
                {
                    if (dataGridView1.Rows[j].Cells[0].Value == dataGridView1.Rows[i].Cells[1].Value) sum++;
                }
                if(sum > max)
                {
                    idI = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    max = sum;
                }
            }
            string rezult = idI + " "+sum.ToString();
            return rezult;
        }

     /*   private void Pririst(string Vid)       PODEMAT' ESHE!!!!
        {
            VidBox.Text = Vid;
            AbdateGrid();
            double rez = 0;
            string[] srav = new string[3];
            for(int i = 0; i < dataGridView1.RowCount; i++)
            {
               for(int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != dataGridView1.Rows[j].Cells[0] && dataGridView1.Rows[i].Cells[1].Value == dataGridView1.Rows[j].Cells[1].Value &&
                        dataGridView1.Rows[i].Cells[2].Value == dataGridView1.Rows[j].Cells[2].Value && dataGridView1.Rows[i].Cells[3].Value == dataGridView1.Rows[j].Cells[3].Value &&
                        dataGridView1.Rows[i].Cells[4].Value == dataGridView1.Rows[j].Cells[4].Value && dataGridView1.Rows[i].Cells[5].Value != dataGridView1.Rows[j].Cells[5].Value &&
                        dataGridView1.Rows[i].Cells[7].Value == dataGridView1.Rows[j].Cells[7].Value)  rez = double.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()) - double.Parse(dataGridView1.Rows[j].Cells[6].Value.ToString());
                }
            }

        } */


        private double Predscaz(string ID, string vid)
        {
            return 0;   
        }

    }
}
