using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ProjectHerculesService.Data.Models;
using ProjectHerculesService.Models;

namespace ProjectHerculesService.Repository.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class HerculesRespositoryExtensions
    {
        #region User
        public static UserModel ToModel(this User domain)
        {
            if (domain == null)
            {
                return new UserModel();
            }

            UserModel model = new UserModel()
            {
                UserName = domain.UserName,
                Password = domain.Password, //TODO this should never be returned
                FirstName = domain.FirstName,
                LastName = domain.LastName,
                //UserTypeId = domain.UserTypeId
            };

            return model;
        }

        public static List<UserModel> ToModel(this List<User> users)
        {
            List<UserModel> model = new List<UserModel>();

            if (users != null && users.Any())
            {
                model = users.Select(x => x.ToModel()).ToList();
            }

            return model;
        }

        public static User ToDomain(this UserModel model)
        {
            if (model == null)
            {
                return new User();
            }

            User domain = new User()
            {
                UserName = model.UserName,
                Password = model.Password,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserTypeId = 2 //Defaults the user to an employee. Will be adding admin features later
            };

            return domain;
        }

        #endregion
        #region SalesType

        public static SalesTypesModel ToModel(this SalesTypes domain)
        {
            if (domain == null)
            {
                return new SalesTypesModel();
            }

            SalesTypesModel model = new SalesTypesModel()
            {
                SaleTypeId = domain.SaleTypeId,
                TypeName = domain.TypeName,
                SalesByType = domain.SalesByType
            };

            return model;
        }

        public static List<SalesTypesModel> ToModel(this List<SalesTypes> domain)
        {
            List<SalesTypesModel> model = new List<SalesTypesModel>();

            if (domain != null && domain.Any())
            {
                model = domain.Select(x => x.ToModel()).ToList();
            }

            return model;
        }

        public static SalesTypes ToDomain(this SalesTypesModel model)
        {
            if (model == null)
            {
                return new SalesTypes();
            }

            SalesTypes domain = new SalesTypes()
            {
                TypeName = model.TypeName,
                SalesByType = model.SalesByType
            };

            return domain;
        }

        #endregion
    }
}