namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component _component)
        {
            component = _component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
