namespace TejuanaAdmin
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        #region [FIELDS]

        //Size constants
        private const int MENU_WIDTH = 180;
        private const int MARGIN_RIGHT = 28;
        private const int MARGIN_BOTTOM = 40;
        private const int MARGIN_BOTTOM_BOTTOM = 57;
        private const int MENU_MARGIN_RIGHT = 8;

        //forms
        private readonly IDictionary<string, IForm> _funcionalities;

        #endregion

        #region [INIT]

        public MainForm(IOrderForm orderForm, 
            IProductForm productForm,
            IPurchaseForm purchaseForm,
            IShippingorm shippingForm,
            ISupplyForm supplyForm,
            IWithdrawForm withdrawForm)
        {
            _funcionalities = new Dictionary<string, IForm>()
            {
                { "Pedidos",  orderForm },
                { "Productos",  productForm },
                { "Insumos",  supplyForm },
                { "Retiros",  withdrawForm },
                { "Envios",  shippingForm },
                { "Ventas",  purchaseForm },
            };

            InitializeComponent();

            InitializeTabs();
        }

        private void InitializeTabs()
        {
            foreach (var funcionality in _funcionalities)
            {
                var tab = new TabPage();

                tab.Name = tab.Text = funcionality.Key;
                tab.Padding = new Padding(3);
                tab.Size = new Size(192, 74);
                tab.UseVisualStyleBackColor = true;

                this._functionsTabControl.Controls.Add(tab);
            }

            OnTabSelected(null, null);
        }

        #endregion

        #region [ACTIONS]

        public void FixBounds(Control content)
        {
            Width = content.Width + MENU_WIDTH + MENU_MARGIN_RIGHT;
            Height = content.Height + MARGIN_BOTTOM + MARGIN_BOTTOM_BOTTOM;

            _functionsTabControl.Width = content.Width + MENU_WIDTH - MARGIN_RIGHT;
            _functionsTabControl.Height = content.Height + MARGIN_BOTTOM;

            content.BackColor = Color.WhiteSmoke;
        }

        private void OnTabSelected(object sender, EventArgs e)
        {
            var tab = _functionsTabControl.SelectedTab;

            tab.Controls.Clear();
            tab.BackColor = Color.Gray;

            tab.Controls.Add(_funcionalities[tab.Name].Init(this));
        }

        #endregion
    }
}
