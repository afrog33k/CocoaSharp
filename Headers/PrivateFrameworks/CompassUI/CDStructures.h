/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#pragma mark Named Structures

struct CGPoint {
    double x;
    double y;
};

struct CGRect {
    struct CGPoint origin;
    struct CGSize size;
};

struct CGSize {
    double width;
    double height;
};

struct Vec3Imp<double> {
    double x;
    double y;
    double z;
};

struct __tree_end_node<std::__1::__tree_node_base<void *>*> {
    struct __tree_node_base<void *> *__left_;
};

struct map<std::__1::basic_string<char>, CGRect, std::__1::less<std::__1::basic_string<char>>, std::__1::allocator<std::__1::pair<const std::__1::basic_string<char>, CGRect>>> {
    struct __tree<std::__1::pair<std::__1::basic_string<char>, CGRect>, std::__1::__map_value_compare<std::__1::basic_string<char>, CGRect, std::__1::less<std::__1::basic_string<char>>, true>, std::__1::allocator<std::__1::pair<std::__1::basic_string<char>, CGRect>>> {
        struct __tree_node<std::__1::pair<std::__1::basic_string<char>, CGRect>, void *> *__begin_node_;
        struct __compressed_pair<std::__1::__tree_end_node<std::__1::__tree_node_base<void *>*>, std::__1::allocator<std::__1::__tree_node<std::__1::pair<std::__1::basic_string<char>, CGRect>, void *>>> {
            struct __tree_end_node<std::__1::__tree_node_base<void *>*> __first_;
        } __pair1_;
        struct __compressed_pair<unsigned long, std::__1::__map_value_compare<std::__1::basic_string<char>, CGRect, std::__1::less<std::__1::basic_string<char>>, true>> {
            unsigned long long __first_;
        } __pair3_;
    } __tree_;
};

struct map<std::__1::basic_string<char>, int, std::__1::less<std::__1::basic_string<char>>, std::__1::allocator<std::__1::pair<const std::__1::basic_string<char>, int>>> {
    struct __tree<std::__1::pair<std::__1::basic_string<char>, int>, std::__1::__map_value_compare<std::__1::basic_string<char>, int, std::__1::less<std::__1::basic_string<char>>, true>, std::__1::allocator<std::__1::pair<std::__1::basic_string<char>, int>>> {
        struct __tree_node<std::__1::pair<std::__1::basic_string<char>, int>, void *> *__begin_node_;
        struct __compressed_pair<std::__1::__tree_end_node<std::__1::__tree_node_base<void *>*>, std::__1::allocator<std::__1::__tree_node<std::__1::pair<std::__1::basic_string<char>, int>, void *>>> {
            struct __tree_end_node<std::__1::__tree_node_base<void *>*> __first_;
        } __pair1_;
        struct __compressed_pair<unsigned long, std::__1::__map_value_compare<std::__1::basic_string<char>, int, std::__1::less<std::__1::basic_string<char>>, true>> {
            unsigned long long __first_;
        } __pair3_;
    } __tree_;
};

#pragma mark Typedef'd Structures

typedef struct {
    float _field1;
    float _field2;
    float _field3;
    float _field4;
} CDStruct_818bb265;

typedef struct {
    struct CGRect _field1;
    struct CGPoint _field2;
    struct CGPoint _field3;
    struct CGPoint _field4;
    struct CGPoint _field5;
} CDStruct_cfd1ab65;

#pragma mark Named Unions

union _GLKMatrix4 {
    struct {
        float m00;
        float m01;
        float m02;
        float m03;
        float m10;
        float m11;
        float m12;
        float m13;
        float m20;
        float m21;
        float m22;
        float m23;
        float m30;
        float m31;
        float m32;
        float m33;
    } ;
    float m[16];
};

