// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   52
// Annotated:        52/52
// Exempt:           0
// Human-reviewed:   0/52
// IP risk:          Low
// Security risk:    Critical
// Criteria:         52/31
// Resource impact:  6/10 max
// Unverified:       52
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Android;

/// <summary>
/// The OpenGL ES entry points this backend uses, imported directly rather than loaded through
/// <c>eglGetProcAddress</c>.
/// </summary>
/// <remarks>
/// The set is deliberately small. Broiler rasterizes every frame on the CPU
/// in the graphics component and the GPU's only job is to upload that frame as a texture and
/// blit it to the window — there is no shader pipeline, no vertex data, and no draw call. Adding
/// one later is a separate decision, not a prerequisite.
///
/// <c>glBlitFramebuffer</c> is the one call that fixes the feature floor: it is ES 3.0, not ES 2.0.
/// An ES 2 fallback would have to draw a textured quad instead, which needs the shader pipeline this
/// backend otherwise avoids.
/// </remarks>
// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=1454CE
// Broiler-Falsified-If: the seven arguments reach glReadPixels out of order, so format and type arrive swapped and the driver writes another number of bytes per pixel through the caller's pixels pointer
// Broiler-Human:        PENDING
public static partial class AndroidGlesNative
{
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=18A47D
    // Broiler-Falsified-If: the value is not 0, the GL_NO_ERROR that glGetError returns when no flag is set, so ThrowIfError throws after a successful operation
    // Broiler-Human:        PENDING
    public const int GL_NO_ERROR = 0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=486868
    // Broiler-Falsified-If: the value is not 0x0DE1 (GL_TEXTURE_2D in gl3.h), so BindTexture and TexImage2D with it raise GL_INVALID_ENUM and the frame is never uploaded
    // Broiler-Human:        PENDING
    public const int GL_TEXTURE_2D = 0x0DE1;
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=11D122
    // Broiler-Falsified-If: the value is not 0x1908 (GL_RGBA), so ReadPixels or TexImage2D moves a different number of bytes per pixel through a buffer the caller sized at four
    // Broiler-Human:        PENDING
    public const int GL_RGBA = 0x1908;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=616C07
    // Broiler-Falsified-If: the value is not 0x8058 (GL_RGBA8), so TexImage2D allocates storage that GL_RGBA with GL_UNSIGNED_BYTE cannot upload into and raises GL_INVALID_OPERATION
    // Broiler-Human:        PENDING
    public const int GL_RGBA8 = 0x8058;
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=6D0452
    // Broiler-Falsified-If: the value is not 0x1401 (GL_UNSIGNED_BYTE), so ReadPixels with GL_RGBA writes more than four bytes per pixel into the caller's buffer, sixteen for GL_FLOAT
    // Broiler-Human:        PENDING
    public const int GL_UNSIGNED_BYTE = 0x1401;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=ED3B88
    // Broiler-Falsified-If: the value is not 0x2801 (GL_TEXTURE_MIN_FILTER), so TexParameteri sets another parameter and the texture keeps its mipmapped default minification filter
    // Broiler-Human:        PENDING
    public const int GL_TEXTURE_MIN_FILTER = 0x2801;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=464BAE
    // Broiler-Falsified-If: the value is not 0x2800 (GL_TEXTURE_MAG_FILTER), so TexParameteri with it raises GL_INVALID_ENUM and the next ThrowIfError blames an unrelated operation
    // Broiler-Human:        PENDING
    public const int GL_TEXTURE_MAG_FILTER = 0x2800;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=E8912E
    // Broiler-Falsified-If: the value is not 0x2802 (GL_TEXTURE_WRAP_S), so horizontal wrapping stays GL_REPEAT and edge texels sample from the opposite side
    // Broiler-Human:        PENDING
    public const int GL_TEXTURE_WRAP_S = 0x2802;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=0DF071
    // Broiler-Falsified-If: the value is not 0x2803 (GL_TEXTURE_WRAP_T), so vertical wrapping stays GL_REPEAT and edge texels sample from the opposite side
    // Broiler-Human:        PENDING
    public const int GL_TEXTURE_WRAP_T = 0x2803;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=6B549F
    // Broiler-Falsified-If: the value is not 0x2601 (GL_LINEAR), so the filter parameters set with it raise GL_INVALID_ENUM or select nearest sampling
    // Broiler-Human:        PENDING
    public const int GL_LINEAR = 0x2601;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=7E8CAD
    // Broiler-Falsified-If: the value is not 0x2600 (GL_NEAREST), so BlitFramebuffer with it as the filter raises GL_INVALID_ENUM and the frame is not copied to the window
    // Broiler-Human:        PENDING
    public const int GL_NEAREST = 0x2600;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=1CAE98
    // Broiler-Falsified-If: the value is not 0x812F (GL_CLAMP_TO_EDGE), so the wrap parameters set with it raise GL_INVALID_ENUM and stay GL_REPEAT
    // Broiler-Human:        PENDING
    public const int GL_CLAMP_TO_EDGE = 0x812F;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=63A28A
    // Broiler-Falsified-If: the value is not 0x8D40 (GL_FRAMEBUFFER), so BindFramebuffer, FramebufferTexture2D and CheckFramebufferStatus with it raise GL_INVALID_ENUM and the texture is never attached
    // Broiler-Human:        PENDING
    public const int GL_FRAMEBUFFER = 0x8D40;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F6251B
    // Broiler-Falsified-If: the value is not 0x8CA8 (GL_READ_FRAMEBUFFER), so ReadPixels and BlitFramebuffer read from whichever framebuffer was bound for reading before, not the uploaded frame
    // Broiler-Human:        PENDING
    public const int GL_READ_FRAMEBUFFER = 0x8CA8;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=62E432
    // Broiler-Falsified-If: the value is not 0x8CA9 (GL_DRAW_FRAMEBUFFER), so BlitFramebuffer writes into the offscreen texture instead of the window's default framebuffer
    // Broiler-Human:        PENDING
    public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=46BB0D
    // Broiler-Falsified-If: the value is not 0x8CE0 (GL_COLOR_ATTACHMENT0), so FramebufferTexture2D attaches the texture elsewhere and the framebuffer has no colour attachment
    // Broiler-Human:        PENDING
    public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=F456FE
    // Broiler-Falsified-If: the value is not 0x8CD5 (GL_FRAMEBUFFER_COMPLETE), so the status of a complete framebuffer does not compare equal to it and every upload is rejected
    // Broiler-Human:        PENDING
    public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=DB1E23
    // Broiler-Falsified-If: the value is not 0x4000 (GL_COLOR_BUFFER_BIT), so Clear and BlitFramebuffer with it act on depth or stencil and the window's colour is neither cleared nor copied
    // Broiler-Human:        PENDING
    public const int GL_COLOR_BUFFER_BIT = 0x4000;
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=6C18C1
    // Broiler-Falsified-If: the value is not 0x0D05 (GL_PACK_ALIGNMENT), so the pack alignment stays 4 and ReadPixels pads rows whose byte width is not a multiple of 4 past a tightly sized buffer
    // Broiler-Human:        PENDING
    public const int GL_PACK_ALIGNMENT = 0x0D05;
    // Broiler-AI:           Origin=AI; IP=None; Security=Critical; Resources=0; Fingerprint=80D3CE
    // Broiler-Falsified-If: the value is not 0x0CF5 (GL_UNPACK_ALIGNMENT), so the unpack alignment stays 4 and TexImage2D reads padded rows past a tightly sized buffer when a row is not a multiple of 4 bytes
    // Broiler-Human:        PENDING
    public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
    // Broiler-AI:           Origin=AI; IP=None; Security=Medium; Resources=0; Fingerprint=D94511
    // Broiler-Falsified-If: the value is not 0x0C11 (GL_SCISSOR_TEST), so Disable leaves a scissor box set elsewhere active and Clear and BlitFramebuffer touch only part of the window
    // Broiler-Human:        PENDING
    public const int GL_SCISSOR_TEST = 0x0C11;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=FA360B
    // Broiler-Falsified-If: the value is not 0x1F00 (GL_VENDOR), so GetStringValue returns another driver string or an empty one as the vendor
    // Broiler-Human:        PENDING
    public const uint GL_VENDOR = 0x1F00;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=8CE1CD
    // Broiler-Falsified-If: the value is not 0x1F01 (GL_RENDERER), so GetStringValue returns another driver string or an empty one as the renderer
    // Broiler-Human:        PENDING
    public const uint GL_RENDERER = 0x1F01;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=DC1AB2
    // Broiler-Falsified-If: the value is not 0x1F02 (GL_VERSION), so GetStringValue returns another driver string or an empty one as the version
    // Broiler-Human:        PENDING
    public const uint GL_VERSION = 0x1F02;
    // Broiler-AI:           Origin=AI; IP=None; Security=Low; Resources=0; Fingerprint=E87C00
    // Broiler-Falsified-If: the value is not 0x8B8C (GL_SHADING_LANGUAGE_VERSION), so GetStringValue returns another driver string or an empty one as the GLSL version
    // Broiler-Human:        PENDING
    public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=AD9690
    // Broiler-Falsified-If: a count above 1 makes glGenTextures write count names through the single out uint, past the caller's 4-byte slot
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGenTextures")]
    public static partial void GenTextures(int count, out uint textures);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0A6CA2
    // Broiler-Falsified-If: a count above 1 makes glDeleteTextures read count names past the single ref uint and delete whatever textures the adjacent bytes name
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glDeleteTextures")]
    public static partial void DeleteTextures(int count, ref uint textures);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=38241C
    // Broiler-Falsified-If: the target and texture name reach glBindTexture swapped, so binding texture 1 to GL_TEXTURE_2D raises GL_INVALID_ENUM and binds nothing
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glBindTexture")]
    public static partial void BindTexture(int target, uint texture);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A34865
    // Broiler-Falsified-If: the parameter name and value reach glTexParameteri swapped, so setting GL_TEXTURE_MIN_FILTER to GL_LINEAR raises GL_INVALID_ENUM and the filter stays mipmapped
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glTexParameteri")]
    public static partial void TexParameteri(int target, int name, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=A9CDA8
    // Broiler-Falsified-If: the nine arguments reach glTexImage2D out of order, so format and type arrive swapped and the driver reads another number of bytes per pixel from the caller's pixels pointer
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glTexImage2D")]
    public static partial void TexImage2D(int target, int level, int internalFormat,
        int width, int height, int border, int format, int type, IntPtr pixels);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=4EFD10
    // Broiler-Falsified-If: a count above 1 makes glGenFramebuffers write count names through the single out uint, past the caller's 4-byte slot
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGenFramebuffers")]
    public static partial void GenFramebuffers(int count, out uint framebuffers);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=9D2CF0
    // Broiler-Falsified-If: a count above 1 makes glDeleteFramebuffers read count names past the single ref uint and delete whatever framebuffers the adjacent bytes name
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glDeleteFramebuffers")]
    public static partial void DeleteFramebuffers(int count, ref uint framebuffers);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BC9CAF
    // Broiler-Falsified-If: the target and framebuffer name reach glBindFramebuffer swapped, so binding framebuffer 1 to GL_READ_FRAMEBUFFER raises GL_INVALID_ENUM and leaves the default bound
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glBindFramebuffer")]
    public static partial void BindFramebuffer(int target, uint framebuffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EC63D1
    // Broiler-Falsified-If: the texture name and level reach glFramebufferTexture2D in swapped positions, so attaching texture 3 at level 0 leaves the framebuffer incomplete
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glFramebufferTexture2D")]
    public static partial void FramebufferTexture2D(int target, int attachment, int textureTarget, uint texture, int level);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3C9771
    // Broiler-Falsified-If: the GLenum status comes back through a return other than a 32-bit unsigned value, so a complete framebuffer does not compare equal to GL_FRAMEBUFFER_COMPLETE
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glCheckFramebufferStatus")]
    public static partial uint CheckFramebufferStatus(int target);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=71E586
    // Broiler-Falsified-If: the x, y, width and height reach glViewport in another order, so a 1080 by 1920 viewport is set as 1920 by 1080
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glViewport")]
    public static partial void Viewport(int x, int y, int width, int height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D00842
    // Broiler-Falsified-If: the four float components reach glClearColor in an order other than red, green, blue, alpha, so a clear to opaque red reads back as another colour
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glClearColor")]
    public static partial void ClearColor(float red, float green, float blue, float alpha);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=10E14B
    // Broiler-Falsified-If: the mask reaches glClear as a value other than the bitfield passed, so a GL_COLOR_BUFFER_BIT clear leaves the colour buffer unchanged
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glClear")]
    public static partial void Clear(int mask);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=944115
    // Broiler-Falsified-If: the seven arguments reach glReadPixels out of order, so format and type arrive swapped and the driver writes another number of bytes per pixel through the caller's pixels pointer
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glReadPixels")]
    public static partial void ReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels);

    /// <summary>OpenGL ES 3.0 and later only.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=EFD1E6
    // Broiler-Falsified-If: the ten arguments reach glBlitFramebuffer out of order, so a 640 by 480 source blitted to 1280 by 960 copies another rectangle or treats the filter as the mask
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glBlitFramebuffer")]
    public static partial void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, 
        int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=8D640E
    // Broiler-Falsified-If: the name and value reach glPixelStorei swapped, so GL_PACK_ALIGNMENT stays 4 and ReadPixels pads rows past a buffer sized for alignment 1
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glPixelStorei")]
    public static partial void PixelStorei(int name, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E9E50C
    // Broiler-Falsified-If: the import binds to an entry point other than glEnable, so Enable(GL_SCISSOR_TEST) leaves scissoring off
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glEnable")]
    public static partial void Enable(int capability);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D5E5DF
    // Broiler-Falsified-If: the import binds to an entry point other than glDisable, so Disable(GL_SCISSOR_TEST) leaves a scissor box clipping the clear and the blit
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glDisable")]
    public static partial void Disable(int capability);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5190C4
    // Broiler-Falsified-If: the x, y, width and height reach glScissor in another order, so a 100 by 50 box at the origin clips a 50 by 100 region instead
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glScissor")]
    public static partial void Scissor(int x, int y, int width, int height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=17C3C7
    // Broiler-Falsified-If: the import binds to an entry point other than glFlush, for example glFinish, so the call blocks until the GPU drains instead of returning after submission
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glFlush")]
    public static partial void Flush();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=539514
    // Broiler-Falsified-If: Finish returns while commands issued before it are still executing on the GPU
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glFinish")]
    public static partial void Finish();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F60C77
    // Broiler-Falsified-If: after a call that raises GL_INVALID_ENUM, the first GetError returns something other than 0x500
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGetError")]
    public static partial int GetError();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D8D88A
    // Broiler-Falsified-If: the const GLubyte* result is declared narrower than a pointer, so on arm64 GetStringValue reads a driver string from a truncated address
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGetString")]
    public static partial IntPtr GetString(uint name);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=46DE45
    // Broiler-Falsified-If: a null pointer from glGetString, returned for an invalid name or with no current context, reaches PtrToStringAnsi instead of yielding an empty string
    // Broiler-Human:        PENDING
    public static string GetStringValue(uint name)
    {
        IntPtr pointer = GetString(name);
        return pointer == IntPtr.Zero ? string.Empty : Marshal.PtrToStringAnsi(pointer) ?? string.Empty;
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=A25A60
    // Broiler-Falsified-If: a second error flag still queued after the single glGetError read survives and makes the next, successful operation's check throw
    // Broiler-Human:        PENDING
    public static void ThrowIfError(string operation)
    {
        int error = GetError();
        if (error != GL_NO_ERROR)
            throw new AndroidOpenGlEsException($"{operation} failed with OpenGL ES error 0x{error:X}.");
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=10652C
    // Broiler-Falsified-If: two of the GL_VENDOR, GL_RENDERER, GL_VERSION and GL_SHADING_LANGUAGE_VERSION queries are passed in swapped positions, so Renderer holds the version string
    // Broiler-Human:        PENDING
    public static AndroidOpenGlEsDriverInfo GetDriverInfo() => new(
            GetStringValue(GL_VENDOR),
            GetStringValue(GL_RENDERER),
            GetStringValue(GL_VERSION),
            GetStringValue(GL_SHADING_LANGUAGE_VERSION));
}
