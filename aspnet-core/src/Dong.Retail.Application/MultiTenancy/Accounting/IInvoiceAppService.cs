using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Dong.Retail.MultiTenancy.Accounting.Dto;

namespace Dong.Retail.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
