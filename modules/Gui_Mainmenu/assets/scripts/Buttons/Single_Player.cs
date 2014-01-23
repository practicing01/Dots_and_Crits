function Gui_Main_Menu::Single_Player(%this)
{

echo("Single player initiated.");

Dots_and_Crits.Game_Connection_Delete($GameConnection_Master_Server_Query);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

$Bool_Is_Local_Connection=true;

$Bool_A_I_Token_Bearer=true;

allowConnections(true);

setNetPort(9003);

$GameConnection_Connection=new GameConnection();//crash cus got master query response?

$GameConnection_Connection.setConnectArgs
(
$String_Client_Name,//Connector Name
"Client",//Connector Type
$String_Player_Sprite//Player Sprite
);

ClientGroup.deleteObjects();

$GameConnection_Connection.connectLocal();

}
