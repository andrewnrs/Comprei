using Comprei.Model.Entities;
using System.ComponentModel;

namespace Comprei.Domain.DTOs
{
    public class HouseStorageVO
    {
        public HouseStorageVO(HouseStorage houseStorage)
        {
            Name = houseStorage.Product is not null ? houseStorage.Product.Name : "";
            Descricao = houseStorage.Product is not null ? houseStorage.Product.Description : "";
            Quantity = houseStorage.Quantity;
            ExpirationDate = houseStorage.ExpirationDate;
            AcquisitionDate = houseStorage.AcquisitionDate;
            Observation = houseStorage.Observation;
        }

        [DisplayName("Nome")]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Quantidade")]
        public int Quantity { get; set; }

        [DisplayName("Data de Vencimento")]
        public DateTime? ExpirationDate { get; set; }

        [DisplayName("Data da Compra")]
        public DateTime? AcquisitionDate { get; set; }

        [DisplayName("Observação")]
        public string? Observation { get; set; }
    }
}
