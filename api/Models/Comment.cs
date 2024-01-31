namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }=string.Empty;
        public String Content { get; set; }=string.Empty;
        public DateTime CreatedOn { get; set; }=DateTime.Now;
        public int? StockId { get; set; }
        //Navigation property
        public Stock? Stock { get; set; }
    }
}
