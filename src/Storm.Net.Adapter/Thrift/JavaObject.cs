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



public partial class JavaObject : TBase
{

  public string Full_class_name { get; set; }

  public List<JavaObjectArg> Args_list { get; set; }

  public JavaObject() {
  }

  public JavaObject(string full_class_name, List<JavaObjectArg> args_list) : this() {
    this.Full_class_name = full_class_name;
    this.Args_list = args_list;
  }

  public void Read (TProtocol iprot)
  {
    bool isset_full_class_name = false;
    bool isset_args_list = false;
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
            Full_class_name = iprot.ReadString();
            isset_full_class_name = true;
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.List) {
            {
              Args_list = new List<JavaObjectArg>();
              TList _list0 = iprot.ReadListBegin();
              for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
              {
                JavaObjectArg _elem2;
                _elem2 = new JavaObjectArg();
                _elem2.Read(iprot);
                Args_list.Add(_elem2);
              }
              iprot.ReadListEnd();
            }
            isset_args_list = true;
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
    if (!isset_full_class_name)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
    if (!isset_args_list)
      throw new TProtocolException(TProtocolException.INVALID_DATA);
  }

  public void Write(TProtocol oprot) {
    TStruct struc = new TStruct("JavaObject");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    field.Name = "full_class_name";
    field.Type = TType.String;
    field.ID = 1;
    oprot.WriteFieldBegin(field);
    oprot.WriteString(Full_class_name);
    oprot.WriteFieldEnd();
    field.Name = "args_list";
    field.Type = TType.List;
    field.ID = 2;
    oprot.WriteFieldBegin(field);
    {
      oprot.WriteListBegin(new TList(TType.Struct, Args_list.Count));
      foreach (JavaObjectArg _iter3 in Args_list)
      {
        _iter3.Write(oprot);
      }
      oprot.WriteListEnd();
    }
    oprot.WriteFieldEnd();
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("JavaObject(");
    __sb.Append(", Full_class_name: ");
    __sb.Append(Full_class_name);
    __sb.Append(", Args_list: ");
    __sb.Append(Args_list);
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif