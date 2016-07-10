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



public partial class GetInfoOptions : TBase
{
  private NumErrorsChoice _num_err_choice;

  /// <summary>
  /// 
  /// <seealso cref="NumErrorsChoice"/>
  /// </summary>
  public NumErrorsChoice Num_err_choice
  {
    get
    {
      return _num_err_choice;
    }
    set
    {
      __isset.num_err_choice = true;
      this._num_err_choice = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool num_err_choice;
  }

  public GetInfoOptions() {
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
          if (field.Type == TType.I32) {
            Num_err_choice = (NumErrorsChoice)iprot.ReadI32();
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
    TStruct struc = new TStruct("GetInfoOptions");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (__isset.num_err_choice) {
      field.Name = "num_err_choice";
      field.Type = TType.I32;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI32((int)Num_err_choice);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("GetInfoOptions(");
    bool __first = true;
    if (__isset.num_err_choice) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Num_err_choice: ");
      __sb.Append(Num_err_choice);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
#endif