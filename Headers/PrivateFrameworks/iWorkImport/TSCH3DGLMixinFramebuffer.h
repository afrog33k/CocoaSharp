/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import <iWorkImport/TSCH3DGLFramebuffer.h>

// Not exported
@interface TSCH3DGLMixinFramebuffer : TSCH3DGLFramebuffer
{
    TSCH3DGLFramebuffer *mOriginal;
}

@property(retain, nonatomic) TSCH3DGLFramebuffer *original; // @synthesize original=mOriginal;
- (void)disableSamplingInSession:(id)arg1;
- (id)GLHandleForSession:(id)arg1;
- (void)discardBuffers;
- (void)discardDepthBuffer;
- (void)discardColorBuffer;
- (_Bool)isProtectedInSession:(id)arg1;
- (void)unprotectInSession:(id)arg1 clearOnFailProtection:(_Bool)arg2;
- (void)protectInSession:(id)arg1 unprotectOnFail:(_Bool)arg2;
- (_Bool)validForSession:(id)arg1;
- (void)destroyResourcesInSession:(id)arg1;
- (void)bindColorbufferInSession:(id)arg1;
- (unsigned long long)estimatedMemroyInBytes;
- (unsigned int)type;
- (tvec2_3b141483)size;
- (id)output;
- (void)wipe:(const tvec4_ac57c72d *)arg1;
- (void)clean;
- (void)clear:(unsigned int)arg1;
- (void)setDepthFunction:(int)arg1;
- (void)setDepthMask:(unsigned char)arg1;
- (void)setClearDepth:(float)arg1;
- (void)setColorMask:(const tvec4_d23a2b6e *)arg1;
- (void)setClearColor:(const tvec4_ac57c72d *)arg1;
- (_Bool)isTexturable;
- (id)context;
- (_Bool)activateInsideSession:(id)arg1;
- (_Bool)bindInSession:(id)arg1;
- (const struct FramebufferAttributes *)framebufferAttributes;
- (id)description;
- (void)dealloc;
- (id)initWithContext:(id)arg1 size:(const tvec2_3b141483 *)arg2 attributes:(const struct FramebufferAttributes *)arg3;

@end

