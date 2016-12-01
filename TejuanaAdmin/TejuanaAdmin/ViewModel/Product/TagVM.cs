namespace TejuanaAdmin.ViewModel.Product
{
    public class TagVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
