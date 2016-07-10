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



public partial class ClusterWorkerHeartbeat : TBase
{

  public string Storm_id { get; set; }

  public Dictionary<ExecutorInfo, ExecutorStats> Executor_stats { get; set; }

  public int Time_secs { get; set; }

  public int Uptime_secs { get; set; }

  public ClusterWorkerHeartbeat() {
  }

  public ClusterWorkerHeartbeat(string storm_id, Dictionary<ExecutorInfo, ExecutorStats> executor_stats, int time_secs, int uptime_secs) : this() {
    this.Storm_id = storm_id;
    this.Executor_stats = executor_stats;
    this.Time_secs = time_secs;
    this.Uptime_secs = uptime_secs;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_storm_id = false;
    bool isset_executor_stats = false;
    bool isset_time_secs = false;
    bool isset_uptime_secs = false;
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
            Storm_id = iprot.ReadString();
            isset_storm_id = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.Map) {
            {
              Executor_stats = new Dictionary<ExecutorInfo, ExecutorStats>();
              TMap _map213 = iprot.ReadMapBegin();
              for( int _i214 = 0; _i214 < _map213.Count; ++_i214)
              {
                ExecutorInfo _key215;
                ExecutorStats _val216;
                _key215 = new ExecutorInfo();
                _key215.Read(iprot);
                _val216 = new ExecutorStats();
                _val216.Read(iprot);
                Executor_stats[_key215] = _val216;
              }
              iprot.ReadMapEnd();
            }
            isset_executor_stats = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.I32) {
            Time_secs = iprot.ReadI32();
            isset_time_secs = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 4:
          if (field.Type == TType.I32) {
            Uptime_secs = iprot.ReadI32();
            isset_uptime_secs = true;
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
    if (!isset_storm_id)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_executor_stats)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_time_secs)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_uptime_secs)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("ClusterWorkerHeartbeat");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "storm_id";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Storm_id);
    oprot.WriteFieldEnd();
    field.Name = "executor_stats";
    field.Type = TType.Map;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.Struct, TType.Struct, Executor_stats.Count));
      foreach (ExecutorInfo _iter217 in Executor_stats.Keys)
      {
        _iter217.Write(oprot);
        Executor_stats[_iter217].Write(oprot);
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "time_secs";
    field.Type = TType.I32;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Time_secs);
    oprot.WriteFieldEnd();
    field.Name = "uptime_secs";
    field.Type = TType.I32;
    field.ID = 4;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Uptime_secs);
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("ClusterWorkerHeartbeat(");
    __sb.Append(", Storm_id: ");
    __sb.Append(Storm_id);
    __sb.Append(", Executor_stats: ");
    __sb.Append(Executor_stats);
    __sb.Append(", Time_secs: ");
    __sb.Append(Time_secs);
    __sb.Append(", Uptime_secs: ");
    __sb.Append(Uptime_secs);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif