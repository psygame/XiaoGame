// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: JoinRoomReply.proto

package org.redstone.protobuf.msg;

public interface JoinRoomReplyOrBuilder extends
    // @@protoc_insertion_point(interface_extends:org.redstone.protobuf.msg.JoinRoomReply)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>optional .org.redstone.protobuf.msg.Enums.Camp camp = 1 [default = NoneCamp];</code>
   */
  boolean hasCamp();
  /**
   * <code>optional .org.redstone.protobuf.msg.Enums.Camp camp = 1 [default = NoneCamp];</code>
   */
  org.redstone.protobuf.msg.Enums.Camp getCamp();

  /**
   * <code>optional int32 roomId = 2;</code>
   */
  boolean hasRoomId();
  /**
   * <code>optional int32 roomId = 2;</code>
   */
  int getRoomId();

  /**
   * <code>optional .org.redstone.protobuf.msg.BoardSync boardSync = 3;</code>
   */
  boolean hasBoardSync();
  /**
   * <code>optional .org.redstone.protobuf.msg.BoardSync boardSync = 3;</code>
   */
  org.redstone.protobuf.msg.BoardSync getBoardSync();
  /**
   * <code>optional .org.redstone.protobuf.msg.BoardSync boardSync = 3;</code>
   */
  org.redstone.protobuf.msg.BoardSyncOrBuilder getBoardSyncOrBuilder();
}
