﻿using Comprei.Model.Entities.DefaultEntity;
using Comprei.Model.Entities.Enums;

namespace Comprei.Model.Entities
{
    public class ShoppingList : Entity
    {
        public ShoppingStatus Status { get; set; } = ShoppingStatus.Created;
        public Customer Customer { get; set; }
        public List<ShoppingProduct> ShoppingProducts { get; set; }
    }
}