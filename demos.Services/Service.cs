using demos.Data;


namespace demos.Services
{
    public abstract class Service
    {
  

        public Service()
        {
            this.Context = new DemoContext();
        }

        protected DemoContext Context { get; }
    }
}
