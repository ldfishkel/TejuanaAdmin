namespace TejuanaAdmin.ViewModel.Supply
{
    using System;

    public class SupplyVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock{ get; set; }
        public int RealStock { get; set; }
        public DateTime lastTimeSupplied { get; set; }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
