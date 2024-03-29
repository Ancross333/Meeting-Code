namespace Domain.User
{
    public class UserAddress
    {
        public int Id { get; private set; }
        public int UserId { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public string City { get; private set; }
        public string State {  get; private set; }

        public UserAddress(int userId, string addressLine1, string addressLine2, string city, string state)
        {
            UserId = userId;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
        }
    }
}
