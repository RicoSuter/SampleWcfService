using System.ServiceModel;

namespace SampleWcfService
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        int Sum(int a, int b);
    }
}
