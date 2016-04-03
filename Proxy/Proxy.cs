namespace Proxy
{
    public class Proxy : IResourceHungryObject
    {
        private int customParameter;

        public Proxy()
        {
            RealObject = new RealObject();
        }

        public RealObject RealObject { get; private set; }

        public void DoIt()
        {
            RealObject.SetParameter(customParameter);
            RealObject.DoIt();
        }

        public void SetParameter(int parameter)
        {
            this.customParameter = parameter;
        }
    }
}
