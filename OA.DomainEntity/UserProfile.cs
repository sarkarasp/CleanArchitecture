namespace OA.DomainEntity
{
    public class UserProfile : BaseEntity
    {
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Address { get; set; }
        public virtual User user { get; set; }
    }
}