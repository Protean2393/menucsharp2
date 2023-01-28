namespace menucsharp2
{
    public partial class Form1menu : Form
    {
        public Form1menu()
        {
            InitializeComponent();
            string[] arr = { "ARROZ", "FIDEOS DE PEPINO", "LECHUGA", "TALLARINES" };
            checkedListBox1.Items.AddRange(arr);
            string[] arr2 = { "POLLO", "CERDO", "ROLLO PRIMAVERA", "SURIMI" };
            checkedListBox3.Items.AddRange(arr2);
            string[] arr3 = { "MANGO", "DURAZNO", "TOMATE", "EDEMAME", "MUSHROOMS" };
            checkedListBox6.Items.AddRange(arr3);
            string[] arr4 = { "ADEREZO HKE", "AGRIDULCE", "SOYA", "MANGO" };
            checkedListBox5.Items.AddRange(arr4);
            string[] arr5 = { "ARANDANOS", "AMARANTO", "CACAHUATE", "SEMILLA DE GIRASOL" };
            checkedListBox4.Items.AddRange(arr5);
        }
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

    

        private void CheckedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void CheckedListBox4_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void CheckedListBox5_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void checkedListBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Ordernow_Click(object sender, EventArgs e)
        {
            foreach (Object item in checkedListBox1.CheckedItems)
            {
                ListBox1.Items.Add(item);
            }
            foreach (Object item in checkedListBox3.CheckedItems)
            {
                ListBox1.Items.Add(item);
            }
            foreach (Object item in checkedListBox4.CheckedItems)
            {
                ListBox1.Items.Add(item);
            }
            foreach (Object item in checkedListBox5.CheckedItems)
            {
                ListBox1.Items.Add(item);
            }
            foreach (Object item in checkedListBox6.CheckedItems)
            {
                ListBox1.Items.Add(item);
            }
            MessageBox.Show("ORDEN RECIBIDA!");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}