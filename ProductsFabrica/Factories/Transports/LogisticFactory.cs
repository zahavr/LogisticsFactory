using LogisticsFactory.Interfaces;

namespace LogisticsFactory.Factories
{
	public abstract class LogisticFactory
    {
        public abstract ITransport Create();
    }
}
