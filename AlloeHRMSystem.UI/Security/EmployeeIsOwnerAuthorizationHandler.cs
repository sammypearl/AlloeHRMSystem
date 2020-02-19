//using AlloeHRMSystem.Domain.Entities;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Authorization.Infrastructure;
//using Microsoft.AspNetCore.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace AlloeHRMSystem.UI.Security
//{
//    public class EmployeeIsOwnerAuthorizationHandler : 
//        AuthorizationHandler<OperationAuthorizationRequirement, Employee>
//    {
//        UserManager<IdentityUser> _userManager;

//        public EmployeeIsOwnerAuthorizationHandler(UserManager<IdentityUser>
//            userManager)
//        {
//            _userManager = userManager;
//        }

//        protected override Task
//            HandleRequirementAsync(AuthorizationHandlerContext context,
//                                   OperationAuthorizationRequirement requirement,
//                                   Employee resource)
//        {
//            if (context.User == null || resource == null)
//            {
//                return Task.CompletedTask;
//            }

//            // If not asking for CRUD permission, return.

//            if ( //requirement.Name != Constants.CreateOperationName &&
//                requirement.Name != Constants.ReadOperationName &&
//                requirement.Name != Constants.UpdateOperationName //&&
//               // requirement.Name != Constants.DeleteOperationName
//                )
//            {
//                return Task.CompletedTask;
//            }

//            if (resource.UserId == _userManager.GetUserId(context.User))
//            {
//                context.Succeed(requirement);
//            }

//            return Task.CompletedTask;
//        }
//    }

//    public static class EmployeeOperations
//    {
//        public static OperationAuthorizationRequirement Create =
//          new OperationAuthorizationRequirement { Name = Constants.CreateOperationName };
//        public static OperationAuthorizationRequirement Read =
//          new OperationAuthorizationRequirement { Name = Constants.ReadOperationName };
//        public static OperationAuthorizationRequirement Update =
//          new OperationAuthorizationRequirement { Name = Constants.UpdateOperationName };
//        public static OperationAuthorizationRequirement Delete =
//          new OperationAuthorizationRequirement { Name = Constants.DeleteOperationName };
//        public static OperationAuthorizationRequirement Approve =
//          new OperationAuthorizationRequirement { Name = Constants.ApproveOperationName };
//        public static OperationAuthorizationRequirement Reject =
//          new OperationAuthorizationRequirement { Name = Constants.RejectOperationName };
//    }

//    public class Constants
//    {
//        public static readonly string CreateOperationName = "Create";
//        public static readonly string ReadOperationName = "Read";
//        public static readonly string UpdateOperationName = "Update";
//        public static readonly string DeleteOperationName = "Delete";
//        public static readonly string ApproveOperationName = "Approve";
//        public static readonly string RejectOperationName = "Reject";

//        public static readonly string EmployeeAdministratorsRole =
//                                                              "EmployeeAdministrators";
//        public static readonly string EmployeeManagersRole = "EmployeeManagers";
//    }
//}
