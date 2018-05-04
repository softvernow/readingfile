using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace readingtextfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Listview();
        }


        /// <summary>
        /// Loads Listview with data from States.txt
        /// </summary>
        private void Load_Listview()
        {
            //get list from Get_File_Data()
            List<String> file_data = Get_File_Data();

            //Loop through list and add it to the list view. 
            foreach (String item_in_file in file_data)
            {
                //create list view item and add file item to it. 
                string[] row = { item_in_file };
                var listViewItemd = new ListViewItem(row);
                listView1.Items.Add(listViewItemd);
            }

        }


        /// <summary>
        /// Retrieves Data from States.txt
        /// </summary>
        /// <returns></returns>
        private List<String> Get_File_Data()
        {
            //List of string to add all items from file. 
            List<String> file_data = new List<string>();

            //read each line at at the time. 
            String line = String.Empty;
            System.IO.StreamReader file =new System.IO.StreamReader(@"states.txt");
            while ((line = file.ReadLine()) != null)
            {
                //add each line of the file to list 
                file_data.Add(line);
            }

            //close file reader. 
            file.Close();

            //return list of items. 
            return file_data;
        }
    }
}
