function clientCmdHeartbeat(%Bool_Done_Beating,%Game_Connection_Handle)
{

if ($Simset_Live_Clients==0)
{

$Simset_Live_Clients=new SimSet();

}

%Script_Object_Live_Client=new ScriptObject()
{

Game_Connection_Handle=%Game_Connection_Handle;

};

$Simset_Live_Clients.add(%Script_Object_Live_Client);

if (%Bool_Done_Beating)
{

%Live_Client=0;

%Bool_Is_Alive=false;

for (%x=0;%x<$Simset_Players_Information.getCount();%x++)
{

%Player_Information=$Simset_Players_Information.getObject(%x);

%Live_Client=0;

%Bool_Is_Alive=false;

for (%y=0;%y<$Simset_Live_Clients.getCount();%y++)
{

%Live_Client=$Simset_Live_Clients.getObject(%y);

if (%Player_Information.Game_Connection_Handle==%Live_Client.Game_Connection_Handle)
{

%Bool_Is_Alive=true;

break;

}

}

if (!%Bool_Is_Alive)
{

if ($Bool_Is_Playing)
{

Module_Player_Class.Player_Data_Remove(%Player_Information);

}

$Simset_Players_Information.remove(%Player_Information);

%Player_Information.delete();

$Simset_Live_Clients.remove(%Live_Client);

%Live_Client.delete();

%x=-1;

}

}

$Simset_Live_Clients.deleteObjects();
$Simset_Live_Clients.delete();
$Simset_Live_Clients=0;

}

}
