using Comprei.Controller;
using Comprei.Domain.DTOs;

namespace Comprei.View
{
    public partial class HouseStorageForm : Form
    {
        HouseController _houseController;

        public HouseStorageForm(HouseController houseController)
        {
            InitializeComponent();
            _houseController = houseController;
        }

        private void HouseStorageForm_Load(object sender, EventArgs e)
        {
            var houseStorageDb = _houseController.GetHouseStorage(1); //TODO: get house from logged customer

            var houseStorages = houseStorageDb.ConvertAll(houseStorage => new HouseStorageVO(houseStorage));

            houseStorageDataGrid.DataSource = houseStorages;
            houseStorageDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            houseStorageDataGrid.Refresh();
        }

        private void houseStorageDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
