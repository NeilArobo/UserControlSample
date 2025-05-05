using static Guna.UI2.WinForms.Suite.Descriptions;

namespace FoodApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var foodcard1 = new FoodCard();
            foodcard1.labelFoodName.Text = "Jollibee Chicken Joy";
            foodcard1.labelPrices.Text = "P99.00";
            foodcard1.pictureBoxFoodPicture.Image = ByteArrayToImage(Properties.Resources.JollibeeChickenJoyC1);

            var foodcard2 = new FoodCard();
            foodcard2.labelFoodName.Text = "Afritada";
            foodcard2.labelPrices.Text = "P50.00";
            foodcard1.pictureBoxFoodPicture.Image = ByteArrayToImage(Properties.Resources.Afritada);

            List<FoodCard> foodCards = new List<FoodCard> { foodcard1, foodcard2 };
            foreach (var foodCard in foodCards)
            {
                flowLayoutPanelFoods.Controls.Add(foodCard);
            }
        }

        public static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
