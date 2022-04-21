using Bics.Services;
using Lab.Data;
using Lab.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Lab.Services
{
    internal class BookCategoryService : Service<BookCategory, int>, IBookCategoryService
    {
        public BookCategoryService(LabDataContext context, IServiceProvider serviceProvider, ILogger<BookCategoryService> logger) : base(context, serviceProvider, logger)
        {
        }
		public override string Name { get; } = "BookCategory";

		protected override IDictionary<ActionService, ActionServiceMessage> ActionsMessages { get; } = new Dictionary<ActionService, ActionServiceMessage>
		{
			[ActionService.Add] = new ActionServiceMessage { Success = "Thêm mới {0} thành công.", Failure = "Thêm mới {0} thất bại." },
			[ActionService.Update] = new ActionServiceMessage { Success = "Cập nhật {0} thành công.", Failure = "Cập nhật {0} thất bại." },
			[ActionService.Delete] = new ActionServiceMessage { Success = "Xóa {0} thành công.", Failure = "Xóa {0} thất bại.", SuccessMultiple = "Đã xóa {1} {0}." },
			[ActionService.Get] = new ActionServiceMessage { Failure = "Không thể lấy thông tin {0}.", FailureMultiple = "Không thể lấy danh sách {0}." },
			[ActionService.Exists] = new ActionServiceMessage { Failure = "Có lỗi đã xảy ra trong quá trình kiểm tra sự tồn tại của {0}." },
		};
	}
}
