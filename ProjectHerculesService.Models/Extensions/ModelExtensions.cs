using ProjectHerculesService.DTO;
using System.Diagnostics.CodeAnalysis;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Models.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class ModelExtensions
    {
        #region ToDTO

        //public static User ToModel(this UserModel model)
        //{
        //    UserDTO dto = new UserDTO();

        //    dto.UserName = model.UserName;
        //    dto.Password = model.Password;
        //    dto.FirstName = model.FirstName;
        //    dto.LastName = model.LastName;

        //    return dto;

        //}

        public static UserInsertRequest ToRequest(this UserModel model)
        {
            UserInsertRequest request = new UserInsertRequest();

            if (model != null)
            {
                request.User.FirstName = model.FirstName;
                request.User.LastName = model.LastName;
                request.User.Password = model.Password;
                request.User.UserName = model.UserName;
            }

            return request;
        }

        #endregion

        #region ToModel

        #endregion

        #region ToDomain

        #endregion

        #region ToRequest

        public static SalesTypeInsertRequest ToRequest(this SalesTypesModel model)
        {
            SalesTypeInsertRequest request = new SalesTypeInsertRequest();

            request.SalesType.SaleTypeId = model.SaleTypeId;
            request.SalesType.TypeName = model.TypeName;
            request.SalesType.SalesByType = model.SalesByType;

            return request;
        }

        #endregion

    }
}