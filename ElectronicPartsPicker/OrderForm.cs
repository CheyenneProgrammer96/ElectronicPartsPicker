using ElectronicPartsPicker.Products;

namespace ElectronicPartsPicker
{
    public partial class FrmOrderForm : Form
    {
        public FrmOrderForm()
        {
            InitializeComponent();
        }

        public void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmOrderForm_Load(object sender, EventArgs e)
        {
            OrderContext context = new OrderContext();

            List<Processor> processors = (from processor in context.Processor
                                          select processor).ToList();

            List<gpu> gpus = (from gpu in context.GPUs
                              select gpu).ToList();

            List<Motherboard> motherboards = (from Motherboard in context.Motherboards
                                              select Motherboard).ToList();

            List<Nic> nics = (from Nic in context.Nic
                              select Nic).ToList();

            List<Memory> memory = (from Memory in context.Memorys
                                   select Memory).ToList();

            comboBoxProduct.Items.Add(comboBoxProduct);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            comboBoxProduct.Items.Remove(comboBoxProduct);
        }
    }
}