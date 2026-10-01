// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   29
// Annotated:        29/29
// Exempt:           67
// Human-reviewed:   0/29
// IP risk:          Low
// Security risk:    Critical
// Criteria:         29/29
// Resource impact:  6/10 max
// Unverified:       29
//
// GENERATED - DO NOT EDIT MANUALLY

using System;
using System.Runtime.InteropServices;

namespace Broiler.Native.Linux.OpenGL;

// Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=B1E919
// Broiler-Falsified-If: GlReadPixelsProc's seven declared parameters differ in order from glReadPixels(x, y, width, height, format, type, pixels), so format and type arrive swapped and the driver writes another number of bytes per pixel through the pixels pointer
// Broiler-Human:        PENDING
public sealed class LinuxOpenGlFunctions
{
    public const int GL_NO_ERROR = 0;
    public const int GL_TEXTURE_2D = 0x0DE1;
    public const int GL_RGBA = 0x1908;
    public const int GL_RGBA8 = 0x8058;
    public const int GL_UNSIGNED_BYTE = 0x1401;
    public const int GL_TEXTURE_MIN_FILTER = 0x2801;
    public const int GL_TEXTURE_MAG_FILTER = 0x2800;
    public const int GL_TEXTURE_WRAP_S = 0x2802;
    public const int GL_TEXTURE_WRAP_T = 0x2803;
    public const int GL_LINEAR = 0x2601;
    public const int GL_NEAREST = 0x2600;
    public const int GL_CLAMP_TO_EDGE = 0x812F;
    public const int GL_FRAMEBUFFER = 0x8D40;
    public const int GL_READ_FRAMEBUFFER = 0x8CA8;
    public const int GL_DRAW_FRAMEBUFFER = 0x8CA9;
    public const int GL_COLOR_ATTACHMENT0 = 0x8CE0;
    public const int GL_FRAMEBUFFER_COMPLETE = 0x8CD5;
    public const int GL_COLOR_BUFFER_BIT = 0x4000;
    public const int GL_PACK_ALIGNMENT = 0x0D05;
    public const int GL_UNPACK_ALIGNMENT = 0x0CF5;
    public const int GL_SCISSOR_TEST = 0x0C11;
    public const uint GL_VENDOR = 0x1F00;
    public const uint GL_RENDERER = 0x1F01;
    public const uint GL_VERSION = 0x1F02;
    public const uint GL_SHADING_LANGUAGE_VERSION = 0x8B8C;

    private readonly GlGenTexturesProc _genTextures;
    private readonly GlDeleteTexturesProc _deleteTextures;
    private readonly GlBindTextureProc _bindTexture;
    private readonly GlTexParameteriProc _texParameteri;
    private readonly GlTexImage2DProc _texImage2D;
    private readonly GlGenFramebuffersProc _genFramebuffers;
    private readonly GlDeleteFramebuffersProc _deleteFramebuffers;
    private readonly GlBindFramebufferProc _bindFramebuffer;
    private readonly GlFramebufferTexture2DProc _framebufferTexture2D;
    private readonly GlCheckFramebufferStatusProc _checkFramebufferStatus;
    private readonly GlViewportProc _viewport;
    private readonly GlClearColorProc _clearColor;
    private readonly GlClearProc _clear;
    private readonly GlReadPixelsProc _readPixels;
    private readonly GlBlitFramebufferProc _blitFramebuffer;
    private readonly GlPixelStoreiProc _pixelStorei;
    private readonly GlEnableProc _enable;
    private readonly GlDisableProc _disable;
    private readonly GlScissorProc _scissor;
    private readonly GlFlushProc _flush;
    private readonly GlGetErrorProc _getError;
    private readonly GlGetStringProc _getString;

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=A9BC99
    // Broiler-Falsified-If: an entry-point name is paired with a delegate type whose parameter list differs from that function's gl.h prototype (for example glReadPixels loaded as GlTexImage2DProc), so calls through that field hand the driver a mismatched argument list
    // Broiler-Human:        PENDING
    private LinuxOpenGlFunctions()
    {
        _genTextures = Load<GlGenTexturesProc>("glGenTextures");
        _deleteTextures = Load<GlDeleteTexturesProc>("glDeleteTextures");
        _bindTexture = Load<GlBindTextureProc>("glBindTexture");
        _texParameteri = Load<GlTexParameteriProc>("glTexParameteri");
        _texImage2D = Load<GlTexImage2DProc>("glTexImage2D");
        _genFramebuffers = Load<GlGenFramebuffersProc>("glGenFramebuffers");
        _deleteFramebuffers = Load<GlDeleteFramebuffersProc>("glDeleteFramebuffers");
        _bindFramebuffer = Load<GlBindFramebufferProc>("glBindFramebuffer");
        _framebufferTexture2D = Load<GlFramebufferTexture2DProc>("glFramebufferTexture2D");
        _checkFramebufferStatus = Load<GlCheckFramebufferStatusProc>("glCheckFramebufferStatus");
        _viewport = Load<GlViewportProc>("glViewport");
        _clearColor = Load<GlClearColorProc>("glClearColor");
        _clear = Load<GlClearProc>("glClear");
        _readPixels = Load<GlReadPixelsProc>("glReadPixels");
        _blitFramebuffer = Load<GlBlitFramebufferProc>("glBlitFramebuffer");
        _pixelStorei = Load<GlPixelStoreiProc>("glPixelStorei");
        _enable = Load<GlEnableProc>("glEnable");
        _disable = Load<GlDisableProc>("glDisable");
        _scissor = Load<GlScissorProc>("glScissor");
        _flush = Load<GlFlushProc>("glFlush");
        _getError = Load<GlGetErrorProc>("glGetError");
        _getString = Load<GlGetStringProc>("glGetString");
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=9FD27C
    // Broiler-Falsified-If: it returns a function table when no EGL context is current on the calling thread, and the first GL call through that table dispatches into a driver with no context bound
    // Broiler-Human:        PENDING
    public static LinuxOpenGlFunctions LoadCurrentContext() => new();

    public void GenTextures(int n, out uint texture) => _genTextures(n, out texture);

    public void DeleteTextures(int n, ref uint texture) => _deleteTextures(n, ref texture);

    public void BindTexture(int target, uint texture) => _bindTexture(target, texture);

    public void TexParameteri(int target, int pname, int param) => _texParameteri(target, pname, param);

    public void TexImage2D(int target, int level, int internalFormat, int width, int height, int border, int format, int type, IntPtr pixels) =>
        _texImage2D(target, level, internalFormat, width, height, border, format, type, pixels);

    public void GenFramebuffers(int n, out uint framebuffer) => _genFramebuffers(n, out framebuffer);

    public void DeleteFramebuffers(int n, ref uint framebuffer) => _deleteFramebuffers(n, ref framebuffer);

    public void BindFramebuffer(int target, uint framebuffer) => _bindFramebuffer(target, framebuffer);

    public void FramebufferTexture2D(int target, int attachment, int textureTarget, uint texture, int level) =>
        _framebufferTexture2D(target, attachment, textureTarget, texture, level);

    public uint CheckFramebufferStatus(int target) => _checkFramebufferStatus(target);

    public void Viewport(int x, int y, int width, int height) => _viewport(x, y, width, height);

    public void ClearColor(float red, float green, float blue, float alpha) => _clearColor(red, green, blue, alpha);

    public void Clear(int mask) => _clear(mask);

    public void ReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels) =>
        _readPixels(x, y, width, height, format, type, pixels);

    public void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter) =>
        _blitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

    public void PixelStorei(int pname, int param) => _pixelStorei(pname, param);

    public void Enable(int cap) => _enable(cap);

    public void Disable(int cap) => _disable(cap);

    public void Scissor(int x, int y, int width, int height) => _scissor(x, y, width, height);

    public void Flush() => _flush();

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=525EF7
    // Broiler-Falsified-If: a NULL from glGetString, returned when no context is current, is passed to PtrToStringAnsi or reported as an empty string rather than as unavailable
    // Broiler-Human:        PENDING
    public string GetString(uint name)
    {
        IntPtr value = _getString(name);
        return value == IntPtr.Zero
            ? "unavailable"
            : Marshal.PtrToStringAnsi(value) ?? "unavailable";
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=2; Fingerprint=AAF5FB
    // Broiler-Falsified-If: two of the GL_VENDOR, GL_RENDERER, GL_VERSION and GL_SHADING_LANGUAGE_VERSION queries are passed in swapped positions, so Renderer holds the version string
    // Broiler-Human:        PENDING
    public LinuxOpenGlDriverInfo GetDriverInfo() =>
        new(GetString(GL_VENDOR), GetString(GL_RENDERER), GetString(GL_VERSION), GetString(GL_SHADING_LANGUAGE_VERSION));

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=470A06
    // Broiler-Falsified-If: glGetError is read only once, so when several error flags are recorded the remaining ones survive and a later ThrowIfError reports them against an unrelated operation
    // Broiler-Human:        PENDING
    public void ThrowIfError(string operation)
    {
        uint error = _getError();
        if (error != GL_NO_ERROR)
            throw new LinuxOpenGlException($"{operation} failed with OpenGL error 0x{error:X}.");
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0A9223
    // Broiler-Falsified-If: a function name the driver does not implement still yields a non-zero pointer from eglGetProcAddress, which EGL permits, so Load returns a delegate and the first call jumps into an unsupported entry
    // Broiler-Human:        PENDING
    private static TDelegate Load<TDelegate>(string name) where TDelegate : Delegate
    {
        IntPtr address = LinuxEglNative.GetProcAddress(name);
        if (address == IntPtr.Zero)
            throw new LinuxOpenGlException($"OpenGL function {name} is not available from eglGetProcAddress.");

        return Marshal.GetDelegateForFunctionPointer<TDelegate>(address);
    }

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=A6564B
    // Broiler-Falsified-If: n greater than 1 makes glGenTextures write n texture names through the out pointer to a single uint, overwriting the caller's memory after it
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlGenTexturesProc(int n, out uint textures);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=987158
    // Broiler-Falsified-If: n greater than 1 makes glDeleteTextures read n names through the ref pointer to a single uint and delete textures named by whatever memory follows it
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlDeleteTexturesProc(int n, ref uint textures);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=86B3EB
    // Broiler-Falsified-If: the declared parameters differ from glBindTexture(GLenum target, GLuint texture), for example a 64-bit texture name, so on 32-bit x86 the driver reads the name from the wrong stack slot
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlBindTextureProc(int target, uint texture);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=72149D
    // Broiler-Falsified-If: the declared parameters differ from glTexParameteri(GLenum, GLenum, GLint), for example a float param, so the filter or wrap value arrives in a floating-point register the driver never reads
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlTexParameteriProc(int target, int pname, int param);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=53B054
    // Broiler-Falsified-If: the nine declared parameters differ in order from glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels), so format and type arrive swapped and the driver reads another number of bytes per pixel from the pixels pointer
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlTexImage2DProc(int target, int level, int internalFormat, int width, int height, int border, int format, int type, IntPtr pixels);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=918023
    // Broiler-Falsified-If: n greater than 1 makes glGenFramebuffers write n framebuffer names through the out pointer to a single uint, overwriting the caller's memory after it
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlGenFramebuffersProc(int n, out uint framebuffers);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=74B8E4
    // Broiler-Falsified-If: n greater than 1 makes glDeleteFramebuffers read n names through the ref pointer to a single uint and delete framebuffers named by whatever memory follows it
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlDeleteFramebuffersProc(int n, ref uint framebuffers);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E22C59
    // Broiler-Falsified-If: the declared parameters differ from glBindFramebuffer(GLenum target, GLuint framebuffer), for example a 64-bit framebuffer name, so on 32-bit x86 the driver reads the name from the wrong stack slot
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlBindFramebufferProc(int target, uint framebuffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=89CAEA
    // Broiler-Falsified-If: the five declared parameters differ in order from glFramebufferTexture2D(target, attachment, textarget, texture, level), so the texture name is passed as the mip level and the attachment stays empty
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlFramebufferTexture2DProc(int target, int attachment, int textureTarget, uint texture, int level);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=7B20CF
    // Broiler-Falsified-If: the return type is not the 32-bit unsigned GLenum of glCheckFramebufferStatus, so the returned status never equals GL_FRAMEBUFFER_COMPLETE (0x8CD5) and a complete framebuffer is rejected
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate uint GlCheckFramebufferStatusProc(int target);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=45AE3A
    // Broiler-Falsified-If: the declared parameters differ from glViewport(GLint x, GLint y, GLsizei width, GLsizei height), for example width and height swapped, so a non-square surface renders into a transposed viewport
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlViewportProc(int x, int y, int width, int height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=181780
    // Broiler-Falsified-If: a component is declared as double instead of the gl.h GLfloat, so the driver reads red, green, blue and alpha from the wrong floating-point registers or stack slots
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlClearColorProc(float red, float green, float blue, float alpha);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=ED39A6
    // Broiler-Falsified-If: the mask is not passed as the 32-bit GLbitfield of glClear(GLbitfield mask), so GL_COLOR_BUFFER_BIT arrives as a different bit set and the colour buffer is not cleared
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlClearProc(int mask);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=4D8968
    // Broiler-Falsified-If: the seven declared parameters differ in order from glReadPixels(x, y, width, height, format, type, pixels), so format and type arrive swapped and the driver writes another number of bytes per pixel through the pixels pointer
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlReadPixelsProc(int x, int y, int width, int height, int format, int type, IntPtr pixels);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=2FE5E1
    // Broiler-Falsified-If: the ten declared parameters differ in order from glBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter), so the source and destination rectangles are swapped or the filter is read as a coordinate
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlBlitFramebufferProc(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=C7EF03
    // Broiler-Falsified-If: the declared parameters differ from glPixelStorei(GLenum pname, GLint param), for example param before pname, so the row alignment of 1 is never set and later pixel transfers assume padded rows
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlPixelStoreiProc(int pname, int param);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=DE694A
    // Broiler-Falsified-If: the cap is not passed as the 32-bit GLenum of glEnable(GLenum cap), so GL_SCISSOR_TEST is not enabled and a later glClear covers the whole framebuffer
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlEnableProc(int cap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=524E32
    // Broiler-Falsified-If: the cap is not passed as the 32-bit GLenum of glDisable(GLenum cap), so GL_SCISSOR_TEST stays enabled and later clears and blits are clipped to a stale rectangle
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlDisableProc(int cap);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EB992B
    // Broiler-Falsified-If: the declared parameters differ from glScissor(GLint x, GLint y, GLsizei width, GLsizei height), for example width and height swapped, so a clear meant for one rectangle paints a transposed one
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlScissorProc(int x, int y, int width, int height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=89AA1E
    // Broiler-Falsified-If: the delegate declares an argument or result that glFlush(void) does not have, so the call marshals a value the driver entry never takes or returns a register value it never set
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate void GlFlushProc();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=8ACE41
    // Broiler-Falsified-If: the return type is not the 32-bit unsigned GLenum of glGetError(void), so an error such as GL_OUT_OF_MEMORY (0x0505) reaches ThrowIfError truncated or as zero
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate uint GlGetErrorProc();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=C7F9A4
    // Broiler-Falsified-If: the const GLubyte pointer return is declared as a 32-bit int, so on 64-bit Linux the driver's string address is truncated before GetString reads it
    // Broiler-Human:        PENDING
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    private delegate IntPtr GlGetStringProc(uint name);
}
