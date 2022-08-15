using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace fluidXtoresApi.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public int categoryTemplateId { get; set; }
        public string metaKeywords { get; set; }
        public string metaDescription { get; set; }
        public string metaTitle { get; set; }
        public int parentCategoryId { get; set; }
        public int pageSize { get; set; }
        public string pageSizeOptions { get; set; }
        public string priceRanges { get; set; }
        public bool showOnHomePage { get; set; }
        public bool includeintopMenu { get; set; }
        public bool hasDiscountsApplied { get; set; }
        public bool published { get; set; }
        public bool deleted { get; set; }
        public int displayOrder { get; set; }
        public string createdOnUtc { get; set; }
        public bool allowCustomersToSelectPageSize { get; set; }
        public string updatedOnUtc { get; set; }
        public List<int> roleIds { get; set; }
        public List<int> discountIds { get; set; }
        public List<int> storeIds { get; set; }
        public string seName { get; set; }
        

    }
}
