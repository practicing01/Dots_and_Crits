function Gui_Main_Menu::Refresh_Servers(%this)
{

echo("Refreshing server list.");

if (isObject($Simset_Server_List))
{

$Simset_Server_List.deleteObjects();

}

Dots_and_Crits.Game_Connection_Delete($GameConnection_Master_Server_Query);

Dots_and_Crits.Query_Master_Server();

}
