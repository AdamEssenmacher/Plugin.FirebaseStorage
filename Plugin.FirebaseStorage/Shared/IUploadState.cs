using System;

namespace Plugin.FirebaseStorage
{
    public interface IUploadState
    {
        long BytesTransferred { get; }
        long TotalByteCount { get; }
        IStorageReference Reference { get; }
        IStorageMetadata? Metadata { get; }
        Exception? Error { get; }
    }
}
