using System;

namespace Broiler.Native.Android;

/// <summary>An EGL or OpenGL ES operation failed.</summary>
public sealed class AndroidOpenGlEsException : InvalidOperationException
{
    public AndroidOpenGlEsException(string message) : base(message) { }

    public AndroidOpenGlEsException(string message, Exception innerException) : base(message, innerException) { }
}
