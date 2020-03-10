using OA.DomainEntity;
using OA.Repository.Layer;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.ServiceLayer
{
    public class UserProfileService : IUserProfileService
    {
        private IRepository<UserProfile> userProfileRepository;

        public UserProfileService(IRepository<UserProfile> userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }
        public UserProfile GetUserProfile(long id)
        {
           return userProfileRepository.Get(id);
        }
    }
}
