﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoopenAPI.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CIMSDBContext : DbContext
    {
        public CIMSDBContext()
            : base("name=CIMSDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAcademicDetail> tblAcademicDetails { get; set; }
        public virtual DbSet<tblActiveUser> tblActiveUsers { get; set; }
        public virtual DbSet<tblCompany> tblCompanies { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblDesignation> tblDesignations { get; set; }
        public virtual DbSet<tblEligibility> tblEligibilities { get; set; }
        public virtual DbSet<tblGender> tblGenders { get; set; }
        public virtual DbSet<tblJobDescription> tblJobDescriptions { get; set; }
        public virtual DbSet<tblJobTitle> tblJobTitles { get; set; }
        public virtual DbSet<tblPackage> tblPackages { get; set; }
        public virtual DbSet<tblResetPasswordRequest> tblResetPasswordRequests { get; set; }
        public virtual DbSet<tblRole> tblRoles { get; set; }
        public virtual DbSet<tblSelectionProcess> tblSelectionProcesses { get; set; }
        public virtual DbSet<tblSkillSet> tblSkillSets { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<tblUserAddress> tblUserAddresses { get; set; }
        public virtual DbSet<tblUserInfo> tblUserInfoes { get; set; }
        public virtual DbSet<tblUserRole> tblUserRoles { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual ObjectResult<Nullable<int>> spActivateRegisteredUser(string mobile, string password, string email, string otp)
        {
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var otpParameter = otp != null ?
                new ObjectParameter("Otp", otp) :
                new ObjectParameter("Otp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spActivateRegisteredUser", mobileParameter, passwordParameter, emailParameter, otpParameter);
        }
    
        public virtual ObjectResult<spAuthenticateUser_Result> spAuthenticateUser(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAuthenticateUser_Result>("spAuthenticateUser", userNameParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spChangePassword(Nullable<System.Guid> gUID, string password)
        {
            var gUIDParameter = gUID.HasValue ?
                new ObjectParameter("GUID", gUID) :
                new ObjectParameter("GUID", typeof(System.Guid));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spChangePassword", gUIDParameter, passwordParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spChangePasswordUsingCurrentPassword(string userName, string currentPassword, string newPassword)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var currentPasswordParameter = currentPassword != null ?
                new ObjectParameter("CurrentPassword", currentPassword) :
                new ObjectParameter("CurrentPassword", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("NewPassword", newPassword) :
                new ObjectParameter("NewPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spChangePasswordUsingCurrentPassword", userNameParameter, currentPasswordParameter, newPasswordParameter);
        }
    
        public virtual ObjectResult<spGetAllLocakedUserAccounts_Result> spGetAllLocakedUserAccounts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllLocakedUserAccounts_Result>("spGetAllLocakedUserAccounts");
        }
    
        public virtual ObjectResult<Nullable<int>> spIsPasswordResetLinkValid(Nullable<System.Guid> gUID)
        {
            var gUIDParameter = gUID.HasValue ?
                new ObjectParameter("GUID", gUID) :
                new ObjectParameter("GUID", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spIsPasswordResetLinkValid", gUIDParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> spRegisterUser(string firstName, string lastName, string mobile, string email, string otp)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var otpParameter = otp != null ?
                new ObjectParameter("Otp", otp) :
                new ObjectParameter("Otp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spRegisterUser", firstNameParameter, lastNameParameter, mobileParameter, emailParameter, otpParameter);
        }
    
        public virtual ObjectResult<spResetPassword_Result> spResetPassword(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spResetPassword_Result>("spResetPassword", userNameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_ChangePasswordOnFirstLogin(string username, string currentPassword, string newPassword)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var currentPasswordParameter = currentPassword != null ?
                new ObjectParameter("CurrentPassword", currentPassword) :
                new ObjectParameter("CurrentPassword", typeof(string));
    
            var newPasswordParameter = newPassword != null ?
                new ObjectParameter("NewPassword", newPassword) :
                new ObjectParameter("NewPassword", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_ChangePasswordOnFirstLogin", usernameParameter, currentPasswordParameter, newPasswordParameter);
        }
    
        public virtual int usp_ConfirmEmail(string email, string otp, ObjectParameter isSuccess)
        {
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var otpParameter = otp != null ?
                new ObjectParameter("Otp", otp) :
                new ObjectParameter("Otp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ConfirmEmail", emailParameter, otpParameter, isSuccess);
        }
    
        public virtual int usp_ConfirmMobile(string mobile, string otp, ObjectParameter isSuccess)
        {
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var otpParameter = otp != null ?
                new ObjectParameter("Otp", otp) :
                new ObjectParameter("Otp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_ConfirmMobile", mobileParameter, otpParameter, isSuccess);
        }
    
        public virtual int usp_GetOtpFromDatabase(string mobile, string email, ObjectParameter otp)
        {
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetOtpFromDatabase", mobileParameter, emailParameter, otp);
        }
    
        public virtual int usp_SaveOtpInDatabase(string mobile, string email, string otp)
        {
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var otpParameter = otp != null ?
                new ObjectParameter("Otp", otp) :
                new ObjectParameter("Otp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_SaveOtpInDatabase", mobileParameter, emailParameter, otpParameter);
        }
    }
}
