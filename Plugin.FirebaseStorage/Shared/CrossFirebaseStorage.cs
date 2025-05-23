using System;
namespace Plugin.FirebaseStorage
{
    /// <summary>
    /// Cross FirebaseStorage
    /// </summary>
    public static class CrossFirebaseStorage
    {
        private static readonly Lazy<IFirebaseStorage?> Implementation = new Lazy<IFirebaseStorage?>(() => CreateFirebaseStorage(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => Implementation.Value == null ? false : true;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static IFirebaseStorage Current
        {
            get
            {
                IFirebaseStorage? ret = Implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IFirebaseStorage CreateFirebaseStorage()
        {
            return new FirebaseStorageImplementation();
        }

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

    }
}
