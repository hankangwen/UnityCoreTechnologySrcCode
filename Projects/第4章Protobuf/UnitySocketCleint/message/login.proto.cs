//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: login.proto
// Note: requires additional types generated from: common.proto
namespace clientmsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_login")]
  public partial class c2s_login : global::ProtoBuf.IExtensible
  {
    public c2s_login() {}
    

    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _pwd = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"pwd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string pwd
    {
      get { return _pwd; }
      set { _pwd = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_login")]
  public partial class s2c_login : global::ProtoBuf.IExtensible
  {
    public s2c_login() {}
    

    private uint _uaid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint uaid
    {
      get { return _uaid; }
      set { _uaid = value; }
    }

    private string _gsip = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gsip", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string gsip
    {
      get { return _gsip; }
      set { _gsip = value; }
    }

    private uint _gsport = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"gsport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint gsport
    {
      get { return _gsport; }
      set { _gsport = value; }
    }

    private clientmsg.enum_loginresult _loginresult = clientmsg.enum_loginresult.login_success;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"loginresult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(clientmsg.enum_loginresult.login_success)]
    public clientmsg.enum_loginresult loginresult
    {
      get { return _loginresult; }
      set { _loginresult = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"c2s_begingame")]
  public partial class c2s_begingame : global::ProtoBuf.IExtensible
  {
    public c2s_begingame() {}
    
    private uint _uaid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint uaid
    {
      get { return _uaid; }
      set { _uaid = value; }
    }

    private enum_usertype _type = enum_usertype.;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(enum_usertype.)]
    public enum_usertype type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"s2c_begingame")]
  public partial class s2c_begingame : global::ProtoBuf.IExtensible
  {
    public s2c_begingame() {}
    
    private uint _uaid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"uaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint uaid
    {
      get { return _uaid; }
      set { _uaid = value; }
    }

    private enum_begingameresult _result = enum_begingameresult.;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(enum_begingameresult.)]
    public enum_begingameresult result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuestLoginReq")]
  public partial class GuestLoginReq : global::ProtoBuf.IExtensible
  {
    public GuestLoginReq() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SNameRepetition")]
  public partial class C2SNameRepetition : global::ProtoBuf.IExtensible
  {
    public C2SNameRepetition() {}
    

    private msgcharinfo _charinfo = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public msgcharinfo charinfo
    {
      get { return _charinfo; }
      set { _charinfo = value; }
    }

    private uint _mapid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mapid
    {
      get { return _mapid; }
      set { _mapid = value; }
    }

    private uint _cityid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cityid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cityid
    {
      get { return _cityid; }
      set { _cityid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientSelectChar")]
  public partial class ClientSelectChar : global::ProtoBuf.IExtensible
  {
    public ClientSelectChar() {}
    

    private uint _uaid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint uaid
    {
      get { return _uaid; }
      set { _uaid = value; }
    }

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SaveCharInfo")]
  public partial class SaveCharInfo : global::ProtoBuf.IExtensible
  {
    public SaveCharInfo() {}
    

    private uint _uaid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint uaid
    {
      get { return _uaid; }
      set { _uaid = value; }
    }

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }

    private msgcharinfo _charinfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"charinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public msgcharinfo charinfo
    {
      get { return _charinfo; }
      set { _charinfo = value; }
    }

    private enumGetCharResult _result = enumGetCharResult.;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(enumGetCharResult.)]
    public enumGetCharResult result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CreateChar")]
  public partial class CreateChar : global::ProtoBuf.IExtensible
  {
    public CreateChar() {}
    

    private msgcharinfo _charinfo = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public msgcharinfo charinfo
    {
      get { return _charinfo; }
      set { _charinfo = value; }
    }

    private uint _mapid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mapid
    {
      get { return _mapid; }
      set { _mapid = value; }
    }

    private uint _cityid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"cityid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cityid
    {
      get { return _cityid; }
      set { _cityid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestIntoFightScene")]
  public partial class RequestIntoFightScene : global::ProtoBuf.IExtensible
  {
    public RequestIntoFightScene() {}
    

    private uint _island = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"island", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint island
    {
      get { return _island; }
      set { _island = value; }
    }

    private uint _mapid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"mapid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mapid
    {
      get { return _mapid; }
      set { _mapid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ClientExit")]
  public partial class ClientExit : global::ProtoBuf.IExtensible
  {
    public ClientExit() {}
    

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }

    private uint _user_account = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"user_account", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint user_account
    {
      get { return _user_account; }
      set { _user_account = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendChat")]
  public partial class SendChat : global::ProtoBuf.IExtensible
  {
    public SendChat() {}
    

    private clientmsg.enumChatType _type = clientmsg.enumChatType.Chat_User;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(clientmsg.enumChatType.Chat_User)]
    public clientmsg.enumChatType type
    {
      get { return _type; }
      set { _type = value; }
    }

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }

    private string _msg = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string msg
    {
      get { return _msg; }
      set { _msg = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendGreet")]
  public partial class SendGreet : global::ProtoBuf.IExtensible
  {
    public SendGreet() {}
    

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }

    private string _greet = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"greet", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string greet
    {
      get { return _greet; }
      set { _greet = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WordWindow")]
  public partial class WordWindow : global::ProtoBuf.IExtensible
  {
    public WordWindow() {}
    

    private enumWordmsgType _type = enumWordmsgType.;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(enumWordmsgType.)]
    public enumWordmsgType type
    {
      get { return _type; }
      set { _type = value; }
    }

    private string _content = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SChangeCloth")]
  public partial class C2SChangeCloth : global::ProtoBuf.IExtensible
  {
    public C2SChangeCloth() {}
    

    private uint _clothid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"clothid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint clothid
    {
      get { return _clothid; }
      set { _clothid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CChangeCloth")]
  public partial class S2CChangeCloth : global::ProtoBuf.IExtensible
  {
    public S2CChangeCloth() {}
    

    private uint _clothid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"clothid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint clothid
    {
      get { return _clothid; }
      set { _clothid = value; }
    }

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AssessCompany")]
  public partial class AssessCompany : global::ProtoBuf.IExtensible
  {
    public AssessCompany() {}
    

    private enumAssessType _assesstype = enumAssessType.;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"assesstype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(enumAssessType.)]
    public enumAssessType assesstype
    {
      get { return _assesstype; }
      set { _assesstype = value; }
    }

    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }

    private uint _stationid = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"stationid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint stationid
    {
      get { return _stationid; }
      set { _stationid = value; }
    }

    private uint _rank = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rank
    {
      get { return _rank; }
      set { _rank = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AssessPerson")]
  public partial class AssessPerson : global::ProtoBuf.IExtensible
  {
    public AssessPerson() {}
    

    private enumAssessType _assesstype = enumAssessType.;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"assesstype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(enumAssessType.)]
    public enumAssessType assesstype
    {
      get { return _assesstype; }
      set { _assesstype = value; }
    }

    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }

    private uint _rank = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rank
    {
      get { return _rank; }
      set { _rank = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InformAssess")]
  public partial class InformAssess : global::ProtoBuf.IExtensible
  {
    public InformAssess() {}
    

    private uint _rank = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rank
    {
      get { return _rank; }
      set { _rank = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"isCreateCharSuccess")]
  public partial class isCreateCharSuccess : global::ProtoBuf.IExtensible
  {
    public isCreateCharSuccess() {}
    

    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2SChangeSignature")]
  public partial class C2SChangeSignature : global::ProtoBuf.IExtensible
  {
    public C2SChangeSignature() {}
    

    private string _signature = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string signature
    {
      get { return _signature; }
      set { _signature = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CChangeSignature")]
  public partial class S2CChangeSignature : global::ProtoBuf.IExtensible
  {
    public S2CChangeSignature() {}
    

    private string _signature = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"signature", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string signature
    {
      get { return _signature; }
      set { _signature = value; }
    }

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResponseLoginReward")]
  public partial class ResponseLoginReward : global::ProtoBuf.IExtensible
  {
    public ResponseLoginReward() {}
    

    private string _loginserven = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"loginserven", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string loginserven
    {
      get { return _loginserven; }
      set { _loginserven = value; }
    }

    private string _loginadd = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"loginadd", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string loginadd
    {
      get { return _loginadd; }
      set { _loginadd = value; }
    }

    private uint _loginfive = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"loginfive", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint loginfive
    {
      get { return _loginfive; }
      set { _loginfive = value; }
    }

    private uint _loginday = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"loginday", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint loginday
    {
      get { return _loginday; }
      set { _loginday = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RequestLoginReward")]
  public partial class RequestLoginReward : global::ProtoBuf.IExtensible
  {
    public RequestLoginReward() {}
    

    private uint _uaid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"uaid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint uaid
    {
      get { return _uaid; }
      set { _uaid = value; }
    }

    private uint _charid = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"charid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint charid
    {
      get { return _charid; }
      set { _charid = value; }
    }

    private string _loginid = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"loginid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string loginid
    {
      get { return _loginid; }
      set { _loginid = value; }
    }

    private clientmsg.LoginType _logintype = clientmsg.LoginType.Login_Add;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"logintype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(clientmsg.LoginType.Login_Add)]
    public clientmsg.LoginType logintype
    {
      get { return _logintype; }
      set { _logintype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"enum_loginresult")]
    public enum enum_loginresult
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"login_success", Value=0)]
      login_success = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"login_fail", Value=1)]
      login_fail = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"login_accounterror", Value=2)]
      login_accounterror = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"login_relogin", Value=3)]
      login_relogin = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"enumChatType")]
    public enum enumChatType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Chat_User", Value=1)]
      Chat_User = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Chat_World", Value=2)]
      Chat_World = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Chat_Sys", Value=3)]
      Chat_Sys = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"LoginType")]
    public enum LoginType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"Login_Add", Value=1)]
      Login_Add = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Login_Five", Value=2)]
      Login_Five = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"Login_Seven", Value=3)]
      Login_Seven = 3
    }
  
}