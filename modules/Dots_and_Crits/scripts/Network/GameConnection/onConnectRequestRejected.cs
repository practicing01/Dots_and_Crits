function GameConnection::onConnectRequestRejected(%this,%reason)
{

echo("Game connection request rejected. reason:" SPC %reason);

schedule(0,0,"Dots_and_Crits::Game_Connection_Delete",Dots_and_Crits,$GameConnection_Master_Server_Query);

$GameConnection_Master_Server_Query=0;

}
