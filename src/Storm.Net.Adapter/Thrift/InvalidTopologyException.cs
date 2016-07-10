#if !NETSTANDARD13
/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;



public partial class InvalidTopologyException : TException, TBase
{

  public string Msg { get; set; }

  public InvalidTopologyException() {
  }

  public InvalidTopologyException(string msg) : this() {
    this.Msg = msg;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_msg = false;
    TField field;
    iprot.ReadStructBegin();
    while (true)
    {
      field = iprot.ReadFieldBegin();
      if (field.Type == TType.Stop) { 
        break;
      }
      switch (field.ID)
      {
        case 1:
          if (field.Type == TType.String) {
            Msg = iprot.ReadString();
            isset_msg = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        default: 
          TProtocolUtil.Skip(iprot, field.Type);
          break;
      }
      iprot.ReadFieldEnd();
    }
    iprot.ReadStructEnd();
    if (!isset_msg)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("InvalidTopologyException");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "msg";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Msg);
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("InvalidTopologyException(");
    __sb.Append(", Msg: ");
    __sb.Append(Msg);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif