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



public partial class ClusterSummary : TBase
{

  public List<SupervisorSummary> Supervisors { get; set; }

  public int Nimbus_uptime_secs { get; set; }

  public List<TopologySummary> Topologies { get; set; }

  public ClusterSummary() {
  }

  public ClusterSummary(List<SupervisorSummary> supervisors, int nimbus_uptime_secs, List<TopologySummary> topologies) : this() {
    this.Supervisors = supervisors;
    this.Nimbus_uptime_secs = nimbus_uptime_secs;
    this.Topologies = topologies;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_supervisors = false;
    bool isset_nimbus_uptime_secs = false;
    bool isset_topologies = false;
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
          if (field.Type == TType.List) {
            {
              Supervisors = new List<SupervisorSummary>();
              TList _list37 = iprot.ReadListBegin();
              for( int _i38 = 0; _i38 < _list37.Count; ++_i38)
              {
                SupervisorSummary _elem39;
                _elem39 = new SupervisorSummary();
                _elem39.Read(iprot);
                Supervisors.Add(_elem39);
              }
              iprot.ReadListEnd();
            }
            isset_supervisors = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.I32) {
            Nimbus_uptime_secs = iprot.ReadI32();
            isset_nimbus_uptime_secs = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.List) {
            {
              Topologies = new List<TopologySummary>();
              TList _list40 = iprot.ReadListBegin();
              for( int _i41 = 0; _i41 < _list40.Count; ++_i41)
              {
                TopologySummary _elem42;
                _elem42 = new TopologySummary();
                _elem42.Read(iprot);
                Topologies.Add(_elem42);
              }
              iprot.ReadListEnd();
            }
            isset_topologies = true;
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
    if (!isset_supervisors)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_nimbus_uptime_secs)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_topologies)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("ClusterSummary");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "supervisors";
    field.Type = TType.List;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteListBegin(new TList(TType.Struct, Supervisors.Count));
      foreach (SupervisorSummary _iter43 in Supervisors)
      {
        _iter43.Write(oprot);
      }
      oprot.WriteListEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "nimbus_uptime_secs";
    field.Type = TType.I32;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Nimbus_uptime_secs);
    oprot.WriteFieldEnd();
    field.Name = "topologies";
    field.Type = TType.List;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteListBegin(new TList(TType.Struct, Topologies.Count));
      foreach (TopologySummary _iter44 in Topologies)
      {
        _iter44.Write(oprot);
      }
      oprot.WriteListEnd();
    }
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("ClusterSummary(");
    __sb.Append(", Supervisors: ");
    __sb.Append(Supervisors);
    __sb.Append(", Nimbus_uptime_secs: ");
    __sb.Append(Nimbus_uptime_secs);
    __sb.Append(", Topologies: ");
    __sb.Append(Topologies);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif