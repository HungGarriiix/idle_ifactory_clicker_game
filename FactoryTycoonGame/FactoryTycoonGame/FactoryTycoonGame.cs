using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryTycoonLibrary.Classes;

namespace FactoryTycoonGame
{
    public partial class FactoryTycoonGame : Form
    {
        Controller _controller;

        public FactoryTycoonGame()
        {
            InitializeComponent();
            _controller = new Controller();
            BindingPlayer();
            SettingUpFactories();
        }

        private void btnPlayerSellInventory_Click(object sender, EventArgs e)
        {
            _controller.Player.SellAllItemsInInventory();
        }

        // "Buy" button
        private void btnMiner1Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 1);
        }

        private void btnMiner2Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 2);
        }

        private void btnMiner3Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 3);
        }

        private void btnSmelter1Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 4);
        }

        private void btnSmelter2Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 5);
        }

        private void btnSmelter3Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 6);
        }

        private void btnConstructor1Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 7);
        }

        private void btnConstructor2Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 8);
        }

        private void btnConstructor3Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 9);
        }

        private void btnAssembler1Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 10);
        }

        private void btnAssembler2Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 11);
        }

        private void btnAssembler3Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 12);
        }

        private void btnManufacturer1Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 13);
        }

        private void btnManufacturer2Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 14);
        }

        private void btnManufacturer3Buy_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.BuyFactory(_controller.Player, 15);
        }

        // "Produce" buttons
        private void btnMiner1Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 1);
        }

        private void btnMiner2Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 2);
        }

        private void btnMiner3Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 3);
        }

        private void btnSmelter1Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 4);
        }

        private void btnSmelter2Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 5);
        }

        private void btnSmelter3Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 6);
        }

        private void btnConstructor1Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 7);
        }

        private void btnConstructor2Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 8);
        }

        private void btnConstructor3Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 9);
        }

        private void btnAssembler1Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 10);
        }

        private void btnAssembler2Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 11);
        }

        private void btnAssembler3Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 12);
        }

        private void btnManufacturer1Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 13);
        }

        private void btnManufacturer2Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 14);
        }

        private void btnManufacturer3Produce_Click(object sender, EventArgs e)
        {
            _controller.FactoryShop.ProduceProduct(_controller.Player, 15);
        }

        // Combo boxes
        private void cbbMiner1SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(1, cbbMiner1SelectedRecipe, txbMiner1SelectedRecipe);
        }

        private void cbbMiner2SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(2, cbbMiner2SelectedRecipe, txbMiner2SelectedRecipe);
        }

        private void cbbMiner3SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(3, cbbMiner3SelectedRecipe, txbMiner3SelectedRecipe);
        }

        private void cbbSmelter1SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(4, cbbSmelter1SelectedRecipe, txbSmelter1SelectedRecipe);
        }

        private void cbbSmelter2SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(5, cbbSmelter2SelectedRecipe, txbSmelter2SelectedRecipe);
        }

        private void cbbSmelter3SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(6, cbbSmelter3SelectedRecipe, txbSmelter3SelectedRecipe);
        }

        private void cbbConstructor1SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(7, cbbConstructor1SelectedRecipe, txbConstructor1SelectedRecipe);
        }

        private void cbbConstructor2SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(8, cbbConstructor2SelectedRecipe, txbConstructor2SelectedRecipe);
        }

        private void cbbConstructor3SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(9, cbbConstructor3SelectedRecipe, txbConstructor3SelectedRecipe);
        }

        private void cbbAssembler1SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(10, cbbAssembler1SelectedRecipe, txbAssembler1SelectedRecipe);
        }

        private void cbbAssembler2SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(11, cbbAssembler2SelectedRecipe, txbAssembler2SelectedRecipe);
        }

        private void cbbAssembler3SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(12, cbbAssembler3SelectedRecipe, txbAssembler3SelectedRecipe);
        }

        private void cbbManufacturer1SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(13, cbbManufacturer1SelectedRecipe, txbManufacturer1SelectedRecipe);
        }

        private void cbbManufacturer2SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(14, cbbManufacturer2SelectedRecipe, txbManufacturer2SelectedRecipe);
        }

        private void cbbManufacturer3SelectedRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            RecipeChanged(15, cbbManufacturer3SelectedRecipe, txbManufacturer3SelectedRecipe);
        }

        // Initializations
        private void BindingPlayer()
        {
            BindingPlayerInfo();
            BindingPlayerInventory();
        }
        
        private void BindingPlayerInfo()
        {
            txbPlayerName.DataBindings.Add("Text", _controller.Player, "Name");
            txbPlayerGold.DataBindings.Add("Text", _controller.Player, "Gold");
        }

        private void BindingPlayerInventory()
        {
            dgvPlayerInventory.RowHeadersVisible = false;
            dgvPlayerInventory.AutoGenerateColumns = false;
            dgvPlayerInventory.DataSource = _controller.Player.Inventory.Storage;

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Item name",
                Width = 180,
                DataPropertyName = "ItemName",
                ReadOnly = true,
                Resizable = DataGridViewTriState.False
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Quantity",
                Width = 60,
                DataPropertyName = "Quantity",
                ReadOnly = true,
                Resizable = DataGridViewTriState.False
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Single",
                Width = 88,
                DataPropertyName = "Single",
                ReadOnly = true,
                Resizable = DataGridViewTriState.False
            });

            dgvPlayerInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total",
                Width = 88,
                DataPropertyName = "TotalPrice",
                ReadOnly = true,
                Resizable = DataGridViewTriState.False
            });

            txbPlayerInventoryValue.DataBindings.Add("Text", _controller.Player.Inventory, "TotalValue");
        }

        private void SettingUpFactories()
        {
            BindingFactoriesToGUI();
            for (int i = 1; i <= 15; i++)
                FactoryOnAssignmentBinding(null, i);
            _controller.FactoryShop.AssignedFactory += FactoryOnAssignmentBinding;
        }

        private void BindingFactoriesToGUI()
        {
            for(int i = 1; i <= 15; i++)
            {
                switch(i)
                {
                    case 1:
                        cbbMiner1SelectedRecipe.SelectedIndexChanged -= cbbMiner1SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbMiner1Type, cbbMiner1SelectedRecipe, btnMiner1Buy, i);
                        cbbMiner1SelectedRecipe.SelectedIndexChanged += cbbMiner1SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 2:
                        cbbMiner2SelectedRecipe.SelectedIndexChanged -= cbbMiner2SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbMiner2Type, cbbMiner2SelectedRecipe, btnMiner2Buy, i);
                        cbbMiner2SelectedRecipe.SelectedIndexChanged += cbbMiner2SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 3:
                        cbbMiner3SelectedRecipe.SelectedIndexChanged -= cbbMiner3SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbMiner3Type, cbbMiner3SelectedRecipe, btnMiner3Buy, i);
                        cbbMiner3SelectedRecipe.SelectedIndexChanged += cbbMiner3SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 4:
                        cbbSmelter1SelectedRecipe.SelectedIndexChanged -= cbbSmelter1SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbSmelter1Type, cbbSmelter1SelectedRecipe, btnSmelter1Buy, i);
                        cbbSmelter1SelectedRecipe.SelectedIndexChanged += cbbSmelter1SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 5:
                        cbbSmelter2SelectedRecipe.SelectedIndexChanged -= cbbSmelter2SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbSmelter2Type, cbbSmelter2SelectedRecipe, btnSmelter2Buy, i);
                        cbbSmelter2SelectedRecipe.SelectedIndexChanged += cbbSmelter2SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 6:
                        cbbSmelter3SelectedRecipe.SelectedIndexChanged -= cbbSmelter3SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbSmelter3Type, cbbSmelter3SelectedRecipe, btnSmelter3Buy, i);
                        cbbSmelter3SelectedRecipe.SelectedIndexChanged += cbbSmelter3SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 7:
                        cbbConstructor1SelectedRecipe.SelectedIndexChanged -= cbbConstructor1SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbConstructor1Type, cbbConstructor1SelectedRecipe, btnConstructor1Buy, i);
                        cbbConstructor1SelectedRecipe.SelectedIndexChanged += cbbConstructor1SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 8:
                        cbbConstructor2SelectedRecipe.SelectedIndexChanged -= cbbConstructor2SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbConstructor2Type, cbbConstructor2SelectedRecipe, btnConstructor2Buy, i);
                        cbbConstructor2SelectedRecipe.SelectedIndexChanged += cbbConstructor3SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 9:
                        cbbConstructor3SelectedRecipe.SelectedIndexChanged -= cbbConstructor3SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbConstructor3Type, cbbConstructor3SelectedRecipe, btnConstructor3Buy, i);
                        cbbConstructor3SelectedRecipe.SelectedIndexChanged += cbbConstructor3SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 10:
                        cbbAssembler1SelectedRecipe.SelectedIndexChanged -= cbbAssembler1SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbAssembler1Type, cbbAssembler1SelectedRecipe, btnAssembler1Buy, i);
                        cbbAssembler1SelectedRecipe.SelectedIndexChanged += cbbAssembler1SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 11:
                        cbbAssembler2SelectedRecipe.SelectedIndexChanged -= cbbAssembler2SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbAssembler2Type, cbbAssembler2SelectedRecipe, btnAssembler2Buy, i);
                        cbbAssembler2SelectedRecipe.SelectedIndexChanged += cbbAssembler2SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 12:
                        cbbAssembler3SelectedRecipe.SelectedIndexChanged -= cbbAssembler3SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbAssembler3Type, cbbAssembler3SelectedRecipe, btnAssembler3Buy, i);
                        cbbAssembler3SelectedRecipe.SelectedIndexChanged += cbbAssembler3SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 13:
                        cbbManufacturer1SelectedRecipe.SelectedIndexChanged -= cbbManufacturer1SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbManufacturer1Type, cbbManufacturer1SelectedRecipe, btnManufacturer1Buy, i);
                        cbbManufacturer1SelectedRecipe.SelectedIndexChanged += cbbManufacturer1SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 14:
                        cbbManufacturer2SelectedRecipe.SelectedIndexChanged -= cbbManufacturer2SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbManufacturer2Type, cbbManufacturer2SelectedRecipe, btnManufacturer2Buy, i);
                        cbbManufacturer2SelectedRecipe.SelectedIndexChanged += cbbManufacturer3SelectedRecipe_SelectedIndexChanged;
                        break;
                    case 15:
                        cbbManufacturer3SelectedRecipe.SelectedIndexChanged -= cbbManufacturer3SelectedRecipe_SelectedIndexChanged;
                        BindingFactoryToGUI(txbManufacturer3Type, cbbManufacturer3SelectedRecipe, btnManufacturer3Buy, i);
                        cbbManufacturer3SelectedRecipe.SelectedIndexChanged += cbbManufacturer3SelectedRecipe_SelectedIndexChanged;
                        break;
                }
            }
        }

        private void BindingFactoryToGUI(TextBox txb_type, ComboBox cbb_recipe, Button btn_buy, int location_index)
        {
            AssignedFactory af = _controller.FactoryShop.GetFactoryByLocationIndex(location_index);
            txb_type.Text = af.FactoryType.Name;
            btn_buy.Text = $"Buy: {af.FactoryType.Price}";
            cbb_recipe.DataSource = af.FactoryType.AvailableRecipe;
            cbb_recipe.DisplayMember = "Name";
            cbb_recipe.ValueMember = "ID";
            cbb_recipe.SelectedIndex = -1;
        }

        private void RecipeChanged(int location_index, ComboBox cbb_recipe, TextBox txb_recipe)
        {
            AssignedFactory af = _controller.FactoryShop.GetFactoryByLocationIndex(location_index);
            af.SelectedRecipe = (Recipe)cbb_recipe.SelectedItem;
            txb_recipe.Text = af.SelectedRecipe.Details;
        }

        private void FactoryOnAssignmentBinding(object sender, int location_index)
        {
            switch(location_index)
            {
                case 1:
                    CheckFactoryOwnership(cbbMiner1SelectedRecipe, btnMiner1Buy, btnMiner1Produce, location_index);
                    break;
                case 2:
                    CheckFactoryOwnership(cbbMiner2SelectedRecipe, btnMiner2Buy, btnMiner2Produce, location_index);
                    break;
                case 3:
                    CheckFactoryOwnership(cbbMiner3SelectedRecipe, btnMiner3Buy, btnMiner3Produce, location_index);
                    break;
                case 4:
                    CheckFactoryOwnership(cbbSmelter1SelectedRecipe, btnSmelter1Buy, btnSmelter1Produce, location_index);
                    break;
                case 5:
                    CheckFactoryOwnership(cbbSmelter2SelectedRecipe, btnSmelter2Buy, btnSmelter2Produce, location_index);
                    break;
                case 6:
                    CheckFactoryOwnership(cbbSmelter3SelectedRecipe, btnSmelter3Buy, btnSmelter3Produce, location_index);
                    break;
                case 7:
                    CheckFactoryOwnership(cbbConstructor1SelectedRecipe, btnConstructor1Buy, btnConstructor1Produce, location_index); 
                    break;
                case 8:
                    CheckFactoryOwnership(cbbConstructor2SelectedRecipe, btnConstructor2Buy, btnConstructor2Produce, location_index);
                    break;
                case 9:
                    CheckFactoryOwnership(cbbConstructor3SelectedRecipe, btnConstructor3Buy, btnConstructor3Produce, location_index);
                    break;
                case 10:
                    CheckFactoryOwnership(cbbAssembler1SelectedRecipe, btnAssembler1Buy, btnAssembler1Produce, location_index); 
                    break;
                case 11:
                    CheckFactoryOwnership(cbbAssembler2SelectedRecipe, btnAssembler2Buy, btnAssembler2Produce, location_index);
                    break;
                case 12:
                    CheckFactoryOwnership(cbbAssembler3SelectedRecipe, btnAssembler2Buy, btnAssembler2Produce, location_index);
                    break;
                case 13:
                    CheckFactoryOwnership(cbbManufacturer1SelectedRecipe, btnManufacturer1Buy, btnManufacturer1Produce, location_index);
                    break;
                case 14:
                    CheckFactoryOwnership(cbbManufacturer2SelectedRecipe, btnManufacturer2Buy, btnManufacturer2Produce, location_index);
                    break;
                case 15:
                    CheckFactoryOwnership(cbbManufacturer3SelectedRecipe, btnManufacturer3Buy, btnManufacturer3Produce, location_index);
                    break;
            }
        }

        private void CheckFactoryOwnership(ComboBox cbb_recipe, Button btn_buy, Button btn_produce, int location_index)
        {
            AssignedFactory af = _controller.FactoryShop.GetFactoryByLocationIndex(location_index);
            cbb_recipe.Enabled = af.Owned;
            btn_produce.Enabled = af.Owned;
            btn_buy.Enabled = !af.Owned;
        }
    }
}
