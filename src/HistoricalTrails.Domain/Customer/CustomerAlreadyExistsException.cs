using Volo.Abp;

namespace HistoricalTrails.Users
{
    public class CustomerAlreadyExistsException : BusinessException
    {
        public CustomerAlreadyExistsException(string name):base(HistoricalTrailsDomainErrorCodes.CustomerAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
