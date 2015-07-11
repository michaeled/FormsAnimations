using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsAnimations
{
    public static class MoreAnimationExtensions
    {
        public async static Task RelMoveHorizontally(this VisualElement view, double offset, uint duration, Easing easing = null)
        {
            var pos = view.Bounds;

            await view.LayoutTo(new Rectangle(pos.X + offset, view.Y, view.Width, view.Height), duration, easing);
        }
    }
}
