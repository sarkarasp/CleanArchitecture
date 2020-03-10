using OA.DomainEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.ServiceLayer
{
   public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}
