// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: file_steam.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Filesteam {

  /// <summary>Holder for reflection information generated from file_steam.proto</summary>
  public static partial class FileSteamReflection {

    #region Descriptor
    /// <summary>File descriptor for file_steam.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FileSteamReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBmaWxlX3N0ZWFtLnByb3RvEglmaWxlc3RlYW0iLgoKZmlsZUJ1ZmZlchIO",
            "CgZCdWZmZXIYASABKAwSEAoIRmlsZU5hbWUYAiABKAkiJQoSZmlsZUJ1ZmZl",
            "clJlc3BvbnNlEg8KB1JlY2VpdmUYASABKAUyVgoQRmlsZVN0ZWFtU2Vydmlj",
            "ZRJCCghQdXNoRmlsZRIVLmZpbGVzdGVhbS5maWxlQnVmZmVyGh0uZmlsZXN0",
            "ZWFtLmZpbGVCdWZmZXJSZXNwb25zZSgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Filesteam.fileBuffer), global::Filesteam.fileBuffer.Parser, new[]{ "Buffer", "FileName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Filesteam.fileBufferResponse), global::Filesteam.fileBufferResponse.Parser, new[]{ "Receive" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class fileBuffer : pb::IMessage<fileBuffer> {
    private static readonly pb::MessageParser<fileBuffer> _parser = new pb::MessageParser<fileBuffer>(() => new fileBuffer());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<fileBuffer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Filesteam.FileSteamReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public fileBuffer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public fileBuffer(fileBuffer other) : this() {
      buffer_ = other.buffer_;
      fileName_ = other.fileName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public fileBuffer Clone() {
      return new fileBuffer(this);
    }

    /// <summary>Field number for the "Buffer" field.</summary>
    public const int BufferFieldNumber = 1;
    private pb::ByteString buffer_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Buffer {
      get { return buffer_; }
      set {
        buffer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "FileName" field.</summary>
    public const int FileNameFieldNumber = 2;
    private string fileName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FileName {
      get { return fileName_; }
      set {
        fileName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as fileBuffer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(fileBuffer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Buffer != other.Buffer) return false;
      if (FileName != other.FileName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Buffer.Length != 0) hash ^= Buffer.GetHashCode();
      if (FileName.Length != 0) hash ^= FileName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Buffer.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Buffer);
      }
      if (FileName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FileName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Buffer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Buffer);
      }
      if (FileName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FileName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(fileBuffer other) {
      if (other == null) {
        return;
      }
      if (other.Buffer.Length != 0) {
        Buffer = other.Buffer;
      }
      if (other.FileName.Length != 0) {
        FileName = other.FileName;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Buffer = input.ReadBytes();
            break;
          }
          case 18: {
            FileName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class fileBufferResponse : pb::IMessage<fileBufferResponse> {
    private static readonly pb::MessageParser<fileBufferResponse> _parser = new pb::MessageParser<fileBufferResponse>(() => new fileBufferResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<fileBufferResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Filesteam.FileSteamReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public fileBufferResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public fileBufferResponse(fileBufferResponse other) : this() {
      receive_ = other.receive_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public fileBufferResponse Clone() {
      return new fileBufferResponse(this);
    }

    /// <summary>Field number for the "Receive" field.</summary>
    public const int ReceiveFieldNumber = 1;
    private int receive_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Receive {
      get { return receive_; }
      set {
        receive_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as fileBufferResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(fileBufferResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Receive != other.Receive) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Receive != 0) hash ^= Receive.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Receive != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Receive);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Receive != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Receive);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(fileBufferResponse other) {
      if (other == null) {
        return;
      }
      if (other.Receive != 0) {
        Receive = other.Receive;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Receive = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
