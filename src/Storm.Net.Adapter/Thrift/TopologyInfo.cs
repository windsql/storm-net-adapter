#if !NETSTANDARD13
/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;



public partial class TopologyInfo : TBase
{
  private string _sched_status;
  private string _owner;

  public string Id { get; set; }

  public string Name { get; set; }

  public int Uptime_secs { get; set; }

  public List<ExecutorSummary> Executors { get; set; }

  public string Status { get; set; }

  public Dictionary<string, List<ErrorInfo>> Errors { get; set; }

  public string Sched_status
  {
    get
    {
      return _sched_status;
    }
    set
    {
      __isset.sched_status = true;
      this._sched_status = value;
    }
  }

  public string Owner
  {
    get
    {
      return _owner;
    }
    set
    {
      __isset.owner = true;
      this._owner = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool sched_status;
    public bool owner;
  }

  public TopologyInfo() {
  }

  public TopologyInfo(string id, string name, int uptime_secs, List<ExecutorSummary> executors, string status, Dictionary<string, List<ErrorInfo>> errors) : this() {
    this.Id = id;
    this.Name = name;
    this.Uptime_secs = uptime_secs;
    this.Executors = executors;
    this.Status = status;
    this.Errors = errors;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_id = false;
    bool isset_name = false;
    bool isset_uptime_secs = false;
    bool isset_executors = false;
    bool isset_status = false;
    bool isset_errors = false;
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
            Id = iprot.ReadString();
            isset_id = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            Name = iprot.ReadString();
            isset_name = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.I32) {
            Uptime_secs = iprot.ReadI32();
            isset_uptime_secs = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 4:
          if (field.Type == TType.List) {
            {
              Executors = new List<ExecutorSummary>();
              TList _list145 = iprot.ReadListBegin();
              for( int _i146 = 0; _i146 < _list145.Count; ++_i146)
              {
                ExecutorSummary _elem147;
                _elem147 = new ExecutorSummary();
                _elem147.Read(iprot);
                Executors.Add(_elem147);
              }
              iprot.ReadListEnd();
            }
            isset_executors = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 5:
          if (field.Type == TType.String) {
            Status = iprot.ReadString();
            isset_status = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 6:
          if (field.Type == TType.Map) {
            {
              Errors = new Dictionary<string, List<ErrorInfo>>();
              TMap _map148 = iprot.ReadMapBegin();
              for( int _i149 = 0; _i149 < _map148.Count; ++_i149)
              {
                string _key150;
                List<ErrorInfo> _val151;
                _key150 = iprot.ReadString();
                {
                  _val151 = new List<ErrorInfo>();
                  TList _list152 = iprot.ReadListBegin();
                  for( int _i153 = 0; _i153 < _list152.Count; ++_i153)
                  {
                    ErrorInfo _elem154;
                    _elem154 = new ErrorInfo();
                    _elem154.Read(iprot);
                    _val151.Add(_elem154);
                  }
                  iprot.ReadListEnd();
                }
                Errors[_key150] = _val151;
              }
              iprot.ReadMapEnd();
            }
            isset_errors = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 513:
          if (field.Type == TType.String) {
            Sched_status = iprot.ReadString();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 514:
          if (field.Type == TType.String) {
            Owner = iprot.ReadString();
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
    if (!isset_id)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_name)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_uptime_secs)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_executors)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_status)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_errors)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("TopologyInfo");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "id";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Id);
    oprot.WriteFieldEnd();
    field.Name = "name";
    field.Type = TType.String;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Name);
    oprot.WriteFieldEnd();
    field.Name = "uptime_secs";
    field.Type = TType.I32;
    field.ID = 3;
    oprot.WriteFieldBegin(field);
    oprot.WriteI32(Uptime_secs);
    oprot.WriteFieldEnd();
    field.Name = "executors";
    field.Type = TType.List;
    field.ID = 4;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteListBegin(new TList(TType.Struct, Executors.Count));
      foreach (ExecutorSummary _iter155 in Executors)
      {
        _iter155.Write(oprot);
      }
      oprot.WriteListEnd();
    }
    oprot.WriteFieldEnd();
    field.Name = "status";
    field.Type = TType.String;
    field.ID = 5;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Status);
    oprot.WriteFieldEnd();
    field.Name = "errors";
    field.Type = TType.Map;
    field.ID = 6;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteMapBegin(new TMap(TType.String, TType.List, Errors.Count));
      foreach (string _iter156 in Errors.Keys)
      {
        oprot.WriteString(_iter156);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Errors[_iter156].Count));
          foreach (ErrorInfo _iter157 in Errors[_iter156])
          {
            _iter157.Write(oprot);
          }
          oprot.WriteListEnd();
        }
      }
      oprot.WriteMapEnd();
    }
    oprot.WriteFieldEnd();
    if (Sched_status != null && __isset.sched_status) {
      field.Name = "sched_status";
      field.Type = TType.String;
      field.ID = 513;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Sched_status);
      oprot.WriteFieldEnd();
    }
    if (Owner != null && __isset.owner) {
      field.Name = "owner";
      field.Type = TType.String;
      field.ID = 514;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(Owner);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("TopologyInfo(");
    __sb.Append(", Id: ");
    __sb.Append(Id);
    __sb.Append(", Name: ");
    __sb.Append(Name);
    __sb.Append(", Uptime_secs: ");
    __sb.Append(Uptime_secs);
    __sb.Append(", Executors: ");
    __sb.Append(Executors);
    __sb.Append(", Status: ");
    __sb.Append(Status);
    __sb.Append(", Errors: ");
    __sb.Append(Errors);
    if (Sched_status != null && __isset.sched_status) {
      __sb.Append(", Sched_status: ");
      __sb.Append(Sched_status);
    }
    if (Owner != null && __isset.owner) {
      __sb.Append(", Owner: ");
      __sb.Append(Owner);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif