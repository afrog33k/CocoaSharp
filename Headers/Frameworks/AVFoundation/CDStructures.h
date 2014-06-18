/*
 *     Generated by class-dump 3.3.4 (64 bit).
 *
 *     class-dump is Copyright (C) 1997-1998, 2000-2001, 2004-2011 by Steve Nygard.
 */

#pragma mark Named Structures

struct AVAudioPlayerCpp {
    struct __CFData *_field1;
    struct __CFURL *_field2;
    struct __CFDictionary *_field3;
    struct AudioStreamBasicDescription _field4;
    struct AudioStreamBasicDescription _field5;
    unsigned long long _field6;
    char *_field7;
    unsigned int _field8;
    struct AudioFormatListItem *_field9;
    unsigned int _field10;
    struct OpaqueAudioFileID *_field11;
    struct OpaqueAudioQueue *_field12;
    long long _field13;
    long long _field14;
    long long _field15;
    double _field16;
    double _field17;
    double _field18;
    unsigned int _field19;
    double _field20;
    int _field21;
    struct AudioFilePacketTableInfo _field22;
    int _field23;
    int _field24;
    _Bool _field25;
    _Bool _field26;
    _Bool _field27;
    _Bool _field28;
    unsigned int _field29;
    _Bool _field30;
    _Bool _field31;
    _Bool _field32;
    _Bool _field33;
    double _field34;
    double _field35;
    double _field36;
    double _field37;
    double _field38;
    double _field39;
    unsigned int _field40;
    struct AudioQueueLevelMeterState *_field41;
    struct AudioQueueBuffer *_field42[3];
    struct AudioQueueBuffer *_field43;
    int _field44;
    _Bool _field45;
    _Bool _field46;
    _Bool _field47;
    _Bool _field48;
    _Bool _field49;
    struct AudioQueueBuffer *_field50;
    _Bool _field51;
    unsigned long long _field52;
    _Bool _field53;
    _Bool _field54;
    _Bool _field55;
    _Bool _field56;
    long long _field57;
    int _field58;
    unsigned int _field59;
    unsigned int _field60;
    void *_field61;
    void *_field62;
    unsigned int _field63;
    struct AudioChannelLayout *_field64;
    unsigned int _field65;
    struct TEMP_AudioQueueChannelAssignment *_field66;
};

struct AVAudioSessionImpl {
    struct GenericRunLoopThread *_field1;
    id _field2;
    id _field3;
    struct KVOProperty<float> _field4;
    struct KVOProperty<float> _field5;
    struct KVONSArrayProperty _field6;
    struct KVONSArrayProperty _field7;
    struct KVOProperty<unsigned int> _field8;
    struct KVONSObjectProperty<NSArray *> _field9;
    struct KVOProperty<unsigned int> _field10;
    id _field11;
    _Bool _field12;
    struct KVOProperty<unsigned int> _field13;
    struct KVOProperty<unsigned int> _field14;
};

struct AudioChannelLayout;

struct AudioFilePacketTableInfo {
    long long _field1;
    int _field2;
    int _field3;
};

struct AudioFormatListItem;

struct AudioQueueBuffer {
    unsigned int _field1;
    void *_field2;
    unsigned int _field3;
    void *_field4;
    unsigned int _field5;
    struct AudioStreamPacketDescription *_field6;
    unsigned int _field7;
};

struct AudioQueueLevelMeterState;

struct AudioRecorderImpl {
    id _field1;
    id _field2;
    id _field3;
    id _field4;
    id _field5;
    unsigned int _field6;
    struct AudioStreamBasicDescription _field7;
    struct OpaqueAudioFileID *_field8;
    struct OpaqueAudioQueue *_field9;
    long long _field10;
    long long _field11;
    long long _field12;
    double _field13;
    double _field14;
    double _field15;
    unsigned long long _field16;
    char *_field17;
    _Bool _field18;
    _Bool _field19;
    _Bool _field20;
    _Bool _field21;
    _Bool _field22;
    _Bool _field23;
    _Bool _field24;
    struct AudioQueueLevelMeterState *_field25;
    struct AudioQueueBuffer *_field26[4];
    struct AudioQueueBuffer *_field27;
    _Bool _field28;
    unsigned long long _field29;
    _Bool _field30;
};

struct AudioStreamBasicDescription {
    double _field1;
    unsigned int _field2;
    unsigned int _field3;
    unsigned int _field4;
    unsigned int _field5;
    unsigned int _field6;
    unsigned int _field7;
    unsigned int _field8;
    unsigned int _field9;
};

struct AudioStreamPacketDescription {
    long long _field1;
    unsigned int _field2;
    unsigned int _field3;
};

struct CAStreamBasicDescription {
    double _field1;
    unsigned int _field2;
    unsigned int _field3;
    unsigned int _field4;
    unsigned int _field5;
    unsigned int _field6;
    unsigned int _field7;
    unsigned int _field8;
    unsigned int _field9;
};

struct ChannelDescriptionImpl {
    id _field1;
    id _field2;
    unsigned int _field3;
    unsigned int _field4;
};

struct ControllerImpl {
    void **_field1;
    id _field2;
    id _field3;
    struct CAStreamBasicDescription _field4;
    double _field5;
    _Bool _field6;
    struct AudioQueueLevelMeterState *_field7;
    struct OpaqueAudioQueue *_field8;
    int _field9;
    struct OpaqueAudioConverter *_field10;
    unsigned int _field11;
    unsigned int _field12;
    unsigned int _field13;
    unsigned int _field14;
    struct AudioQueueBuffer **_field15;
    unsigned long long _field16;
    int _field17;
    int _field18;
    _Bool _field19;
    struct MemorySyncBool _field20;
    _Bool _field21;
    float _field22;
    id _field23;
    unsigned int _field24;
    id _field25;
    id _field26;
    struct CAStreamBasicDescription _field27;
    double _field28;
    struct OpaqueAudioQueue *_field29;
    int _field30;
    id _field31;
    unsigned int _field32;
    struct AudioQueueBuffer **_field33;
    int _field34;
    _Bool _field35;
    _Bool _field36;
    _Bool _field37;
    _Bool _field38;
    struct MemorySyncBool _field39;
    _Bool _field40;
    float _field41;
    unsigned int _field42;
    struct CAStreamBasicDescription _field43;
    long long _field44;
    struct OpaqueAudioQueue *_field45;
    struct map<AVVoiceAlertType, NSURL *, std::__1::less<AVVoiceAlertType>, std::__1::allocator<std::__1::pair<const AVVoiceAlertType, NSURL *>>> _field46;
    struct map<AVVoiceAlertType, AudioQueueBuffer *, std::__1::less<AVVoiceAlertType>, std::__1::allocator<std::__1::pair<const AVVoiceAlertType, AudioQueueBuffer *>>> _field47;
    _Bool _field48;
    int _field49;
    float _field50;
    double _field51;
    unsigned long long _field52;
    float _field53;
    float _field54;
    struct OpaqueAudioQueue *_field55;
    id _field56;
    struct OpaqueAudioFileID *_field57;
    unsigned int _field58;
    struct AudioFormatListItem *_field59;
    unsigned int _field60;
    unsigned long long _field61;
    char *_field62;
    struct AudioFilePacketTableInfo _field63;
    long long _field64;
    long long _field65;
    _Bool _field66;
    int _field67;
    int _field68;
    id _field69;
    _Bool _field70;
    _Bool _field71;
    _Bool _field72;
    _Bool _field73;
    int _field74;
    double _field75;
    double _field76;
    double _field77;
    _Bool _field78;
    _Bool _field79;
    id _field80;
    unsigned char _field81;
    int _field82;
    _Bool _field83;
    int _field84;
    _Bool _field85;
    _Bool _field86;
    struct _opaque_pthread_mutex_t {
        long long _field1;
        char _field2[56];
    } _field87[5];
    int _field88;
};

struct DataSourceDescriptionImpl {
    id _field1;
    id _field2;
    id _field3;
    id _field4;
    id _field5;
    id _field6;
    id _field7;
};

struct GenericRunLoopThread;

struct KVONSArrayProperty {
    void **_field1;
    id _field2;
    _Bool _field3;
    id _field4;
};

struct KVONSObjectProperty<NSArray *> {
    void **_field1;
    id _field2;
    _Bool _field3;
    id _field4;
};

struct KVOProperty<float> {
    void **_field1;
    float _field2;
    _Bool _field3;
    id _field4;
};

struct KVOProperty<unsigned int> {
    void **_field1;
    unsigned int _field2;
    _Bool _field3;
    id _field4;
};

struct MemorySyncBool {
    _Bool _field1;
};

struct MyAudioQueueBuffer {
    unsigned int _field1;
    void *_field2;
    unsigned int _field3;
    void *_field4;
    unsigned int _field5;
    struct AudioStreamPacketDescription *_field6;
    unsigned int _field7;
};

struct OpaqueAudioConverter;

struct OpaqueAudioFileID;

struct OpaqueAudioQueue;

struct PortDescriptionImpl {
    id _field1;
    id _field2;
    id _field3;
    id _field4;
    _Bool _field5;
    id _field6;
    id _field7;
    id _field8;
};

struct RouteDescriptionImpl {
    id _field1;
    id _field2;
};

struct TEMP_AudioQueueChannelAssignment;

struct __tree_end_node<std::__1::__tree_node_base<void *>*> {
    struct __tree_node_base<void *> *_field1;
};

struct map<AVVoiceAlertType, AudioQueueBuffer *, std::__1::less<AVVoiceAlertType>, std::__1::allocator<std::__1::pair<const AVVoiceAlertType, AudioQueueBuffer *>>> {
    struct __tree<std::__1::pair<AVVoiceAlertType, AudioQueueBuffer *>, std::__1::__map_value_compare<AVVoiceAlertType, AudioQueueBuffer *, std::__1::less<AVVoiceAlertType>, true>, std::__1::allocator<std::__1::pair<AVVoiceAlertType, AudioQueueBuffer *>>> {
        struct __tree_node<std::__1::pair<AVVoiceAlertType, AudioQueueBuffer *>, void *> *_field1;
        struct __compressed_pair<std::__1::__tree_end_node<std::__1::__tree_node_base<void *>*>, std::__1::allocator<std::__1::__tree_node<std::__1::pair<AVVoiceAlertType, AudioQueueBuffer *>, void *>>> {
            struct __tree_end_node<std::__1::__tree_node_base<void *>*> _field1;
        } _field2;
        struct __compressed_pair<unsigned long, std::__1::__map_value_compare<AVVoiceAlertType, AudioQueueBuffer *, std::__1::less<AVVoiceAlertType>, true>> {
            unsigned long long _field1;
        } _field3;
    } _field1;
};

struct map<AVVoiceAlertType, NSURL *, std::__1::less<AVVoiceAlertType>, std::__1::allocator<std::__1::pair<const AVVoiceAlertType, NSURL *>>> {
    struct __tree<std::__1::pair<AVVoiceAlertType, NSURL *>, std::__1::__map_value_compare<AVVoiceAlertType, NSURL *, std::__1::less<AVVoiceAlertType>, true>, std::__1::allocator<std::__1::pair<AVVoiceAlertType, NSURL *>>> {
        struct __tree_node<std::__1::pair<AVVoiceAlertType, NSURL *>, void *> *_field1;
        struct __compressed_pair<std::__1::__tree_end_node<std::__1::__tree_node_base<void *>*>, std::__1::allocator<std::__1::__tree_node<std::__1::pair<AVVoiceAlertType, NSURL *>, void *>>> {
            struct __tree_end_node<std::__1::__tree_node_base<void *>*> _field1;
        } _field2;
        struct __compressed_pair<unsigned long, std::__1::__map_value_compare<AVVoiceAlertType, NSURL *, std::__1::less<AVVoiceAlertType>, true>> {
            unsigned long long _field1;
        } _field3;
    } _field1;
};

