using System;
using System.Linq;
using SmartStore.Core;
using SmartStore.Core.Domain.News;

namespace SmartStore.Services.News
{
    /// <summary>
    /// News service interface.
    /// </summary>
    public partial interface INewsService
    {
        /// <summary>
        /// Inserts a news item.
        /// </summary>
        /// <param name="news">News item.</param>
        void InsertNews(NewsItem news);

        /// <summary>
        /// Updates the news item.
        /// </summary>
        /// <param name="news">News item.</param>
        void UpdateNews(NewsItem news);

        /// <summary>
        /// Deletes a news.
        /// </summary>
        /// <param name="news">News item.</param>
        void DeleteNews(NewsItem news);

        /// <summary>
        /// Update news item comment totals.
        /// </summary>
        /// <param name="news">News item.</param>
        void UpdateCommentTotals(NewsItem news);

        /// <summary>
        /// Gets a news.
        /// </summary>
        /// <param name="newsId">The news identifier.</param>
        /// <returns>News item.</returns>
        NewsItem GetNewsById(int newsId);

        /// <summary>
        /// Get news by identifiers.
        /// </summary>
        /// <param name="newsIds">News identifiers.</param>
        /// <returns>News query.</returns>
        IQueryable<NewsItem> GetNewsByIds(int[] newsIds);

        /// <summary>
        /// Gets all news.
        /// </summary>
		/// <param name="storeId">Store identifier; 0 if you want to get all records.</param>
        /// <param name="pageIndex">Page index.</param>
        /// <param name="pageSize">Page size.</param>
        /// <param name="showHidden">A value indicating whether to show hidden records.</param>
		/// <param name="maxAge">The maximum age of returned news.</param>
        /// <returns>News items.</returns>
		IPagedList<NewsItem> GetAllNews(
            int storeId, 
            int pageIndex,
            int pageSize,
            bool showHidden = false,
            DateTime? maxAge = null,
            string title = "", 
            string intro = "", 
            string full = "");
    }
}
