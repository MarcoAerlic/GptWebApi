using Core.Model.CoreEntity;
using MarcosWebApiProject.ApplicationService.ADProduct;
using MarcosWebApiProject.ApplicationService.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MarcosWebApiProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GptController : ControllerBase
    {

        private readonly IADProductService _adProduct;
        public GptController(IADProductService adProduct)
        {
            _adProduct = adProduct;
        }

        //   [ValidateAntiForgeryToken]
        [HttpPost("ExtractDataGptTurbo")]
        //  [AuthorizeByApiKey]
        public async Task<ActionResult<ADProductResponseModel>> GenerateADGPTTurbo(List<GPTMessage> aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateAdContentGptTurbo(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }

        //  [ValidateAntiForgeryToken]
        [HttpPost("ExtractDataGpt4")]
        //  [AuthorizeByApiKey]
        public async Task<ActionResult<ADProductResponseModel>> ExtractADDataGpt4(List<GPTMessage> aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateAdContentGpt4(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }

        //   [ValidateAntiForgeryToken]
        [HttpPost("ExtractDataDavinci")]
        //  [AuthorizeByApiKey]
        public async Task<ActionResult<ADProductResponseModel>> GenerateADDavinci(CustomerRequestModel aDGenerateRequestModel)
        {
            try
            {

                var response = await _adProduct.GenerateAdContentDaVinci(aDGenerateRequestModel);

                return response;
            }
            catch (System.Exception ex)
            {

                return null;
            }

        }

    }

}
