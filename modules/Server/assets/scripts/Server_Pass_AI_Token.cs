function Module_Server::Server_Pass_AI_Token(%this)
{

%Bool_Token_Registered=false;

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Client=ClientGroup.getObject(%x);

if (%Client.Bool_A_I_Token_Bearer)
{

%Bool_Token_Registered=true;

break;

}

}

if (!%Bool_Token_Registered&&ClientGroup.getCount()>0)
{

%Random_Client=ClientGroup.getObject(getRandom(0,ClientGroup.getCount()-1));

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Client=ClientGroup.getObject(%x);

commandToClient(%Client,'Register_AI_Token',%Random_Client);

}

}

schedule(30000,0,"Module_Server::Server_Pass_AI_Token",%this);

}
