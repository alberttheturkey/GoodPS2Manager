using System;
using System.Runtime.Serialization;

namespace GoodPS2Manager
{
    [Serializable]
    internal class ImageFileDoesNotExistException : Exception
    {
        public ImageFileDoesNotExistException()
        {
        }

        public ImageFileDoesNotExistException(string message) : base(message)
        {
        }

        public ImageFileDoesNotExistException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ImageFileDoesNotExistException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class ImageFileIncorrectExtensionException : Exception
    {
        public ImageFileIncorrectExtensionException()
        {
        }

        public ImageFileIncorrectExtensionException(string message) : base(message)
        {
        }

        public ImageFileIncorrectExtensionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ImageFileIncorrectExtensionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}