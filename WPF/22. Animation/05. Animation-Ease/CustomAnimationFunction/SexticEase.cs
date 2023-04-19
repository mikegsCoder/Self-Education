using System.Windows.Media.Animation;
using System.Windows;

namespace CustomAnimationFunction
{
    public class SexticEase : EasingFunctionBase
    {
        protected override double EaseInCore(double normalizedTime)
        {
            return normalizedTime * normalizedTime * normalizedTime
                   * normalizedTime * normalizedTime * normalizedTime;
        }

        protected override Freezable CreateInstanceCore()
        {
            return new SexticEase();
        }
    }
}
