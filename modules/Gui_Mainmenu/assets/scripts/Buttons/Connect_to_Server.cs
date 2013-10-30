function Gui_Main_Menu::Connect_to_Server(%this)
{

//If connected to something, disconnect.  Then connect to new server

if (Gui_List_Servers.getSelectedItem()!=-1)
{

%Server_Name=Gui_List_Servers.getItemText(Gui_List_Servers.getSelectedItem());

%Object_Server=0;

for (%x=0;%x<$Simset_Server_List.getCount();%x++)
{

%Object=$Simset_Server_List.getObject(%x);

if (%Object.Connector_Name$=%Server_Name)
{

%Object_Server=%Object;

break;

}

}

if (%Object_Server==0){return;}

Dots_and_Crits.Game_Connection_Delete($GameConnection_Master_Server_Query);

$GameConnection_Master_Server_Query=0;

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

$GameConnection_Connection=0;

$GameConnection_Serverside_Connection=0;

$GameConnection_Connection=new GameConnection();

$GameConnection_Connection.setConnectArgs
(
$String_Client_Name,//Connector Name
"Client",//Connector Type
$String_Player_Sprite//Player Sprite
);

echo("Connecting to server:" SPC %Object_Server.Connector_Name SPC "at:" SPC %Object_Server.IP_Address);

$GameConnection_Connection.connect(%Object_Server.IP_Address);

}

}
