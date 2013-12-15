function clientCmdRegister_Card_To_Load(%Module_ID_Card)
{

if (!isObject($Simset_Cards_To_Load)){return;}

for (%x=0;%x<$Simset_Cards_To_Load.getCount();%x++)
{

%Card=$Simset_Cards_To_Load.getObject(%x);

if (%Card.Module_ID_Card$=%Module_ID_Card)
{

return;

}

}

%Script_Object=new ScriptObject()
{

Module_ID_Card=%Module_ID_Card;

};

$Simset_Cards_To_Load.add(%Script_Object);

if ($Bool_Is_Playing)
{



%Bool_Already_Loaded=false;

for (%y=0;%y<$Simset_Already_Loaded_Card_Modules.getCount();%y++)
{

%Already_Loaded_Module=$Simset_Already_Loaded_Card_Modules.getObject(%y);

if (%Already_Loaded_Module.Module_ID_Card$=%Module_ID_Card)
{

%Bool_Already_Loaded=true;

return;

}

}

%Already_Loaded_Module=new ScriptObject()
{

Module_ID_Card=%Module_ID_Card;

};

$Simset_Already_Loaded_Card_Modules.add(%Already_Loaded_Module);

ModuleDatabase.LoadExplicit(%Module_ID_Card);

%Module_ID_Card.Card_Load();

}

}
