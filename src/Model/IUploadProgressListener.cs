namespace ApiVideo.Upload
{
    /// <summary>
    /// Progress listener interface used to handle the chunk upload progress
    /// </summary>
    public interface IUploadProgressListener 
    {
        /// <summary>
        /// On progress method that can be called after each chunk upload
        /// </summary>
        /// <param name="bytesWritten">Total bytes already sent</param>
        /// <param name="totalBytes">Total bytes to send</param>
        /// <param name="chunkCount">Total chunks to upload</param>
        /// <param name="chunkNum">Current uploaded chunk number</param>
        void onProgress(long bytesWritten, long totalBytes, int chunkCount, int chunkNum);
    }
}
