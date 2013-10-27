function serverCmdRegister_Play(%Client)
{

%Client.Is_Playing=true;

for (%x=0;%x<ClientGroup.getCount();%x++)
{

%Object=ClientGroup.getObject(%x);
echo("sent register play to client" SPC %Object);//banana
commandToClient(%Object,'Register_Play',%Client);

}

}
