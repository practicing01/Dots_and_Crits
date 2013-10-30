function Module_Server::Scene_Initialize(%this)
{

$Bool_Is_Client=false;

setNetPort(9001);

allowConnections(true);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

$GameConnection_Connection=0;

$GameConnection_Connection=new GameConnection();

$GameConnection_Connection.setConnectArgs
(
%this.Server_Name,//Connector Name
"Server",//Connector Type
"0"//Player Sprite, none for server
);

%this.Server_Connect();

}
