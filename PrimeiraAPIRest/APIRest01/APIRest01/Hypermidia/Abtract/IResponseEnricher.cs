using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace APIRest01.Hypermidia.Abstract {
    public interface IResponseEnricher {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);
    }
}