using Microsoft.AspNetCore.Http;
using WebOptimizer;

namespace Nop.Web.Framework.WebOptimizer
{
    /// <summary>
    /// Represents the default bundle implementation
    /// </summary>
    public partial class DefaultAsset : IAsset
    {
        public DefaultAsset(string route, string contentType)
        {
            Route = route;
            ContentType = contentType;
        }
        public string ContentType { get; init; }

        public IList<IProcessor> Processors => new List<IProcessor>();

        public IDictionary<string, object> Items => new Dictionary<string, object>();

        public string Route { get; init; }

        public IList<string> ExcludeFiles => new List<string>();

        public HashSet<string> SourceFiles => new();

        public Task<byte[]> ExecuteAsync(HttpContext context, IWebOptimizerOptions options)
        {
            throw new NotImplementedException();
        }

        public string GenerateCacheKey(HttpContext context, IWebOptimizerOptions options)
        {
            return string.Empty;
        }

        public void TryAddSourceFile(string route)
        {
            throw new NotImplementedException();
        }
    }
}
