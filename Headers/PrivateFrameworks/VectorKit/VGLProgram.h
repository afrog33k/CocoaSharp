/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#import "NSObject.h"

#import "NSCopying-Protocol.h"

@class VGLContext, VGLFragmentShader, VGLResource, VGLVertexShader;

// Not exported
@interface VGLProgram : NSObject <NSCopying>
{
    VGLResource *_resource;
    VGLContext *_context;
    int _uMatrix;
    CDUnion_f5b85e25 _matrix;
    VGLVertexShader *_vert;
    VGLFragmentShader *_frag;
    struct vector<UniformHandle, vk_allocator<UniformHandle>> _handlesVector;
    VGLContext *_lastUsedContext;
}

+ (id)fragName;
+ (id)vertName;
+ (id)programWithContext:(id)arg1;
@property(nonatomic) VGLContext *context; // @synthesize context=_context;
@property(nonatomic) CDUnion_f5b85e25 matrix; // @synthesize matrix=_matrix;
- (id).cxx_construct;
- (void).cxx_destruct;
- (void)setUniformFloatVec:(int)arg1 curr:(float *)arg2 next:(const float *)arg3 count:(int)arg4;
- (void)setUniformFloat:(int)arg1 curr:(float *)arg2 next:(float)arg3;
- (void)setUniformIntVec:(int)arg1 curr:(int *)arg2 next:(const int *)arg3 count:(int)arg4;
- (void)setUniformInt:(int)arg1 curr:(int *)arg2 next:(int)arg3;
- (void)setUniformMat4:(int)arg1 curr:(CDUnion_f5b85e25 *)arg2 next:(const CDUnion_f5b85e25 *)arg3;
- (void)setUniformMat3:(int)arg1 curr:(CDUnion_2b8b3256 *)arg2 next:(const CDUnion_2b8b3256 *)arg3;
- (void)setUniformMat2:(int)arg1 curr:(CDUnion_552b2134 *)arg2 next:(const CDUnion_552b2134 *)arg3;
- (void)setUniformVec4:(int)arg1 curr:(CDStruct_818bb265 *)arg2 next:(const CDStruct_818bb265 *)arg3;
- (void)setUniformVec3:(int)arg1 curr:(CDStruct_03942939 *)arg2 next:(const CDStruct_03942939 *)arg3;
- (void)setUniformVec2:(int)arg1 curr:(Vec2Imp_1782d7e3 *)arg2 next:(const Vec2Imp_1782d7e3 *)arg3;
- (void)setUniformColor:(int)arg1 curr:(struct _VGLColor *)arg2 next:(const struct _VGLColor *)arg3;
- (void)printInfoLog;
- (_Bool)link;
- (int)uniformLocation:(const char *)arg1;
- (void)dirtyUniformCaches;
- (void)dealloc;
- (id)copyWithZone:(struct _NSZone *)arg1;
- (id)initWithResourceFactory:(id)arg1;
- (void)setup;
- (id)_init;
- (id)init;
- (_Bool)_attachBindLink;
- (void)bindAttributes;
@property(readonly, nonatomic) unsigned int token;
- (void)willBeUsedWithContext:(id)arg1;

@end

