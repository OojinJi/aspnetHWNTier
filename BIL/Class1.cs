using DAL;
namespace BIL
{
    public class Class1
    {
        List<CustomerB> custL = GetCustomer_DAL();
        foreach(CustomerA c in custL)
        {
            c.home = "USA";
        }
        public List<CustomerA> GetCustomer_BLL()
        {
            return custL;
        }

    }
}