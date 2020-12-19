
using System.Threading;

namespace OnlinePhotoUI
{
    internal static class DemoHelper
    {
       /// Brief delay to slow browser interaction
       public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
