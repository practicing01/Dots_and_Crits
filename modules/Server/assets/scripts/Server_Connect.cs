function Module_Server::Server_Connect(%this)
{

if ($Bool_Is_Local_Connection)
{

echo("Connecting to the local master server.");

}
else
{

echo("Connecting to the internet master server.");

$GameConnection_Connection.connect($IP_Master_Server);

}

}
