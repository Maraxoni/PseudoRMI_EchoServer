using CoreWCF;

namespace PseudoRMI_EchoServer
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string input);
    }
}
