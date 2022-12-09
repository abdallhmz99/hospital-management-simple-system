using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace small_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct patient
        {
            public int id;
            public int room;
            public string name;
            public string illness;
            public string doctor;
            public string address;
        };
        public List<patient> patientList = new List<patient>();
        
        private void add_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            bool flag = false;
            patient p;
            p.id = Int32.Parse(id.Text);
            p.room = Int32.Parse(r_num.Text);
            p.name = p_name.Text;
            p.illness = illness.Text;
            p.doctor = doctor.Text;
            p.address = address.Text;
            if (!patientList.Any())
            {
                patientList.Add(p);    
            }
            else
            {
                foreach (patient a in patientList)
                {
                    if (p.id < a.id)
                    {
                        tmp = patientList.IndexOf(a);
                        flag = true;
                    }
                }
                if (flag == true)
                {
                    patientList.Insert(tmp, p);
                    flag = false;
                }
                else
                {
                    patientList.Add(p);
                }
            }
            id.Clear();
            r_num.Clear();
            p_name.Clear();
            illness.Clear();
            doctor.Clear();
            address.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("E:\\3bdallah\\semester 4\\file org\\labs\\SaveFile.txt");
            foreach (patient item in patientList)
            {
                sw.Write("Id: " + item.id + "\t room: " + item.room +"\t name: " + item.name + "\t address: " + item.address+ "\t illness: "+ item.illness+ "\t doctor: "+ item.doctor+ "\n");
                sw.Write("_____________________________________________________________");
            }
            sw.Close();
            MessageBox.Show("successfull save");
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            patientList.Clear();
            MessageBox.Show("list cleared successfully");
        }

        private void search_id_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (patient item in patientList)
            {
                if (Int32.Parse(id.Text) == item.id)
                {
                    flag = true;
                    list.Text = "Id: " + item.id + "\t room: " + item.room + "\t name: " + item.name + "\t address: " + item.address + "\t illness: " + item.illness + "\t doctor: " + item.doctor;
                } 
            }
            if (flag == false)
                MessageBox.Show(" id not found");
        }

        private void search_name_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (patient item in patientList)
            {
                if (p_name.Text == item.name)
                {
                    flag = true;
                    list.Text = "Id: " + item.id + "\t room: " + item.room + "\t name: " + item.name + "\t address: " + item.address + "\t illness: " + item.illness + "\t doctor: " + item.doctor;
                }
            }
            if (flag == false)
                MessageBox.Show(" Name not found");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void display_Click(object sender, EventArgs e)
        {
            foreach (patient item in patientList)
            {
                list.Text += "Id: " + item.id + "\t room: " + item.room + "\t name: " + item.name + "\t address: " + item.address + "\t illness: " + item.illness + "\t doctor: " + item.doctor + "\n";
            }

        }

        private void remove_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (patient a in patientList)
            {
                if (Int32.Parse(id.Text) == a.id)
                {
                    patientList.RemoveAt(patientList.IndexOf(a));
                    flag = true;
                    MessageBox.Show("patient removed successfully");
                }
            }
            if (flag == false)
                MessageBox.Show(" id not found");
        }

        

        

    }
}
