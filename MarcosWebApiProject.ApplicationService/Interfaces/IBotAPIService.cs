using Core.Model.CoreEntity;
using MarcosWebApiProject.ApplicationService.ADProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosWebApiProject.ApplicationService.Interfaces
{
    public interface IBotAPIService
    {
        Task<List<string>> GenerateContentDaVinci(ADGenerateRequestModelDTO generateRequestModel);
        Task<List<string>> GenerateContentGptTurbo(List<GPTMessage> generateRequestModel);

        Task<List<string>> GenerateContentGpt4(List<GPTMessage> generateRequestModel);
    }
}
