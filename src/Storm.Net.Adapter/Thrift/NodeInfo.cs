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



public partial class NodeInfo : TBase
{

  public string Node { get; set; }

  public THashSet<long> Port { get; set; }

  public NodeInfo() {
  }

  public NodeInfo(string node, THashSet<long> port) : this() {
    this.Node = node;
    this.Port = port;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_node = false;
    bool isset_port = false;
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
            Node = iprot.ReadString();
            isset_node = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.Set) {
            {
              Port = new THashSet<long>();
              TSet _set181 = iprot.ReadSetBegin();
              for( int _i182 = 0; _i182 < _set181.Count; ++_i182)
              {
                long _elem183;
                _elem183 = iprot.ReadI64();
                Port.Add(_elem183);
              }
              iprot.ReadSetEnd();
            }
            isset_port = true;
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
    if (!isset_node)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_port)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("NodeInfo");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "node";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Node);
    oprot.WriteFieldEnd();
    field.Name = "port";
    field.Type = TType.Set;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteSetBegin(new TSet(TType.I64, Port.Count));
      foreach (long _iter184 in Port)
      {
        oprot.WriteI64(_iter184);
      }
      oprot.WriteSetEnd();
    }
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("NodeInfo(");
    __sb.Append(", Node: ");
    __sb.Append(Node);
    __sb.Append(", Port: ");
    __sb.Append(Port);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif