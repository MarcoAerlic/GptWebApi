using Core.Model.CoreEntity;
using MarcosWebApiProject.ApplicationService.ADProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosWebApiProject.ApplicationService.Interfaces
{
    public interface IADProductService
    {
        Task<ADProductResponseModel> GenerateAdContentDaVinci(CustomerRequestModel aDGenerateRequestModel);
        Task<ADProductResponseModel> GenerateAdContentGptTurbo(List<GPTMessage> aDGenerateRequestModel);
        Task<ADProductResponseModel> GenerateAdContentGpt4(List<GPTMessage> aDGenerateRequestModel);
    }
}
