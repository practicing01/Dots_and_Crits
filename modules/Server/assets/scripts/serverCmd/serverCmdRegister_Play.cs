function serverCmdRegister_Play(%Client)
{

%Client.Is_Playing=true;

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);

commandToClient(%Object,'Register_Play',%Client);

}

}
