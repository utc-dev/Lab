using Bics.Models;
using Lab.Data.Entity;
using Bics.Data;

namespace Lab.Models
{
    public class BookCategorySearchModel : SearchModel
    {
        public override IList<string> TextSearchFields => new List<string>
        {
            nameof(BookCategory.Ma),
            nameof(BookCategory.Ten)
        };

        public override string DefaultSortField => nameof(BookCategory.CreatedAt);
        public override string DefaultSortDirection => SortDirection.Descending;
        public override IDictionary<string, string> Mapping => new Dictionary<string, string>
        {
            ["Code"] = nameof(BookCategory.Ma),
            ["Name"] = nameof(BookCategory.Ten)
        };
    }
}
