namespace LibraryManagementSystem.ViewModels
{
    public class AuthorViewModel
    {
        public int Id { get; set; }                  // Yazarın kimliği
        public string FullName { get; set; }         // Yazarın tam adı (Ad + Soyad)
        public DateTime DateOfBirth { get; set; }    // Doğum tarihi
        public int BookCount { get; set; }           // Yazara ait kitap sayısı
    }
}
