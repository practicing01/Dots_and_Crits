function Module_Map_Kana_Study::Random_Char_Get(%this)
{

%ScriptObject_Char=%this.Simset_Dictionary.getObject(getRandom(0,%this.Simset_Dictionary.getCount()-1));

return %ScriptObject_Char;

}
