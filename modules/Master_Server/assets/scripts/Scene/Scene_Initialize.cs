function Module_Master_Server::Scene_Initialize(%this)
{

$Bool_Is_Client=false;

$Bool_Is_Master_Server=true;

setNetPort(9000);

allowConnections(true);

Dots_and_Crits.Game_Connection_Delete($GameConnection_Connection);

$GameConnection_Connection=0;

$GameConnection_Connection=new GameConnection();

}
