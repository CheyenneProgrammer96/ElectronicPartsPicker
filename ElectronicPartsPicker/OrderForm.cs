using ElectronicPartsPicker.Products;
using Microsoft.IdentityModel.Tokens;

namespace ElectronicPartsPicker
{
    public partial class FrmOrderForm : Form
    {
        OrderContext context = new OrderContext();

        public FrmOrderForm()
        {
            InitializeComponent();
        }

        public void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            comboBoxProduct.Items.Remove(comboBoxProduct);
        }

        private void comboBoxPType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(comboBoxPType.SelectedItem.ToString().IsNullOrEmpty())) {
                loadSelectedProduct(comboBoxPType.SelectedItem.ToString());
            }
        }

        private void loadSelectedProduct(string productType)
        {

            List<Object> products = new List<Object>();
            String displayMember = "";
            String valueMember = "";

            if (productType == "Processors")
            {
             <products> = (from processor in context.Processor
              select processor).ToList();

                displayMember = "ProcessorName";
                valueMember = "ProcessorId";
            }

            //List<gpu> gpus = (from gpu in context.GPUs
            //                  select gpu).ToList();

            //List<Motherboard> motherboards = (from Motherboard in context.Motherboards
            //                                  select Motherboard).ToList();

            //List<Nic> nics = (from Nic in context.Nic
            //                  select Nic).ToList();

            //List<Memory> memory = (from Memory in context.Memorys
            //                       select Memory).ToList();

            comboBoxProduct.DataSource = products;
            comboBoxProduct.DisplayMember = displayMember;
            comboBoxProduct.ValueMember = valueMember;
        }
    }
}