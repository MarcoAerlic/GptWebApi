using Core.Model.CoreEntity;
using MarcosWebApiProject.ApplicationService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcosWebApiProject.ApplicationService.ADProduct
{
    public class ADProductService : IADProductService
    {
        private readonly IBotAPIService _botAPIService;

        public ADProductService(IBotAPIService botAPIService)
        {
            _botAPIService = botAPIService;

        }

        public async Task<ADProductResponseModel> GenerateAdContentDaVinci(CustomerRequestModel aDGenerateRequestModel)
        {
            if (string.IsNullOrEmpty(aDGenerateRequestModel.Message))
            {
                return new ADProductResponseModel
                {
                    Success = false,
                    ADContent = null
                };
            }
            var userMessage = new ADGenerateRequestModelDTO
            {
                prompt = aDGenerateRequestModel.Message
            };
            var generateAD = await _botAPIService.GenerateContentDaVinci(userMessage);

            if (generateAD.Count == 0)
            {
                return new ADProductResponseModel
                {
                    Success = false,
                    ADContent = null
                };
            }

            return new ADProductResponseModel
            {
                Success = true,
                ADContent = generateAD
            };
        }

        public async Task<ADProductResponseModel> GenerateAdContentGptTurbo(List<GPTMessage> aDGenerateRequestModel)
        {
            if (!(aDGenerateRequestModel != null && aDGenerateRequestModel.Any()))
            {
                return new ADProductResponseModel
                {
                    Success = false,
                    ADContent = null
                };
            }

            var generateAD = await _botAPIService.GenerateContentGptTurbo(aDGenerateRequestModel);

            if (generateAD.Count == 0)
            {
                return new ADProductResponseModel
                {
                    Success = false,
                    ADContent = null
                };
            }

            return new ADProductResponseModel
            {
                Success = true,
                ADContent = generateAD
            };
        }

        public async Task<ADProductResponseModel> GenerateAdContentGpt4(List<GPTMessage> aDGenerateRequestModel)
        {
            if (!(aDGenerateRequestModel != null && aDGenerateRequestModel.Any()))
            {
                return new ADProductResponseModel
                {
                    Success = false,
                    ADContent = null
                };
            }

            var generateAD = await _botAPIService.GenerateContentGpt4(aDGenerateRequestModel);

            if (generateAD.Count == 0)
            {
                return new ADProductResponseModel
                {
                    Success = false,
                    ADContent = null
                };
            }

            return new ADProductResponseModel
            {
                Success = true,
                ADContent = generateAD
            };
        }
    }

}
