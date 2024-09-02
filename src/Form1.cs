namespace TaskC3
{
    public partial class Form1 : Form
    {
        static Queue<Customer> customerQueue = new Queue<Customer>();
        static Stack<Customer> customerStack = new Stack<Customer>();
        static List<Customer> customerList = new List<Customer>();
        static List<string> customerDetailsList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void updateList()
        {
            listBoxQueue.DataSource = null;
            customerDetailsList.Clear();
            // Formatting object attributes
            foreach (var item in customerQueue)
            {
                customerDetailsList.Add(item.CustomerName + " : " + item.CustomerAge);
            }
            listBoxQueue.DataSource = customerDetailsList;
            labelCount.Text = customerQueue.Count.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxAge.Text))
            {
                Customer customer = new Customer();
                customer.CustomerName = textBoxName.Text;
                customer.CustomerAge = Convert.ToInt32(textBoxAge.Text);
                textBoxName.Clear();
                textBoxAge.Clear();

                customerQueue.Enqueue(customer);
                updateList();
            }
            else
            {
                MessageBox.Show("Some fields are empty", "Alert", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (customerQueue.Count > 0)
            {
                customerQueue.Dequeue();
                updateList();
            }
            else
            {
                MessageBox.Show("Queue is empty", "Alert", MessageBoxButtons.OK);
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (customerQueue.Count > 0) {
                if (textBoxReverse.Text.Length > 0)
                {
                    int noOfItemsToRev = Convert.ToInt32(textBoxReverse.Text);

                    for (int i = 0; i < noOfItemsToRev; i++)
                    {
                        customerStack.Push(customerQueue.Dequeue());
                    }
                    while (customerQueue.Count > 0)
                    {
                        customerList.Add(customerQueue.Dequeue());
                    }
                    while (customerStack.Count > 0)
                    {
                        customerQueue.Enqueue(customerStack.Pop());
                    }
                    for (int i = 0; i < customerList.Count; i++)
                    {
                        customerQueue.Enqueue(customerList[i]);
                    }
                    customerList.Clear();
                    updateList();
                }
                else
                {
                    MessageBox.Show("Enter count to reverse", "Alert", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Queue is empty", "Alert", MessageBoxButtons.OK);
            }
           
        }
    }
    public class Customer
    {
        public string name;
        public int age;
        public string CustomerName
        {
            get { return name; }
            set { name = value; }
        }
        public int CustomerAge
        {
            get { return age; }
            set { age = value; }
        }
    }
}