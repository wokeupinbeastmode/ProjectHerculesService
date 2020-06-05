using System;
using System.Net;
using System.Threading.Tasks;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;
using ProjectHerculesService.Models.Response;
using ProjectHerculesService.Repository.Interface;

namespace ProjectHerculesService.Library.Implementation
{
    public class SalesTypeManager : ISalesTypeManager
    {
        private readonly ISalesTypeRepository _salesTypeRepository;
        private readonly ISalesTypeBuilder _salesTypeBuilder;

        public SalesTypeManager(
            ISalesTypeRepository salesTypeRepository, 
            ISalesTypeBuilder salesTypeBuilder)
        {
            _salesTypeRepository = salesTypeRepository;
            _salesTypeBuilder = salesTypeBuilder;
        }

        public async Task<SalesTypeGetResponse> GetSalesTypeAsync(SalesTypeGetRequest request)
        {
            SalesTypeGetResponse response = new SalesTypeGetResponse();

            try
            {
                if (request != null)
                {
                    response.SalesType = await _salesTypeRepository.GetSalesTypeAsync(request.SalesTypeId); 
                    response.Success = true;
                    response.HttpStatusCode = HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("SalesTypeManager, GetSalesTypeAsync", ex);
                response.Success = false;
                response.HttpStatusCode = HttpStatusCode.BadRequest;
                throw;
            }

            return response;
        }
        public async Task<SalesTypeGetResponse> CreateSalesTypeAsync(SalesTypesModel model)
        {
            SalesTypeGetResponse response = new SalesTypeGetResponse();

            try
            {
                if (model != null)
                {
                    var request =  _salesTypeBuilder.BuildSalesTypeAsync(model);
                    response.SalesType = await _salesTypeRepository.CreateSalesTypeAsync(request.SalesType); 
                    response.Success = true;
                    response.HttpStatusCode = HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("SalesTypeManager, InsertSalesTypeAsync", ex);
                response.Success = false;
                response.HttpStatusCode = HttpStatusCode.BadRequest;
                throw;
            }

            return response;
        }
        public async Task<SalesTypesGetResponse> GetAllSalesTypesAsync()
        {
            SalesTypesGetResponse response = new SalesTypesGetResponse();

            try
            {
                response.SaleTypes = await _salesTypeRepository.GetSalesTypesAsync();
                response.Success = true;
                response.HttpStatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("SalesTypeManager, GetAllSalesTypesAsync", ex);
                response.Success = false;
                response.HttpStatusCode = HttpStatusCode.BadRequest;
                throw;
            }

            return response;
        }

    }
}