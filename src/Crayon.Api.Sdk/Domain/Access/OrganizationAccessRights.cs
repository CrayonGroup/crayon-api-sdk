using System;

namespace Crayon.Api.Sdk.Domain.Access
{
    [Flags]
    public enum OrganizationAccessRole
    {
        //Does not have any access rights
        None = 0,

        //Users can edit organization information
        User = 1,

        //Administrators can add new users
        Administrator = 2,

        //Viewers can view producs for organization
        Viewer = 4,

        EditRights = User | Administrator,
        All = User | Administrator | Viewer
    }
}