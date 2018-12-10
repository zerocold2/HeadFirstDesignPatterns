namespace DesignPatterns.Structure_Pattern.Adapter
{
    //Changes the implementation to make request compatable with other classes, without change the behaviours
    public class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }
        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}