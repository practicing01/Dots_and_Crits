function Dots_and_Crits::Client_Load(%this)
{

echo("Loaded Client");

setNetPort(9002);

allowConnections(false);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Master_Server_Query);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

$GameConnection_Serverside_Connection=0;

$GameConnection_Connection=new GameConnection();

$GameConnection_Connection.setConnectArgs
(
$String_Client_Name,//Connector Name
"Client",//Connector Type
$String_Player_Sprite//Player Sprite
);

%this.Query_Master_Server();

}
