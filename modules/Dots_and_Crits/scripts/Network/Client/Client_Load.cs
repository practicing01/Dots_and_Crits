function Dots_and_Crits::Client_Load(%this)
{

echo("Loaded Client");

setNetPort(9003);

allowConnections(false);

if (isObject($GameConnection_Connection))
{

$GameConnection_Connection.delete();

$GameConnection_Serverside_Connection=0;

}
else
{

$GameConnection_Connection=new GameConnection();

$GameConnection_Serverside_Connection=0;

$GameConnection_Connection.setConnectArgs
(
$String_Client_Name,//Connector Name
"Client",//Connector Type
$String_Player_Sprite//Player Sprite
);

}

%this.Query_Master_Server();

}
