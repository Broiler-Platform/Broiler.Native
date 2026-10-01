// SPDX-FileCopyrightText: 2026 Broiler Platform contributors
// SPDX-License-Identifier: Apache-2.0
//
// Broiler Code Assurance
// ----------------------
// Relevant units:   27
// Annotated:        27/27
// Exempt:           25
// Human-reviewed:   0/27
// IP risk:          Low
// Security risk:    Critical
// Criteria:         27/27
// Resource impact:  6/10 max
// Unverified:       27
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
// Broiler-Falsified-If: an import here differs from its prototype in GLES3/gl3.h, where GLenum, GLuint and GLbitfield are unsigned int, GLint and GLsizei are int, and GLfloat is khronos_float_t
// Broiler-Human:        PENDING
public static partial class AndroidGlesNative
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

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=AD9690
    // Broiler-Falsified-If: count is other than 1 although textures is one GLuint, through which void glGenTextures(GLsizei n, GLuint *textures) in GLES3/gl3.h writes n names
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGenTextures")]
    public static partial void GenTextures(int count, out uint textures);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=0A6CA2
    // Broiler-Falsified-If: count is other than 1 although textures is one GLuint, from which void glDeleteTextures(GLsizei n, const GLuint *textures) in GLES3/gl3.h reads n names
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glDeleteTextures")]
    public static partial void DeleteTextures(int count, ref uint textures);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=38241C
    // Broiler-Falsified-If: differs from void glBindTexture(GLenum target, GLuint texture) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glBindTexture")]
    public static partial void BindTexture(int target, uint texture);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=A34865
    // Broiler-Falsified-If: differs from void glTexParameteri(GLenum target, GLenum pname, GLint param) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glTexParameteri")]
    public static partial void TexParameteri(int target, int name, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=A9CDA8
    // Broiler-Falsified-If: a non-null pixels points at fewer bytes than width by height pixels of format and type take with GL_UNPACK_ALIGNMENT row padding, against void glTexImage2D(GLenum target, GLint level, GLint internalformat, GLsizei width, GLsizei height, GLint border, GLenum format, GLenum type, const void *pixels) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glTexImage2D")]
    public static partial void TexImage2D(int target, int level, int internalFormat,
        int width, int height, int border, int format, int type, IntPtr pixels);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=4EFD10
    // Broiler-Falsified-If: count is other than 1 although framebuffers is one GLuint, through which void glGenFramebuffers(GLsizei n, GLuint *framebuffers) in GLES3/gl3.h writes n names
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGenFramebuffers")]
    public static partial void GenFramebuffers(int count, out uint framebuffers);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=1; Fingerprint=9D2CF0
    // Broiler-Falsified-If: count is other than 1 although framebuffers is one GLuint, from which void glDeleteFramebuffers(GLsizei n, const GLuint *framebuffers) in GLES3/gl3.h reads n names
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glDeleteFramebuffers")]
    public static partial void DeleteFramebuffers(int count, ref uint framebuffers);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=BC9CAF
    // Broiler-Falsified-If: differs from void glBindFramebuffer(GLenum target, GLuint framebuffer) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glBindFramebuffer")]
    public static partial void BindFramebuffer(int target, uint framebuffer);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=EC63D1
    // Broiler-Falsified-If: differs from void glFramebufferTexture2D(GLenum target, GLenum attachment, GLenum textarget, GLuint texture, GLint level) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glFramebufferTexture2D")]
    public static partial void FramebufferTexture2D(int target, int attachment, int textureTarget, uint texture, int level);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=3C9771
    // Broiler-Falsified-If: differs from GLenum glCheckFramebufferStatus(GLenum target) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glCheckFramebufferStatus")]
    public static partial uint CheckFramebufferStatus(int target);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=71E586
    // Broiler-Falsified-If: differs from void glViewport(GLint x, GLint y, GLsizei width, GLsizei height) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glViewport")]
    public static partial void Viewport(int x, int y, int width, int height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D00842
    // Broiler-Falsified-If: differs from void glClearColor(GLfloat red, GLfloat green, GLfloat blue, GLfloat alpha) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glClearColor")]
    public static partial void ClearColor(float red, float green, float blue, float alpha);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=2; Fingerprint=10E14B
    // Broiler-Falsified-If: differs from void glClear(GLbitfield mask) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glClear")]
    public static partial void Clear(int mask);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=6; Fingerprint=944115
    // Broiler-Falsified-If: pixels points at fewer bytes than width by height pixels of format and type take with GL_PACK_ALIGNMENT row padding, against void glReadPixels(GLint x, GLint y, GLsizei width, GLsizei height, GLenum format, GLenum type, void *pixels) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glReadPixels")]
    public static partial void ReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels);

    /// <summary>OpenGL ES 3.0 and later only.</summary>
    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=4; Fingerprint=EFD1E6
    // Broiler-Falsified-If: differs from void glBlitFramebuffer(GLint srcX0, GLint srcY0, GLint srcX1, GLint srcY1, GLint dstX0, GLint dstY0, GLint dstX1, GLint dstY1, GLbitfield mask, GLenum filter) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glBlitFramebuffer")]
    public static partial void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, 
        int dstX0, int dstY0, int dstX1, int dstY1, int mask, int filter);

    // Broiler-AI:           Origin=AI; IP=Low; Security=Critical; Resources=0; Fingerprint=8D640E
    // Broiler-Falsified-If: differs from void glPixelStorei(GLenum pname, GLint param) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glPixelStorei")]
    public static partial void PixelStorei(int name, int value);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=E9E50C
    // Broiler-Falsified-If: differs from void glEnable(GLenum cap) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glEnable")]
    public static partial void Enable(int capability);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D5E5DF
    // Broiler-Falsified-If: differs from void glDisable(GLenum cap) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glDisable")]
    public static partial void Disable(int capability);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=5190C4
    // Broiler-Falsified-If: differs from void glScissor(GLint x, GLint y, GLsizei width, GLsizei height) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glScissor")]
    public static partial void Scissor(int x, int y, int width, int height);

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=1; Fingerprint=17C3C7
    // Broiler-Falsified-If: differs from void glFlush(void) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glFlush")]
    public static partial void Flush();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=3; Fingerprint=539514
    // Broiler-Falsified-If: differs from void glFinish(void) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glFinish")]
    public static partial void Finish();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=F60C77
    // Broiler-Falsified-If: differs from GLenum glGetError(void) in GLES3/gl3.h
    // Broiler-Human:        PENDING
    [LibraryImport(AndroidNativeLibraries.Gles, EntryPoint = "glGetError")]
    public static partial int GetError();

    // Broiler-AI:           Origin=AI; IP=Low; Security=High; Resources=0; Fingerprint=D8D88A
    // Broiler-Falsified-If: the result of const GLubyte *glGetString(GLenum name) in GLES3/gl3.h, a string the GL owns, is marshalled as a managed string and freed instead of returned as a pointer
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
