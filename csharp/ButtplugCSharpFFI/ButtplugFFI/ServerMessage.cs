// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ButtplugFFI
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct ServerMessage : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static ServerMessage GetRootAsServerMessage(ByteBuffer _bb) { return GetRootAsServerMessage(_bb, new ServerMessage()); }
  public static ServerMessage GetRootAsServerMessage(ByteBuffer _bb, ServerMessage obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ServerMessage __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public ButtplugFFI.ServerMessageType MessageType { get { int o = __p.__offset(6); return o != 0 ? (ButtplugFFI.ServerMessageType)__p.bb.Get(o + __p.bb_pos) : ButtplugFFI.ServerMessageType.NONE; } }
  public TTable? Message<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(8); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }

  public static Offset<ButtplugFFI.ServerMessage> CreateServerMessage(FlatBufferBuilder builder,
      uint id = 0,
      ButtplugFFI.ServerMessageType message_type = ButtplugFFI.ServerMessageType.NONE,
      int messageOffset = 0) {
    builder.StartTable(3);
    ServerMessage.AddMessage(builder, messageOffset);
    ServerMessage.AddId(builder, id);
    ServerMessage.AddMessageType(builder, message_type);
    return ServerMessage.EndServerMessage(builder);
  }

  public static void StartServerMessage(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddId(FlatBufferBuilder builder, uint id) { builder.AddUint(0, id, 0); }
  public static void AddMessageType(FlatBufferBuilder builder, ButtplugFFI.ServerMessageType messageType) { builder.AddByte(1, (byte)messageType, 0); }
  public static void AddMessage(FlatBufferBuilder builder, int messageOffset) { builder.AddOffset(2, messageOffset, 0); }
  public static Offset<ButtplugFFI.ServerMessage> EndServerMessage(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ButtplugFFI.ServerMessage>(o);
  }
  public static void FinishServerMessageBuffer(FlatBufferBuilder builder, Offset<ButtplugFFI.ServerMessage> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedServerMessageBuffer(FlatBufferBuilder builder, Offset<ButtplugFFI.ServerMessage> offset) { builder.FinishSizePrefixed(offset.Value); }
};


}