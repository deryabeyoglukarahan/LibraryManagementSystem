namespace LibraryManagementSystem.ViewModels
{
    public class BookViewModel
    {
        public int Id { get; set; }                 // Kitap kimliği
        public string Title { get; set; }           // Kitap başlığı
        public string Genre { get; set; }           // Kitap türü
        public DateTime PublishDate { get; set; }   // Yayınlanma Tarihi
        public string ISBN { get; set; }            // ISBN numarası
        public int CopiesAvailable { get; set; }    // Mevcut kopya sayısı
        public string AuthorFullName { get; set; }  // Yazarın tam adı (View için birleştirilmiş hali)
    }
}
