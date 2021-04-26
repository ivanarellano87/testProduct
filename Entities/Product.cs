using CrossCutting;
using System;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public StatusEntities Status { get; set; }
    }
}
