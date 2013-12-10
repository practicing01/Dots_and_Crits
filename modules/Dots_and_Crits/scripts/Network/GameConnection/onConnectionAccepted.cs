function GameConnection::onConnectionAccepted(%this)//client
{

echo("Game onConnectionAccepted." SPC %this);

if (isObject($GameConnection_Master_Server_Query)&&!$Bool_Is_Local_Connection)//this is a query connection
{

echo("Querying.");

if (isObject($Simset_Server_List))
{
$Simset_Server_List.deleteObjects();
}

commandToServer('Master_Server_Query_Request');

}
else if (isObject($GameConnection_Connection)&&$Bool_Is_Client)//this is a client to server connection
{

Module_Gui_Main_Menu.Scene_Unload();

Canvas.popDialog(Gui_Main_Menu);

Module_Gui_Server_Menu.Scene_Load();

}


}
