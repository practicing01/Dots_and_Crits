function Dots_and_Crits::Query_Master_Server(%this)
{

if (!isObject($GameConnection_Master_Server_Query))//Not Connected
{

$GameConnection_Master_Server_Query=new GameConnection();

$GameConnection_Master_Server_Query.setConnectArgs
(
$String_Client_Name,//Connector Name
"Client",//Connector Type
$String_Player_Sprite//Player Sprite
);

if ($Bool_Is_Local_Connection)
{

echo("Connecting to the local master server for query.");

}
else
{

echo("Connecting to the internet master server for query.");

$GameConnection_Master_Server_Query.connect($IP_Master_Server);

}

}

}
