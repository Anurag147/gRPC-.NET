// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/groom.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace gRoom.gRPC.Messages {

  /// <summary>Holder for reflection information generated from Protos/groom.proto</summary>
  public static partial class GroomReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/groom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3MvZ3Jvb20ucHJvdG8SBWdyb29tGh9nb29nbGUvcHJvdG9idWYv",
            "dGltZXN0YW1wLnByb3RvGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8i",
            "YAoPUmVjaWV2ZWRNZXNzYWdlEi0KCW5ld3NfdGltZRgBIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXASEAoIY29udGVudHMYAiABKAkSDAoEdXNl",
            "chgDIAEoCTJMCgVHcm9vbRJDCg9TdGFydE1vbml0b3JpbmcSFi5nb29nbGUu",
            "cHJvdG9idWYuRW1wdHkaFi5ncm9vbS5SZWNpZXZlZE1lc3NhZ2UwAUIWqgIT",
            "Z1Jvb20uZ1JQQy5NZXNzYWdlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::gRoom.gRPC.Messages.RecievedMessage), global::gRoom.gRPC.Messages.RecievedMessage.Parser, new[]{ "NewsTime", "Contents", "User" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RecievedMessage : pb::IMessage<RecievedMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RecievedMessage> _parser = new pb::MessageParser<RecievedMessage>(() => new RecievedMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RecievedMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::gRoom.gRPC.Messages.GroomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecievedMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecievedMessage(RecievedMessage other) : this() {
      newsTime_ = other.newsTime_ != null ? other.newsTime_.Clone() : null;
      contents_ = other.contents_;
      user_ = other.user_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RecievedMessage Clone() {
      return new RecievedMessage(this);
    }

    /// <summary>Field number for the "news_time" field.</summary>
    public const int NewsTimeFieldNumber = 1;
    private global::Google.Protobuf.WellKnownTypes.Timestamp newsTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp NewsTime {
      get { return newsTime_; }
      set {
        newsTime_ = value;
      }
    }

    /// <summary>Field number for the "contents" field.</summary>
    public const int ContentsFieldNumber = 2;
    private string contents_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Contents {
      get { return contents_; }
      set {
        contents_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 3;
    private string user_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string User {
      get { return user_; }
      set {
        user_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RecievedMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RecievedMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(NewsTime, other.NewsTime)) return false;
      if (Contents != other.Contents) return false;
      if (User != other.User) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (newsTime_ != null) hash ^= NewsTime.GetHashCode();
      if (Contents.Length != 0) hash ^= Contents.GetHashCode();
      if (User.Length != 0) hash ^= User.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (newsTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(NewsTime);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Contents);
      }
      if (User.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(User);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (newsTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(NewsTime);
      }
      if (Contents.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Contents);
      }
      if (User.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(User);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (newsTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(NewsTime);
      }
      if (Contents.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Contents);
      }
      if (User.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(User);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RecievedMessage other) {
      if (other == null) {
        return;
      }
      if (other.newsTime_ != null) {
        if (newsTime_ == null) {
          NewsTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        NewsTime.MergeFrom(other.NewsTime);
      }
      if (other.Contents.Length != 0) {
        Contents = other.Contents;
      }
      if (other.User.Length != 0) {
        User = other.User;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (newsTime_ == null) {
              NewsTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(NewsTime);
            break;
          }
          case 18: {
            Contents = input.ReadString();
            break;
          }
          case 26: {
            User = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (newsTime_ == null) {
              NewsTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(NewsTime);
            break;
          }
          case 18: {
            Contents = input.ReadString();
            break;
          }
          case 26: {
            User = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
