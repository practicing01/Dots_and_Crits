function Module_Server::Server_Heartbeat(%this)
{

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Client=ClientGroup.getObject(%x);

%Bool_Done_Beating=false;

for (%y=0;%y<ClientGroup.getCount();%y++)
{

%Client2=ClientGroup.getObject(%y);

if (%y==ClientGroup.getCount()-1)
{

%Bool_Done_Beating=true;

}

commandToClient(%Client,'Heartbeat',%Bool_Done_Beating,%Client2);

}

}

schedule(60000,0,"Module_Server::Server_Heartbeat",%this);

}
