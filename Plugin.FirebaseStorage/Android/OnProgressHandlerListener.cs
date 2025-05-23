using Firebase.Storage;

namespace Plugin.FirebaseStorage
{
    internal delegate void OnProgressHandler(Java.Lang.Object snapshot);

    internal class OnProgressHandlerListener : Java.Lang.Object, IOnProgressListener
    {
        private readonly OnProgressHandler _handler;

        public OnProgressHandlerListener(OnProgressHandler handler)
        {
            _handler = handler;
        }

        public void snapshot(Java.Lang.Object p0)
        {
            _handler.Invoke(p0);
        }
    }
}
