//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: JoinRoomRequest.proto
namespace org.redstone.protobuf.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JoinRoomRequest")]
  public partial class JoinRoomRequest : global::ProtoBuf.IExtensible
  {
    public JoinRoomRequest() {}
    
    private string _deviceUID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"deviceUID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string deviceUID
    {
      get { return _deviceUID; }
      set { _deviceUID = value; }
    }
    private int _roomId = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"roomId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int roomId
    {
      get { return _roomId; }
      set { _roomId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}