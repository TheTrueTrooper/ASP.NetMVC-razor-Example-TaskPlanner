﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP.NetMVCExample.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MVCTaskMasterAppDataEntities2 : DbContext
    {
        public MVCTaskMasterAppDataEntities2()
            : base("name=MVCTaskMasterAppDataEntities2")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int CreateProject(string projectName, Nullable<int> companyID, Nullable<int> managerID, string address, string postalCode, string country, string province, string city, string description, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, ObjectParameter outID, ObjectParameter errorMessage)
        {
            var projectNameParameter = projectName != null ?
                new ObjectParameter("ProjectName", projectName) :
                new ObjectParameter("ProjectName", typeof(string));
    
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(int));
    
            var managerIDParameter = managerID.HasValue ?
                new ObjectParameter("ManagerID", managerID) :
                new ObjectParameter("ManagerID", typeof(int));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var provinceParameter = province != null ?
                new ObjectParameter("Province", province) :
                new ObjectParameter("Province", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateProject", projectNameParameter, companyIDParameter, managerIDParameter, addressParameter, postalCodeParameter, countryParameter, provinceParameter, cityParameter, descriptionParameter, startDateParameter, endDateParameter, outID, errorMessage);
        }
    
        public virtual int CreateTask(Nullable<int> subContractorID, Nullable<int> taskTypeID, Nullable<int> projectID, string description, Nullable<long> durationTicks, ObjectParameter outID, ObjectParameter errorMessage)
        {
            var subContractorIDParameter = subContractorID.HasValue ?
                new ObjectParameter("SubContractorID", subContractorID) :
                new ObjectParameter("SubContractorID", typeof(int));
    
            var taskTypeIDParameter = taskTypeID.HasValue ?
                new ObjectParameter("TaskTypeID", taskTypeID) :
                new ObjectParameter("TaskTypeID", typeof(int));
    
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var durationTicksParameter = durationTicks.HasValue ?
                new ObjectParameter("DurationTicks", durationTicks) :
                new ObjectParameter("DurationTicks", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateTask", subContractorIDParameter, taskTypeIDParameter, projectIDParameter, descriptionParameter, durationTicksParameter, outID, errorMessage);
        }
    
        public virtual int CreateTaskLink(Nullable<int> taskID, Nullable<int> nextTaskID, ObjectParameter outID, ObjectParameter errorMessage)
        {
            var taskIDParameter = taskID.HasValue ?
                new ObjectParameter("TaskID", taskID) :
                new ObjectParameter("TaskID", typeof(int));
    
            var nextTaskIDParameter = nextTaskID.HasValue ?
                new ObjectParameter("NextTaskID", nextTaskID) :
                new ObjectParameter("NextTaskID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateTaskLink", taskIDParameter, nextTaskIDParameter, outID, errorMessage);
        }
    
        public virtual ObjectResult<Nullable<bool>> CreateThePasswordResset(string email, string code)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("CreateThePasswordResset", emailParameter, codeParameter);
        }
    
        public virtual int CreateTheSession(Nullable<int> userID, string code)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateTheSession", userIDParameter, codeParameter);
        }
    
        public virtual int DeleteTheCompany(Nullable<int> companyID, ObjectParameter errorMessage)
        {
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTheCompany", companyIDParameter, errorMessage);
        }
    
        public virtual int DeleteTheRole(Nullable<int> roleID, ObjectParameter errorMessage)
        {
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTheRole", roleIDParameter, errorMessage);
        }
    
        public virtual int DeleteTheSession(Nullable<int> sessionID)
        {
            var sessionIDParameter = sessionID.HasValue ?
                new ObjectParameter("SessionID", sessionID) :
                new ObjectParameter("SessionID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTheSession", sessionIDParameter);
        }
    
        public virtual int DeleteTheUser(string firstName, string middleInitial, string lastName, string email, string password, string homePhone, string cellPhone, string workPhone, ObjectParameter errorMessage)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleInitialParameter = middleInitial != null ?
                new ObjectParameter("MiddleInitial", middleInitial) :
                new ObjectParameter("MiddleInitial", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var homePhoneParameter = homePhone != null ?
                new ObjectParameter("HomePhone", homePhone) :
                new ObjectParameter("HomePhone", typeof(string));
    
            var cellPhoneParameter = cellPhone != null ?
                new ObjectParameter("CellPhone", cellPhone) :
                new ObjectParameter("CellPhone", typeof(string));
    
            var workPhoneParameter = workPhone != null ?
                new ObjectParameter("WorkPhone", workPhone) :
                new ObjectParameter("WorkPhone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTheUser", firstNameParameter, middleInitialParameter, lastNameParameter, emailParameter, passwordParameter, homePhoneParameter, cellPhoneParameter, workPhoneParameter, errorMessage);
        }
    
        public virtual ObjectResult<Nullable<bool>> DoPasswordResset(string email, string code, string password, string salt)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var saltParameter = salt != null ?
                new ObjectParameter("Salt", salt) :
                new ObjectParameter("Salt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("DoPasswordResset", emailParameter, codeParameter, passwordParameter, saltParameter);
        }
    
        public virtual ObjectResult<string> GetTheSalt(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetTheSalt", emailParameter);
        }
    
        public virtual int InsertErrorInfo(string errorMessage, Nullable<byte> type, Nullable<byte> table, Nullable<int> sQLErrorCode, Nullable<int> myErrorCode)
        {
            var errorMessageParameter = errorMessage != null ?
                new ObjectParameter("ErrorMessage", errorMessage) :
                new ObjectParameter("ErrorMessage", typeof(string));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(byte));
    
            var tableParameter = table.HasValue ?
                new ObjectParameter("Table", table) :
                new ObjectParameter("Table", typeof(byte));
    
            var sQLErrorCodeParameter = sQLErrorCode.HasValue ?
                new ObjectParameter("SQLErrorCode", sQLErrorCode) :
                new ObjectParameter("SQLErrorCode", typeof(int));
    
            var myErrorCodeParameter = myErrorCode.HasValue ?
                new ObjectParameter("MyErrorCode", myErrorCode) :
                new ObjectParameter("MyErrorCode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertErrorInfo", errorMessageParameter, typeParameter, tableParameter, sQLErrorCodeParameter, myErrorCodeParameter);
        }
    
        public virtual int InsertNewCompany(string companyName, string description, string companySite, ObjectParameter errorMessage)
        {
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var companySiteParameter = companySite != null ?
                new ObjectParameter("CompanySite", companySite) :
                new ObjectParameter("CompanySite", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNewCompany", companyNameParameter, descriptionParameter, companySiteParameter, errorMessage);
        }
    
        public virtual int InsertNewOffice(Nullable<int> companyID, string country, string province, string city, string address, string postalCode, string phone, string fax, string name, ObjectParameter errorMessage)
        {
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(int));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var provinceParameter = province != null ?
                new ObjectParameter("Province", province) :
                new ObjectParameter("Province", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("Address", address) :
                new ObjectParameter("Address", typeof(string));
    
            var postalCodeParameter = postalCode != null ?
                new ObjectParameter("PostalCode", postalCode) :
                new ObjectParameter("PostalCode", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNewOffice", companyIDParameter, countryParameter, provinceParameter, cityParameter, addressParameter, postalCodeParameter, phoneParameter, faxParameter, nameParameter, errorMessage);
        }
    
        public virtual int InsertNewRole(Nullable<int> companyID, string roleName, Nullable<int> superRole, Nullable<bool> admin, ObjectParameter errorMessage)
        {
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(int));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var superRoleParameter = superRole.HasValue ?
                new ObjectParameter("SuperRole", superRole) :
                new ObjectParameter("SuperRole", typeof(int));
    
            var adminParameter = admin.HasValue ?
                new ObjectParameter("Admin", admin) :
                new ObjectParameter("Admin", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNewRole", companyIDParameter, roleNameParameter, superRoleParameter, adminParameter, errorMessage);
        }
    
        public virtual int InsertNewUser(string firstName, string middleInitial, string lastName, string email, string password, string salt, string primaryPhoneNumber, ObjectParameter errorMessage)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleInitialParameter = middleInitial != null ?
                new ObjectParameter("MiddleInitial", middleInitial) :
                new ObjectParameter("MiddleInitial", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var saltParameter = salt != null ?
                new ObjectParameter("Salt", salt) :
                new ObjectParameter("Salt", typeof(string));
    
            var primaryPhoneNumberParameter = primaryPhoneNumber != null ?
                new ObjectParameter("PrimaryPhoneNumber", primaryPhoneNumber) :
                new ObjectParameter("PrimaryPhoneNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNewUser", firstNameParameter, middleInitialParameter, lastNameParameter, emailParameter, passwordParameter, saltParameter, primaryPhoneNumberParameter, errorMessage);
        }
    
        public virtual ObjectResult<Nullable<bool>> IsEmailUsed(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("IsEmailUsed", emailParameter);
        }
    
        public virtual int PasswordCheck(string email, string password, ObjectParameter iDOut, ObjectParameter checksOut)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PasswordCheck", emailParameter, passwordParameter, iDOut, checksOut);
        }
    
        public virtual ObjectResult<SelectLinker_Result> SelectLinker(Nullable<int> linkerID)
        {
            var linkerIDParameter = linkerID.HasValue ?
                new ObjectParameter("LinkerID", linkerID) :
                new ObjectParameter("LinkerID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectLinker_Result>("SelectLinker", linkerIDParameter);
        }
    
        public virtual ObjectResult<SelectLinkerByTaskID_Result> SelectLinkerByTaskID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectLinkerByTaskID_Result>("SelectLinkerByTaskID", iDParameter);
        }
    
        public virtual ObjectResult<SelectLinkersByNextTask_Result> SelectLinkersByNextTask(Nullable<int> taskID)
        {
            var taskIDParameter = taskID.HasValue ?
                new ObjectParameter("TaskID", taskID) :
                new ObjectParameter("TaskID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectLinkersByNextTask_Result>("SelectLinkersByNextTask", taskIDParameter);
        }
    
        public virtual ObjectResult<SelectLinkersByTask_Result> SelectLinkersByTask(Nullable<int> taskID)
        {
            var taskIDParameter = taskID.HasValue ?
                new ObjectParameter("TaskID", taskID) :
                new ObjectParameter("TaskID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectLinkersByTask_Result>("SelectLinkersByTask", taskIDParameter);
        }
    
        public virtual ObjectResult<SelectProjectByID_Result> SelectProjectByID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProjectByID_Result>("SelectProjectByID", iDParameter);
        }
    
        public virtual ObjectResult<SelectProjectByID_Light_Result> SelectProjectByID_Light(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectProjectByID_Light_Result>("SelectProjectByID_Light", iDParameter);
        }
    
        public virtual ObjectResult<SelectTasksByProjectID_Result> SelectTasksByProjectID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectTasksByProjectID_Result>("SelectTasksByProjectID", iDParameter);
        }
    
        public virtual ObjectResult<SelectTheUser_Result> SelectTheUser(Nullable<int> iD, ObjectParameter errorMessage)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectTheUser_Result>("SelectTheUser", iDParameter, errorMessage);
        }
    
        public virtual ObjectResult<SelectUserProjects_Result> SelectUserProjects(Nullable<int> userID, ObjectParameter errorMessage)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectUserProjects_Result>("SelectUserProjects", userIDParameter, errorMessage);
        }
    
        public virtual int UpdateTheCompany(Nullable<int> companyID, string companyName, string description, string companySite, ObjectParameter errorMessage)
        {
            var companyIDParameter = companyID.HasValue ?
                new ObjectParameter("CompanyID", companyID) :
                new ObjectParameter("CompanyID", typeof(int));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var companySiteParameter = companySite != null ?
                new ObjectParameter("CompanySite", companySite) :
                new ObjectParameter("CompanySite", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTheCompany", companyIDParameter, companyNameParameter, descriptionParameter, companySiteParameter, errorMessage);
        }
    
        public virtual int UpdateTheRole(Nullable<int> rollID, string roleName, Nullable<int> superRole, Nullable<bool> admin, ObjectParameter errorMessage)
        {
            var rollIDParameter = rollID.HasValue ?
                new ObjectParameter("RollID", rollID) :
                new ObjectParameter("RollID", typeof(int));
    
            var roleNameParameter = roleName != null ?
                new ObjectParameter("RoleName", roleName) :
                new ObjectParameter("RoleName", typeof(string));
    
            var superRoleParameter = superRole.HasValue ?
                new ObjectParameter("SuperRole", superRole) :
                new ObjectParameter("SuperRole", typeof(int));
    
            var adminParameter = admin.HasValue ?
                new ObjectParameter("Admin", admin) :
                new ObjectParameter("Admin", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTheRole", rollIDParameter, roleNameParameter, superRoleParameter, adminParameter, errorMessage);
        }
    
        public virtual int UpdateTheUserChangePassword(Nullable<int> userID, string password, string newPassword, ObjectParameter errorMessage)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("NewPassword", newPassword) :
                new ObjectParameter("NewPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTheUserChangePassword", userIDParameter, passwordParameter, newPasswordParameter, errorMessage);
        }
    
        public virtual int UpdateTheUserInfo(Nullable<int> userID, string firstName, string middleInitial, string lastName, ObjectParameter errorMessage)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var middleInitialParameter = middleInitial != null ?
                new ObjectParameter("MiddleInitial", middleInitial) :
                new ObjectParameter("MiddleInitial", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTheUserInfo", userIDParameter, firstNameParameter, middleInitialParameter, lastNameParameter, errorMessage);
        }
    
        public virtual ObjectResult<Nullable<bool>> ValidateSession(Nullable<int> userID, string code)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("ValidateSession", userIDParameter, codeParameter);
        }
    
        public virtual ObjectResult<ValidateWithProjectViewPriv_Result> ValidateWithProjectViewPriv(Nullable<int> userID, string code, Nullable<int> projectID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(int));
    
            var codeParameter = code != null ?
                new ObjectParameter("Code", code) :
                new ObjectParameter("Code", typeof(string));
    
            var projectIDParameter = projectID.HasValue ?
                new ObjectParameter("ProjectID", projectID) :
                new ObjectParameter("ProjectID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ValidateWithProjectViewPriv_Result>("ValidateWithProjectViewPriv", userIDParameter, codeParameter, projectIDParameter);
        }
    }
}
