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



public partial class TopologyActionOptions : TBase
{
  private KillOptions _kill_options;
  private RebalanceOptions _rebalance_options;

  public KillOptions Kill_options
  {
    get
    {
      return _kill_options;
    }
    set
    {
      __isset.kill_options = true;
      this._kill_options = value;
    }
  }

  public RebalanceOptions Rebalance_options
  {
    get
    {
      return _rebalance_options;
    }
    set
    {
      __isset.rebalance_options = true;
      this._rebalance_options = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool kill_options;
    public bool rebalance_options;
  }

  public TopologyActionOptions() {
  }

  public void Read (TProtocol iprot)
  {
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
          if (field.Type == TType.Struct) {
            Kill_options = new KillOptions();
            Kill_options.Read(iprot);
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.Struct) {
            Rebalance_options = new RebalanceOptions();
            Rebalance_options.Read(iprot);
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
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("TopologyActionOptions");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (Kill_options != null && __isset.kill_options) {
      field.Name = "kill_options";
      field.Type = TType.Struct;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      Kill_options.Write(oprot);
      oprot.WriteFieldEnd();
    }
    if (Rebalance_options != null && __isset.rebalance_options) {
      field.Name = "rebalance_options";
      field.Type = TType.Struct;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      Rebalance_options.Write(oprot);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("TopologyActionOptions(");
    bool __first = true;
    if (Kill_options != null && __isset.kill_options) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Kill_options: ");
      __sb.Append(Kill_options== null ? "<null>" : Kill_options.ToString());
    }
    if (Rebalance_options != null && __isset.rebalance_options) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Rebalance_options: ");
      __sb.Append(Rebalance_options== null ? "<null>" : Rebalance_options.ToString());
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif